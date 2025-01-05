using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ItemDetails : Form
	{
		private int userId;
		private Item currentItem;

		public ItemDetails(int userId, Item item)
		{
			InitializeComponent();
			this.userId = userId;
			this.currentItem = item;
			StartPosition = FormStartPosition.CenterScreen;
			UpdateForm();
		}

		private void UpdateForm()
		{
			reviewButton.Enabled = Item.CheckIfItemBought(userId, currentItem.ItemID) != 0;

			// Text fields
			itemName.Text = currentItem.NameOfTheProduct;
			itemCost.Text = $@"Ціна: {currentItem.Cost} грн";
			itemCountOf.Text = $@"Залишилось: {currentItem.CountOf.ToString()}";
			itemProducer.Text = $@"Виробник: {currentItem.Producer}";
			itemDescription.Text = $@"Опис: {currentItem.Description}";

			// Properties
			List<PropertyWithValue> props = PropertyWithValue.GetPropsForItem(currentItem.ItemID);
			Control[] propPanels = new Control[props.Count];

			int width = propertiesFlowPanel.Width - 25;

			for (int i = 0; i < props.Count; i++)
			{
				PropertyWithValue prop = props[i];

				Panel propPanel = new Panel
				{
					Size = new Size(width, 25),
					Margin = new Padding(10, 5, 10, 5),
					Padding = new Padding(2),
					BorderStyle = BorderStyle.FixedSingle
				};

				Label typeLabel = new Label
				{
					Text = prop.Type,
					Location = new Point(0, 0),
					Size = new Size(width / 2, 20),
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black
				};
				propPanel.Controls.Add(typeLabel);

				Label valueLabel = new Label
				{
					Text = prop.Value,
					AutoEllipsis = true,
					Location = new Point(width / 2, 0),
					Size = new Size(width / 2, 20),
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
					ForeColor = Color.Gray
				};
				toolTip.SetToolTip(valueLabel, prop.Value);
				propPanel.Controls.Add(valueLabel);

				propPanels[i] = propPanel;
			}

			propertiesFlowPanel.SuspendLayout();
			propertiesFlowPanel.Controls.Clear();
			propertiesFlowPanel.Controls.AddRange(propPanels);
			propertiesFlowPanel.ResumeLayout(true);

			// Feedback
			List<Feedback> feedbacks = Feedback.GetFeedbackForItem(currentItem.ItemID);
			Control[] feedbackPanels = new Control[feedbacks.Count];

			width = feedbackFlowPanel.Width;

			int sum = 0;
			for (int i = 0; i < feedbacks.Count; i++)
			{
				Font font;
				Feedback feedback = feedbacks[i];

				sum += feedback.Rating;

				Panel feedbackPanel = new Panel
				{
					MaximumSize = new Size(width - 25, 0),
					MinimumSize = new Size(width - 25, 25),
					Margin = new Padding(10, 5, 10, 5),
					BorderStyle = BorderStyle.FixedSingle,
					AutoSize = true
				};

				Label nameLabel = new Label
				{
					Text = $@"{feedback.Surname} {feedback.Name} {feedback.Patronymic}",
					AutoSize = true,
					MaximumSize = new Size(width - 40, 0),
					Location = new Point(0, 0),
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.Black
				};
				feedbackPanel.Controls.Add(nameLabel);

				Label rateLabel = new Label
				{
					Text = $@"{feedback.Rating}",
					Location = new Point(width - 50, 0),
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
					ForeColor = Color.DarkGreen
				};
				feedbackPanel.Controls.Add(rateLabel);

				Label commentLabel = new Label
				{
					Text = feedback.Comment,
					AutoEllipsis = true,
					Location = new Point(0, nameLabel.Height + 2),
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
					ForeColor = Color.Gray,
					AutoSize = true,
					MaximumSize = new Size(width - 40, 0)
				};
				feedbackPanel.Controls.Add(commentLabel);

				feedbackPanels[i] = feedbackPanel;
			}

			feedbackFlowPanel.SuspendLayout();
			feedbackFlowPanel.Controls.Clear();
			feedbackFlowPanel.Controls.AddRange(feedbackPanels);
			feedbackFlowPanel.ResumeLayout(true);

			float rating = feedbacks.Count == 0 ? 0 : sum / feedbacks.Count;
			ratingLabel.Text = $@"Оцінка: {rating}/5";

			// Cart
			bool inCart = Cart.CheckItemInCart(userId, currentItem.ItemID);
			if (inCart)
			{
				addToCartButton.Text = "Вже в кошику";
				addToCartButton.Enabled = false;
			}
		}

		private void addToCartButton_Click(object sender, System.EventArgs e)
		{
			Cart.AddItemInCart(userId, currentItem.ItemID);
			UpdateForm();
		}

		private void reviewButton_Click(object sender, System.EventArgs e)
		{
			ReviewForm review = new ReviewForm(userId, currentItem.ItemID);
			review.ShowDialog();

			UpdateForm();
		}
	}
}
