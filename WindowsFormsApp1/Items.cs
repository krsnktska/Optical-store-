using System;
using System.Collections.Generic;
using System.Drawing;
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

			GetItems();
		}

		private void GetItems()
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

			for (int i = 0; i < items.Count; i++)
			{
				Item item = items[i];

				Panel itemPanel = new Panel
				{
					Size = new Size(225, 120),
					Margin = new Padding(10),
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
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
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
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Gray
				};
				itemPanel.Controls.Add(costLabel);

				Label countOfLabel = new Label
				{
					Text = $@"Залишилось: {item.CountOf} шт.",
					Location = new Point(10, 90),
					Size = new Size(180, 25),
					AutoSize = false,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
				};
				itemPanel.Controls.Add(countOfLabel);

				itemPanels[i] = itemPanel;
			}
			itemsFlowPanel.SuspendLayout();
			itemsFlowPanel.Controls.Clear();
			itemsFlowPanel.Controls.AddRange(itemPanels);
			itemsFlowPanel.ResumeLayout(true);
		}

		private void sortTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetItems();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			GetItems();
		}

		private void cancelSearchButton_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = string.Empty;
			GetItems();
		}

		private void fromQuantityText_KeyPress(object sender, KeyPressEventArgs e)
		{
			GetItems();
		}

		private void forQuantityText_KeyPress(object sender, KeyPressEventArgs e)
		{
			GetItems();
		}

		private void fromCostText_KeyPress(object sender, KeyPressEventArgs e)
		{
			GetItems();
		}

		private void homePicture_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
