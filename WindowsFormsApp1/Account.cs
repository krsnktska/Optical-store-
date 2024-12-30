using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Account : Form
	{
		private int userId;
		public Account(int userId)
		{
			InitializeComponent();
			this.userId = userId;
		}
		private void Account_Load(object sender, EventArgs e)
		{
			LoadUserData(userId);
			EnableEditing(false);
		}

		private void LoadUserData(int userId)
		{
			User currentUser = User.GetUserData(userId);

			if (currentUser != null)
			{
				surnameTextBox.Text = currentUser.Surname ?? "";
				nameTextBox.Text = currentUser.Name ?? "";
				patronymicTextBox.Text = currentUser.Patronymic ?? "";
				phoneNumberTextBox.Text = currentUser.PhoneNumber ?? "";
				emailTextBox.Text = currentUser.Email ?? "";
				sexComboBox.Text = currentUser.Sex ?? "";
			}
			else
			{
				MessageBox.Show("Користувача не знайдено.");
			}
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			EnableEditing(true);
			editButton.Visible = false;
			saveButton.Visible = true;
			cancelButton.Visible = true;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			EnableEditing(false);
			saveButton.Visible = false;
			cancelButton.Visible = false;
			editButton.Visible = true;
			LoadUserData(userId);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			EnableEditing(false);
			saveButton.Visible = false;
			cancelButton.Visible = false;
			editButton.Visible = true;

			bool success = User.UpdateUserData(userId, surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, sexComboBox.Text);
			if (success)
			{
				MessageBox.Show("Дані оновлено успішно.");
				LoadUserData(userId);
				this.Close();
			}
			else
			{
				MessageBox.Show("Не вдалося оновити дані.");
			}
		}

		private void EnableEditing(bool enable)
		{
			surnameTextBox.Enabled = enable;
			nameTextBox.Enabled = enable;
			patronymicTextBox.Enabled = enable;
			phoneNumberTextBox.Enabled = enable;
			emailTextBox.Enabled = enable;
			sexComboBox.Enabled = enable;
		}

		private void homePicture_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
