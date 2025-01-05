using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Items : Form
	{
		private int userId;

		public Items(int userId)
		{
			InitializeComponent();
			this.userId = userId;
			StartPosition = FormStartPosition.CenterScreen;

			int[] minMaxQ = Item.MinMaxQuantity();
			fromQuantityText.Text = minMaxQ[0].ToString();
			forQuantityText.Text = minMaxQ[1].ToString();

			int[] minMaxC = Item.MinMaxCost();
			fromCostText.Text = minMaxC[0].ToString();
			forCostText.Text = minMaxC[1].ToString();

			sortTypes.SelectedIndex = 0;
		}

		private void Items_Load(object sender, EventArgs e)
		{
			sortTypes.SelectedIndex = 0;

			UpdateForm();
		}

		private void UpdateForm()
		{
			string searchRequest = searchTextBox.Text;

			int fromQuantity;
			if (!int.TryParse(fromQuantityText.Text, out fromQuantity))
			{
				fromQuantity = 0;
			}
			int forQuantity;
			if (!int.TryParse(forQuantityText.Text, out forQuantity))
			{
				forQuantity = int.MaxValue;
			}
			if (fromQuantity > forQuantity)
			{
				fromQuantity = forQuantity;
				forQuantity = fromQuantity;
			}

			int fromCost;
			if (!int.TryParse(fromCostText.Text, out fromCost))
			{
				fromCost = 0;
			}
			int forCost;
			if (!int.TryParse(forCostText.Text, out forCost))
			{
				forCost = int.MaxValue;
			}
			if (fromCost > forCost)
			{
				fromCost = forCost;
				forCost = fromCost;
			}

			string sortParameter = sortTypes.SelectedIndex.ToString();
			string orderBy = @"I.item_id";
			switch (sortParameter)
			{
				case "0":
					orderBy = @"I.name_of_the_product ASC";
					break;
				case "1":
					orderBy = @"I.name_of_the_product DESC";
					break;
				case "2":
					orderBy = "I.cost ASC";
					break;
				case "3":
					orderBy = "I.cost DESC";
					break;
			}

			List<Item> items = Item.GetItemsByFilters(searchRequest, orderBy, fromQuantity, forQuantity, fromCost, forCost);
			Control[] itemPanels = new Control[items.Count];
			int itemsCount = 0;

			for (int i = 0; i < items.Count; i++)
			{
				Item item = items[i];

				itemsCount += item.CountOf;

				Panel itemPanel = new Panel
				{
					Size = new Size(225, 120),
					Margin = new Padding(5),
					BorderStyle = BorderStyle.FixedSingle
				};

				toolTip.SetToolTip(itemPanel, item.NameOfTheProduct);

				LinkLabel nameLabel = new LinkLabel
				{
					Text = item.NameOfTheProduct,
					Location = new Point(10, 10),
					MaximumSize = new Size(180, 50),
					MinimumSize = new Size(180, 50),
					AutoEllipsis = true,
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black,

				};
				nameLabel.Click += (object sender, EventArgs e) =>
				{
					ItemDetails itemDetailsForm = new ItemDetails(userId, item);
					itemDetailsForm.Show();
				};

				itemPanel.Controls.Add(nameLabel);

				Label costLabel = new Label
				{
					Text = $@"Ціна: {item.Cost} грн",
					Location = new Point(10, 60),
					Size = new Size(180, 30),
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Gray
				};
				itemPanel.Controls.Add(costLabel);

				Label countOfLabel = new Label
				{
					Text = $@"Залишилось: {item.CountOf} шт.",
					Location = new Point(10, 90),
					Size = new Size(180, 25),
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
				};
				itemPanel.Controls.Add(countOfLabel);

				itemPanels[i] = itemPanel;
			}
			itemsFlowPanel.SuspendLayout();
			itemsFlowPanel.Controls.Clear();
			itemsFlowPanel.Controls.AddRange(itemPanels);
			itemsFlowPanel.ResumeLayout(true);

			itemsCountLabel.Text = $"Всього товарів - {itemsCount}.";

			List<Item> popularItems = Item.GetPopularItems();
			itemPanels = new Control[popularItems.Count];

			for (int i = 0; i < popularItems.Count; i++)
			{
				Item item = popularItems[i];

				Panel itemPanel = new Panel
				{
					Size = new Size(235, 120),
					Margin = new Padding(5),
					BorderStyle = BorderStyle.FixedSingle
				};

				toolTip.SetToolTip(itemPanel, item.NameOfTheProduct);

				LinkLabel nameLabel = new LinkLabel
				{
					Text = item.NameOfTheProduct,
					Location = new Point(10, 10),
					MaximumSize = new Size(180, 50),
					MinimumSize = new Size(180, 50),
					AutoEllipsis = true,
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black,

				};
				nameLabel.Click += (object sender, EventArgs e) =>
				{
					ItemDetails itemDetailsForm = new ItemDetails(userId, item);
					itemDetailsForm.Show();
				};

				itemPanel.Controls.Add(nameLabel);

				Label costLabel = new Label
				{
					Text = $@"Ціна: {item.Cost} грн",
					Location = new Point(10, 60),
					Size = new Size(180, 30),
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Gray
				};
				itemPanel.Controls.Add(costLabel);

				Label countOfLabel = new Label
				{
					Text = $@"Залишилось: {item.CountOf} шт.",
					Location = new Point(10, 90),
					Size = new Size(180, 25),
					AutoSize = false,
					Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold),
				};
				itemPanel.Controls.Add(countOfLabel);

				itemPanels[i] = itemPanel;
			}
			popularItemsFlowPanel.SuspendLayout();
			popularItemsFlowPanel.Controls.Clear();
			popularItemsFlowPanel.Controls.AddRange(itemPanels);
			popularItemsFlowPanel.ResumeLayout(true);
		}

		private void sortTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void cancelSearchButton_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = string.Empty;
			UpdateForm();
		}

		private void fromQuantityText_KeyPress(object sender, KeyPressEventArgs e)
		{
			UpdateForm();
		}

		private void forQuantityText_KeyPress(object sender, KeyPressEventArgs e)
		{
			UpdateForm();
		}

		private void fromCostText_KeyPress(object sender, KeyPressEventArgs e)
		{
			UpdateForm();
		}

		private void homePicture_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void generatePdfButton_Click(object sender, EventArgs e)
		{
			List<Item> items = Item.GetItems();

			// Використовуємо SaveFileDialog, аби користувач міг вибрати де зберегти PDF
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "PDF files (*.pdf)|*.pdf";
				sfd.Title = "Зберегти PDF-файл";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					// Шлях, де створиться PDF
					string pdfPath = sfd.FileName;

					// Створюємо документ із полями відступів
					Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

					try
					{
						PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
						doc.Open();

						// ** 1) Завантажуємо шрифт, який підтримує кирилицю **
						// Припустимо, що у нас є файл шрифту "arialuni.ttf" у системній папці шрифтів Windows
						// Або власний .ttf, який ви поклали в проєкт. Головне – шлях і наявність кириличних гліфів.

						byte[] fontData = Properties.Resources.roboto;

						// Створюємо BaseFont (з кодуванням Identity-H та EMBEDDED)
						BaseFont baseFont = BaseFont.CreateFont(
							"roboto.ttf",
							BaseFont.IDENTITY_H,
							BaseFont.EMBEDDED,
							true,
							fontData,
							null
						);

						// Створюємо Font на основі BaseFont
						// Розмір шрифту, стиль, колір тощо можна змінити
						iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
						iTextSharp.text.Font columnHeaderFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
						iTextSharp.text.Font cellFont = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

						// 2) Додаємо заголовок
						Paragraph mainHeader = new Paragraph("Товари", headerFont)
						{
							Alignment = Element.ALIGN_CENTER,
							SpacingAfter = 20f
						};
						doc.Add(mainHeader);

						// 3) Створюємо таблицю на 6 колонок
						PdfPTable table = new PdfPTable(6)
						{
							WidthPercentage = 100
						};

						// Задаємо відносні ширини, щоби числові колонки були вужчі
						float[] columnWidths = new float[] { 1f, 2.5f, 1f, 3f, 1f, 2f };
						table.SetWidths(columnWidths);

						// 4) Додаємо заголовки колонок (українською, приклад)
						table.AddCell(new PdfPCell(new Phrase("ID", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Назва товару", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Ціна", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Опис", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Кількість", columnHeaderFont)));
						table.AddCell(new PdfPCell(new Phrase("Виробник", columnHeaderFont)));

						// 5) Заповнюємо комірки таблиці
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
					}
					catch (Exception ex)
					{
						MessageBox.Show("Помилка при створенні PDF: " + ex.Message);
					}
					finally
					{
						doc.Close();
					}

					MessageBox.Show("PDF успішно згенеровано!");
				}
			}
		}
	}
}
