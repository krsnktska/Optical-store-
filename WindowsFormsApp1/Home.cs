﻿using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Home : Form
	{
		private int userId;
		public Home(int userId)
		{
			InitializeComponent();
			this.userId = userId;
			StartPosition = FormStartPosition.CenterScreen;
			WindowState = FormWindowState.Maximized;
		}

		// TODO: для кожної форми передавати айді користувача
		private void itemsPictureBox_Click(object sender, System.EventArgs e)
		{
			Items itemsForm = new Items(userId);
			itemsForm.Show();
		}

		private void userPictureBox_Click(object sender, System.EventArgs e)
		{
			Account accountForm = new Account(userId);
			accountForm.Show();
		}

		private void cartPictureBox_Click(object sender, System.EventArgs e)
		{
			CartForm cartForm = new CartForm(userId);
			cartForm.Show();
		}

		private void historyPictureBox_Click(object sender, System.EventArgs e)
		{
			OrdersForm ordersForm = new OrdersForm(userId);
			ordersForm.Show();
		}

		private void Home_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
