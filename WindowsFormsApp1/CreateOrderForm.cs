using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class CreateOrderForm : Form
	{
		int UserID;

		public CreateOrderForm(int userId)
		{
			UserID = userId;
			InitializeComponent();
		}

		private void CreateOrderForm_Load(object sender, System.EventArgs e)
		{
			UpdateForm();
		}

		private void UpdateForm()
		{
			List<Address> addresses = Address.GetAddressesForUser(UserID);

			addressesComboBox.DataSource = new BindingSource { DataSource = addresses }.DataSource;
			addressesComboBox.DropDownWidth = (int)GetLongestDate(addresses).Width;
		}

		private SizeF GetLongestDate(List<Address> addresses)
		{
			Graphics g = CreateGraphics();
			SizeF longest = new Size();
			SizeF current;

			foreach (var address in addresses)
			{
				current = g.MeasureString(address.ToString(), addressesComboBox.Font);
				if (current.Width > longest.Width)
				{
					longest = current;
				}
			}

			return longest;
		}

		private void confirmOrderButton_Click(object sender, System.EventArgs e)
		{
			string comment = commentTextBox.Text;

			if (addressesComboBox.SelectedItem != null)
			{
				Address address = (Address)addressesComboBox.SelectedItem;
				Order.CreateOrder(UserID, address.AddressID, comment);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Будь-ласка оберіть адресу!", "Будь-ласка оберіть адресу!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void addAddressButton_Click(object sender, System.EventArgs e)
		{
			Address address = new Address { UserID = this.UserID };

			AddressForm addressForm = new AddressForm(address);
			if (addressForm.ShowDialog() == DialogResult.OK)
			{
				UpdateForm();
			}
		}
	}
}
