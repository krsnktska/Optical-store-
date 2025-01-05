using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class OrdersForm : Form
	{
		public int UserID;

		public OrdersForm(int userId)
		{
			UserID = userId;
			InitializeComponent();
		}

		private void OrdersForm_Load(object sender, System.EventArgs e)
		{
			Order.UpdateOrderStatusesAndItemsCount();
			SetDefaults();
			UpdateForm();
		}

		private void SetDefaults()
		{
			dateFromPicker.Value = dateFromPicker.MinDate;
			dateToPicker.Value = DateTime.Now;
			acceptedCheckBox.Checked = true;
			cancelledCheckBox.Checked = true;
			inWorkCheckBox.Checked = true;
			doneCheckBox.Checked = true;
			orderByComboBox.SelectedIndex = 0;
			searchTextBox.Text = "";
		}

		public void UpdateForm()
		{
			var stats = Order.GetOrdersStats(UserID);
			if (stats.Count == 0)
			{
				statsLabel.Text = "Ви ще не зробили жодного замовлення";
			}
			else
			{
				int sum = 0;
				statsLabel.Text = "Замовлень зі статусом ";

				List<string> strings = new List<string>();
				foreach (KeyValuePair<string, int> entry in stats)
				{
					strings.Add($"{entry.Key} - {entry.Value}");
					sum += entry.Value;
				}

				statsLabel.Text += $"{string.Join(", ", strings)}. Всього - {sum}.";
			}

			string searchRequest = searchTextBox.Text;

			string orderBy;
			switch (orderByComboBox.SelectedIndex)
			{
				case 0:
					orderBy = "o.formation_date DESC, o.formation_time DESC";
					break;
				case 1:
					orderBy = "o.formation_date ASC, o.formation_time ASC";
					break;
				case 2:
					//orderBy = @"CASE
					//				WHEN o.status = 'Скасовано' THEN 1
					//				WHEN o.status = 'Виконано' THEN 2
					//				WHEN o.status = 'В обробці' THEN 3
					//				WHEN o.status = 'Прийнято' THEN 4
					//			END,
					//			    o.formation_date DESC,
					//			    o.formation_time DESC";
					orderBy = "o.status DESC";
					break;
				default:
					orderBy = "o.formation_date DESC, o.formation_time DESC";
					break;
			}

			DateTime fromDate = dateFromPicker.Value;
			DateTime toDate = dateToPicker.Value;

			List<string> statuses = new List<string>();

			if (acceptedCheckBox.Checked) { statuses.Add(@"'Прийнято'"); }
			if (inWorkCheckBox.Checked) { statuses.Add(@"'В обробці'"); }
			if (doneCheckBox.Checked) { statuses.Add(@"'Виконано'"); }
			if (cancelledCheckBox.Checked) { statuses.Add(@"'Скасовано'"); }

			List<Order> orders = Order.GetOrdersForUserWithFilters(UserID, searchRequest, orderBy, fromDate, toDate, String.Join(", ", statuses));
			Control[] orderPanels = new Control[orders.Count];

			int width = ordersFlowLayoutPanel.Width - (orders.Count > 3 ? 20 : 0) - 10;

			Console.WriteLine(orders.Count);

			for (int i = 0; i < orders.Count; i++)
			{
				Order order = orders[i];

				FlowLayoutPanel orderPanel = new FlowLayoutPanel
				{
					MaximumSize = new Size(width, 0),
					AutoSize = true,
					Margin = new Padding(5),
					BorderStyle = BorderStyle.FixedSingle
				};

				LinkLabel orderLabel = new LinkLabel
				{
					Text = $"Замовлення №{order.OrderID}",
					Size = new Size((int)((width - 20) * 0.7), 24),
					AutoEllipsis = true,
					AutoSize = false,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black,
				};
				orderLabel.Click += (object sender, EventArgs e) =>
				{
					OrderForm orderForm = new OrderForm(order);
					orderForm.ShowDialog();
					UpdateForm();
				};
				orderPanel.Controls.Add(orderLabel);

				Label statusLabel = new Label
				{
					Text = $@"{order.Status}",
					Size = new Size((int)((width - 20) * 0.3), 24),
					AutoSize = false,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Green
				};
				orderPanel.Controls.Add(statusLabel);

				Label dateTimeLabel = new Label
				{
					Text = $@"Сформовано {order.FormationDate.ToLongDateString()} - {order.FormationTime.ToString(@"hh\:mm")}",
					Size = new Size(width - 10, 24),
					Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
				};
				orderPanel.Controls.Add(dateTimeLabel);

				orderPanels[i] = orderPanel;
			}
			ordersFlowLayoutPanel.SuspendLayout();
			ordersFlowLayoutPanel.Controls.Clear();
			ordersFlowLayoutPanel.Controls.AddRange(orderPanels);
			ordersFlowLayoutPanel.ResumeLayout(true);
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void orderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void acceptedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void inWorkCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void doneCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void cancelledCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void dateFromPicker_ValueChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void dateToPicker_ValueChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			SetDefaults();
			UpdateForm();
		}
	}
}