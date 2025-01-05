using System;
using System.Collections.Generic;
using System.Drawing;
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
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
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
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
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
	}
}
