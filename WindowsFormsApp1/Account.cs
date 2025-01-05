using System;
using System.Collections.Generic;
using System.Drawing;
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
			ToggleEditing(false);
		}

		private void LoadUserData(int userId)
		{
			User currentUser = User.GetUserData(userId);

			if (currentUser == null)
			{
				MessageBox.Show("Користувача не знайдено.");
				this.Close();
			}

			surnameTextBox.Text = currentUser.Surname ?? "";
			nameTextBox.Text = currentUser.Name ?? "";
			patronymicTextBox.Text = currentUser.Patronymic ?? "";
			phoneNumberTextBox.Text = currentUser.PhoneNumber ?? "";
			emailTextBox.Text = currentUser.Email ?? "";
			sexComboBox.Text = currentUser.Sex ?? "";

			List<Address> addresses = Address.GetAddressesForUser(userId);
			Control[] addressPanels = new Control[addresses.Count];

			int width = addressesFlowLayoutPanel.Width - 40;

			for (int i = 0; i < addresses.Count; i++)
			{
				Address address = addresses[i];

				FlowLayoutPanel addressPanel = new FlowLayoutPanel
				{
					MaximumSize = new Size(width, 0),
					MinimumSize = new Size(width, 25),
					AutoSize = true,
					Margin = new Padding(10, 5, 10, 5),
					Padding = new Padding(2),
					BorderStyle = BorderStyle.FixedSingle
				};
				if (address.IsPreferred) { addressPanel.BackColor = Color.LightGreen; }

				Label addressLabel = new Label
				{
					Text = address.ToString(),
					AutoEllipsis = true,
					Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
					ForeColor = Color.Black,
					AutoSize = true,
					MaximumSize = new Size(width - 40, 0)
				};
				addressPanel.Controls.Add(addressLabel);

				if (!address.IsPreferred)
				{
					Button setPreferredButton = new Button()
					{
						Size = new Size(width / 3 - 10, 24),
						BackgroundImage = Properties.Resources.check,
						BackgroundImageLayout = ImageLayout.Zoom
					};
					setPreferredButton.Click += (object sender, EventArgs e) =>
					{
						Address.SetAddressPreferred(address.AddressID, address.UserID);
						this.LoadUserData(this.userId);
					};
					addressPanel.Controls.Add(setPreferredButton);

					Button editButton = new Button()
					{
						Size = new Size(width / 3 - 10, 24),
						BackgroundImage = Properties.Resources.edit,
						BackgroundImageLayout = ImageLayout.Zoom
					};
					editButton.Click += (object sender, EventArgs e) =>
					{
						AddressForm addressForm = new AddressForm(address);
						if (addressForm.ShowDialog() == DialogResult.OK)
						{
							this.LoadUserData(this.userId);
						}
					};
					addressPanel.Controls.Add(editButton);

					Button deleteButton = new Button()
					{
						Size = new Size(width / 3 - 10, 24),
						BackgroundImage = Properties.Resources.delete,
						BackgroundImageLayout = ImageLayout.Zoom
					};
					deleteButton.Click += (object sender, EventArgs e) =>
					{
						if (MessageBox.Show("Ви впевнені що хочете видалити цю адресу?", "Підтвердження видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
						{
							address.Delete();
							this.LoadUserData(this.userId);
						}
					};
					addressPanel.Controls.Add(deleteButton);
				}
				else
				{
					Button editPreferred = new Button()
					{
						Size = new Size(width - 10, 24),
						BackgroundImage = Properties.Resources.edit,
						BackgroundImageLayout = ImageLayout.Zoom
					};
					editPreferred.Click += (object sender, EventArgs e) =>
					{
						AddressForm addressForm = new AddressForm(address);
						if (addressForm.ShowDialog() == DialogResult.OK)
						{
							this.LoadUserData(this.userId);
						}
					};
					addressPanel.Controls.Add(editPreferred);
				}

				addressPanels[i] = addressPanel;
			}

			addressesFlowLayoutPanel.SuspendLayout();
			addressesFlowLayoutPanel.Controls.Clear();
			addressesFlowLayoutPanel.Controls.AddRange(addressPanels);
			addressesFlowLayoutPanel.ResumeLayout(true);
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			ToggleEditing(true);
			editButton.Visible = false;
			saveButton.Visible = true;
			cancelButton.Visible = true;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			ToggleEditing(false);
			saveButton.Visible = false;
			cancelButton.Visible = false;
			editButton.Visible = true;
			LoadUserData(userId);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			ToggleEditing(false);
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

		private void ToggleEditing(bool enable)
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

		private void addAddressButton_Click(object sender, EventArgs e)
		{
			Address address = new Address { UserID = this.userId };

			AddressForm addressForm = new AddressForm(address);
			if (addressForm.ShowDialog() == DialogResult.OK)
			{
				this.LoadUserData(this.userId);
			}
		}
	}
}
