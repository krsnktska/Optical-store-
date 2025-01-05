using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class CartForm : Form
	{

		private int UserID;
		private Cart Cart;
		public CartForm(int userId)
		{
			UserID = userId;
			Cart = Cart.GetCartForUser(UserID);

			InitializeComponent();
		}

		private void CartForm_Load(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void UpdateForm()
		{
			Cart = Cart.GetCartForUser(UserID);

			totalPriceLabel.Text = $"Сума: {Cart.TotalPrice} грн";
			totalQuantityLabel.Text = $"Кількість: {Cart.Quantity} шт.";

			List<Item> items = Cart.GetItemsInCart(Cart.CartID);
			Control[] itemPanels = new Control[items.Count];

			int width = itemsFlowLayoutPanel.Width - (items.Count > 2 ? 20 : 0) - 10;

			for (int i = 0; i < items.Count; i++)
			{
				Item item = items[i];

				FlowLayoutPanel itemPanel = new FlowLayoutPanel
				{
					MinimumSize = new Size(width - 10, 100),
					AutoSize = true,
					Margin = new Padding(5, 10, 5, 10),
					BorderStyle = BorderStyle.FixedSingle
				};

				toolTip.SetToolTip(itemPanel, item.NameOfTheProduct);

				LinkLabel nameLabel = new LinkLabel
				{
					Text = item.NameOfTheProduct,
					Size = new Size(width - 10, 50),
					AutoEllipsis = true,
					AutoSize = false,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black,

				};
				nameLabel.Click += (object sender, EventArgs e) =>
				{
					ItemDetails itemDetailsForm = new ItemDetails(UserID, item);
					itemDetailsForm.Show();
				};

				itemPanel.Controls.Add(nameLabel);

				Label costLabel = new Label
				{
					Text = $@"Ціна: {item.Cost} грн * {item.CountOfInCart} = {item.CountOfInCart * item.Cost} грн",
					Size = new Size(width - 10, 24),
					AutoSize = false,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Gray
				};
				itemPanel.Controls.Add(costLabel);

				Button decreaseButton = new Button()
				{
					Size = new Size(width / 3 - 10, 24),
					BackgroundImage = Properties.Resources.remove,
					BackgroundImageLayout = ImageLayout.Zoom,
					Enabled = 1 != item.CountOfInCart
				};
				decreaseButton.Click += (object sender, EventArgs e) =>
				{
					Cart.DecreaseItemQuantity(Cart.CartID, item.ItemID);
					this.UpdateForm();
				};
				itemPanel.Controls.Add(decreaseButton);

				Button increaseButton = new Button()
				{
					Size = new Size(width / 3 - 10, 24),
					BackgroundImage = Properties.Resources.add,
					BackgroundImageLayout = ImageLayout.Zoom,
					Enabled = !(item.CountOf == item.CountOfInCart)
				};
				increaseButton.Click += (object sender, EventArgs e) =>
				{
					Cart.IncreaseItemQuantity(Cart.CartID, item.ItemID);
					this.UpdateForm();
				};
				itemPanel.Controls.Add(increaseButton);

				Button deleteButton = new Button()
				{
					Size = new Size(width / 3 - 10, 24),
					BackgroundImage = Properties.Resources.delete,
					BackgroundImageLayout = ImageLayout.Zoom
				};
				deleteButton.Click += (object sender, EventArgs e) =>
				{

					if (MessageBox.Show("Ви впевнені що хочете вилучити товар з кошика?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						Cart.DeleteItemFromCart(Cart.CartID, item.ItemID);
						this.UpdateForm();
					}
				};
				itemPanel.Controls.Add(deleteButton);

				itemPanels[i] = itemPanel;
			}

			Console.WriteLine(itemPanels.Length);
			itemsFlowLayoutPanel.SuspendLayout();
			itemsFlowLayoutPanel.Controls.Clear();
			itemsFlowLayoutPanel.Controls.AddRange(itemPanels);
			itemsFlowLayoutPanel.ResumeLayout(true);
		}

		private void orderButton_Click(object sender, EventArgs e)
		{
			CreateOrderForm createOrderForm = new CreateOrderForm(UserID);
			if (createOrderForm.ShowDialog() == DialogResult.OK)
			{
				UpdateForm();
			}
		}
	}
}
