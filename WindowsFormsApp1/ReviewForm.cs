using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ReviewForm : Form
	{
		int UserID;
		int ItemID;

		public ReviewForm(int userId, int itemId)
		{
			UserID = userId;
			ItemID = itemId;

			InitializeComponent();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			string review = reviewTextBox.Text;
			int rating = ratingSlider.Value;

			Feedback.AddFeedbackForItemByUser(UserID, ItemID, review, rating);
			this.Close();
		}
	}
}
