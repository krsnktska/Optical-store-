namespace WindowsFormsApp1
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.itemsPictureBox = new System.Windows.Forms.PictureBox();
			this.userPictureBox = new System.Windows.Forms.PictureBox();
			this.cartPictureBox = new System.Windows.Forms.PictureBox();
			this.historyPictureBox = new System.Windows.Forms.PictureBox();
			this.itemsLabel = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.cartLabel = new System.Windows.Forms.Label();
			this.historyLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.itemsPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cartPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.welcomeLabel.Location = new System.Drawing.Point(492, 122);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(563, 40);
			this.welcomeLabel.TabIndex = 0;
			this.welcomeLabel.Text = "Вітаємо в онлайн-оптиці Opti+!";
			// 
			// itemsPictureBox
			// 
			this.itemsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("itemsPictureBox.Image")));
			this.itemsPictureBox.Location = new System.Drawing.Point(422, 279);
			this.itemsPictureBox.Name = "itemsPictureBox";
			this.itemsPictureBox.Size = new System.Drawing.Size(70, 70);
			this.itemsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.itemsPictureBox.TabIndex = 1;
			this.itemsPictureBox.TabStop = false;
			this.itemsPictureBox.Click += new System.EventHandler(this.itemsPictureBox_Click);
			// 
			// userPictureBox
			// 
			this.userPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.account_circle_70dp_000000_FILL0_wght400_GRAD0_opsz48;
			this.userPictureBox.Location = new System.Drawing.Point(640, 279);
			this.userPictureBox.Name = "userPictureBox";
			this.userPictureBox.Size = new System.Drawing.Size(70, 70);
			this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userPictureBox.TabIndex = 2;
			this.userPictureBox.TabStop = false;
			this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
			// 
			// cartPictureBox
			// 
			this.cartPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cartPictureBox.Image")));
			this.cartPictureBox.Location = new System.Drawing.Point(860, 279);
			this.cartPictureBox.Name = "cartPictureBox";
			this.cartPictureBox.Size = new System.Drawing.Size(70, 70);
			this.cartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.cartPictureBox.TabIndex = 3;
			this.cartPictureBox.TabStop = false;
			this.cartPictureBox.Click += new System.EventHandler(this.cartPictureBox_Click);
			// 
			// historyPictureBox
			// 
			this.historyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("historyPictureBox.Image")));
			this.historyPictureBox.Location = new System.Drawing.Point(1072, 279);
			this.historyPictureBox.Name = "historyPictureBox";
			this.historyPictureBox.Size = new System.Drawing.Size(70, 70);
			this.historyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.historyPictureBox.TabIndex = 4;
			this.historyPictureBox.TabStop = false;
			this.historyPictureBox.Click += new System.EventHandler(this.historyPictureBox_Click);
			// 
			// itemsLabel
			// 
			this.itemsLabel.AutoSize = true;
			this.itemsLabel.Location = new System.Drawing.Point(435, 352);
			this.itemsLabel.Name = "itemsLabel";
			this.itemsLabel.Size = new System.Drawing.Size(44, 13);
			this.itemsLabel.TabIndex = 5;
			this.itemsLabel.Text = "Товари";
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(655, 352);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(42, 13);
			this.userLabel.TabIndex = 6;
			this.userLabel.Text = "Акаунт";
			// 
			// cartLabel
			// 
			this.cartLabel.AutoSize = true;
			this.cartLabel.Location = new System.Drawing.Point(876, 352);
			this.cartLabel.Name = "cartLabel";
			this.cartLabel.Size = new System.Drawing.Size(40, 13);
			this.cartLabel.TabIndex = 7;
			this.cartLabel.Text = "Кошик";
			// 
			// historyLabel
			// 
			this.historyLabel.AutoSize = true;
			this.historyLabel.Location = new System.Drawing.Point(1057, 352);
			this.historyLabel.Name = "historyLabel";
			this.historyLabel.Size = new System.Drawing.Size(100, 13);
			this.historyLabel.TabIndex = 8;
			this.historyLabel.Text = "Історія замовлень";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1488, 646);
			this.Controls.Add(this.historyLabel);
			this.Controls.Add(this.cartLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.itemsLabel);
			this.Controls.Add(this.historyPictureBox);
			this.Controls.Add(this.cartPictureBox);
			this.Controls.Add(this.userPictureBox);
			this.Controls.Add(this.itemsPictureBox);
			this.Controls.Add(this.welcomeLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.Text = "Головна";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.itemsPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cartPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.PictureBox itemsPictureBox;
		private System.Windows.Forms.PictureBox userPictureBox;
		private System.Windows.Forms.PictureBox cartPictureBox;
		private System.Windows.Forms.PictureBox historyPictureBox;
		private System.Windows.Forms.Label itemsLabel;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Label cartLabel;
		private System.Windows.Forms.Label historyLabel;
	}
}