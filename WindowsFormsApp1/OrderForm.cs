using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class OrderForm : Form
	{
		Order Order;

		public OrderForm(Order order)
		{
			Order = order;
			InitializeComponent();
		}

		public void UpdateForm()
		{
			Order = Order.GetOrderById(Order.OrderID);

			orderNumberLabel.Text = $"Замовлення №{Order.OrderID}";
			statusLabel.Text = $"{Order.Status}";
			priceLabel.Text = $"Ціна: {Order.TotalPrice.ToString()} грн";
			countLabel.Text = $"Кількість: {Order.TotalQuantity.ToString()} шт.";
			commentLabel.Text = $"{Order.Comment}";
			dateLabel.Text = $"Дата і час формування: {Order.FormationDate.ToLongDateString()} - {Order.FormationTime.ToString(@"hh\:mm")}";

			addressLabel.Text = $"{Order.Address.ToString()}";

			cancelButton.Enabled = Order.Status == "Прийнято";

			List<Item> items = Order.GetItemsInOrder(Order.OrderID);
			Control[] itemPanels = new Control[items.Count];

			int width = itemsFlowLayoutPanel.Width - (items.Count > 3 ? 20 : 0) - 10;

			for (int i = 0; i < items.Count; i++)
			{
				Item item = items[i];

				FlowLayoutPanel itemPanel = new FlowLayoutPanel
				{
					MinimumSize = new Size(width - 10, 0),
					AutoSize = true,
					Margin = new Padding(5),
					BorderStyle = BorderStyle.FixedSingle
				};

				toolTip.SetToolTip(itemPanel, item.NameOfTheProduct);

				LinkLabel nameLabel = new LinkLabel
				{
					Text = item.NameOfTheProduct,
					Size = new Size(width - 10, 24),
					AutoEllipsis = true,
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black,

				};
				nameLabel.Click += (object sender, EventArgs e) =>
				{
					ItemDetails itemDetailsForm = new ItemDetails(Order.UserID, item);
					itemDetailsForm.Show();
				};

				itemPanel.Controls.Add(nameLabel);

				Label costLabel = new Label
				{
					Text = $@"Ціна: {item.Cost} грн * {item.CountOfInOrder} = {item.CountOfInOrder * item.Cost} грн",
					Size = new Size(width - 10, 24),
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Gray
				};
				itemPanel.Controls.Add(costLabel);

				itemPanels[i] = itemPanel;
			}

			Console.WriteLine(itemPanels.Length);
			itemsFlowLayoutPanel.SuspendLayout();
			itemsFlowLayoutPanel.Controls.Clear();
			itemsFlowLayoutPanel.Controls.AddRange(itemPanels);
			itemsFlowLayoutPanel.ResumeLayout(true);
		}

		private void OrderForm_Load(object sender, System.EventArgs e)
		{
			UpdateForm();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Order.CancelOrder(Order.OrderID);
			UpdateForm();
		}

		private void getBillButton_Click(object sender, EventArgs e)
		{
			List<Item> items = Order.GetItemsInOrder(Order.OrderID);

			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "PDF files (*.pdf)|*.pdf";
				sfd.Title = "Зберегти PDF-файл";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					string pdfPath = sfd.FileName;

					Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

					try
					{
						PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
						doc.Open();


						byte[] fontData = Properties.Resources.roboto;

						BaseFont baseFont = BaseFont.CreateFont(
							"roboto.ttf",
							BaseFont.IDENTITY_H,
							BaseFont.EMBEDDED,
							true,
							fontData,
							null
						);

						iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
						iTextSharp.text.Font columnHeaderFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
						iTextSharp.text.Font cellFont = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
						iTextSharp.text.Font normalFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

						Paragraph mainHeader = new Paragraph($"Замовелння №{Order.OrderID}", headerFont)
						{
							Alignment = Element.ALIGN_CENTER,
							SpacingAfter = 20f
						};
						doc.Add(mainHeader);

						Paragraph dateTime = new Paragraph($"Сформовано {Order.FormationDate.ToLongDateString()} {Order.FormationTime.ToString(@"hh\:mm")}", normalFont)
						{
							Alignment = Element.ALIGN_LEFT
						};
						doc.Add(dateTime);

						if (Order.Comment != "")
						{
							Paragraph comment = new Paragraph($"Коментар до замовлення - {Order.Comment}", normalFont)
							{
								Alignment = Element.ALIGN_LEFT
							};
							doc.Add(comment);
						}

						Paragraph address = new Paragraph($"Адреса доставки - {Order.Address.ToString()}", normalFont)
						{
							Alignment = Element.ALIGN_LEFT,
							SpacingAfter = 20f
						};
						doc.Add(address);


						PdfPTable table = new PdfPTable(6)
						{
							WidthPercentage = 100,
							SpacingAfter = 20f
						};

						float[] columnWidths = new float[] { 1f, 2.5f, 1f, 3f, 1f, 2f };
						table.SetWidths(columnWidths);

						table.AddCell(new PdfPCell(new Phrase("ID", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Назва товару", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Ціна", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Опис", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Кількість", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Виробник", columnHeaderFont)));

						foreach (var item in items)
						{
							table.AddCell(new PdfPCell(new Phrase(item.ItemID.ToString(), cellFont)));
							table.AddCell(new PdfPCell(new Phrase(item.NameOfTheProduct, cellFont)));
							table.AddCell(new PdfPCell(new Phrase(item.Cost.ToString(), cellFont)));
							table.AddCell(new PdfPCell(new Phrase(item.Description, cellFont)));
							table.AddCell(new PdfPCell(new Phrase(item.CountOf.ToString(), cellFont)));
							table.AddCell(new PdfPCell(new Phrase(item.Producer, cellFont)));
						}
						doc.Add(table);

						Paragraph total = new Paragraph($"Всього: {Order.TotalPrice} грн", columnHeaderFont)
						{
							Alignment = Element.ALIGN_RIGHT
						};
						doc.Add(total);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Помилка при створенні PDF: " + ex.Message);
					}
					finally
					{
						doc.Close();
					}

					MessageBox.Show("Звіт створено");
				}
			}
		}
	}
}
