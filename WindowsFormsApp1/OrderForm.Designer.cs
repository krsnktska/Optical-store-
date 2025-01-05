namespace WindowsFormsApp1
{
	partial class OrderForm
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
			this.components = new System.ComponentModel.Container();
			this.itemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.orderNumberLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.priceLabel = new System.Windows.Forms.Label();
			this.countLabel = new System.Windows.Forms.Label();
			this.commentLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// itemsFlowLayoutPanel
			// 
			this.itemsFlowLayoutPanel.AutoScroll = true;
			this.itemsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemsFlowLayoutPanel.Location = new System.Drawing.Point(13, 32);
			this.itemsFlowLayoutPanel.Name = "itemsFlowLayoutPanel";
			this.itemsFlowLayoutPanel.Size = new System.Drawing.Size(270, 244);
			this.itemsFlowLayoutPanel.TabIndex = 0;
			// 
			// orderNumberLabel
			// 
			this.orderNumberLabel.AutoSize = true;
			this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.orderNumberLabel.Location = new System.Drawing.Point(9, 9);
			this.orderNumberLabel.Name = "orderNumberLabel";
			this.orderNumberLabel.Size = new System.Drawing.Size(135, 20);
			this.orderNumberLabel.TabIndex = 1;
			this.orderNumberLabel.Text = "Замовлення №";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(10, 355);
			this.addressLabel.MaximumSize = new System.Drawing.Size(260, 0);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(260, 26);
			this.addressLabel.TabIndex = 2;
			this.addressLabel.Text = "АдресаАдресаАдресаАдресаАдресаАдресаАдреса";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusLabel.ForeColor = System.Drawing.Color.DarkGreen;
			this.statusLabel.Location = new System.Drawing.Point(205, 13);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(59, 16);
			this.statusLabel.TabIndex = 3;
			this.statusLabel.Text = "Статус";
			// 
			// priceLabel
			// 
			this.priceLabel.AutoSize = true;
			this.priceLabel.ForeColor = System.Drawing.Color.DarkGreen;
			this.priceLabel.Location = new System.Drawing.Point(10, 284);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(29, 13);
			this.priceLabel.TabIndex = 4;
			this.priceLabel.Text = "Ціна";
			// 
			// countLabel
			// 
			this.countLabel.AutoSize = true;
			this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countLabel.ForeColor = System.Drawing.Color.Gray;
			this.countLabel.Location = new System.Drawing.Point(10, 304);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(53, 13);
			this.countLabel.TabIndex = 5;
			this.countLabel.Text = "Кількість";
			// 
			// commentLabel
			// 
			this.commentLabel.AutoSize = true;
			this.commentLabel.Location = new System.Drawing.Point(12, 388);
			this.commentLabel.MaximumSize = new System.Drawing.Size(260, 0);
			this.commentLabel.Name = "commentLabel";
			this.commentLabel.Size = new System.Drawing.Size(57, 13);
			this.commentLabel.TabIndex = 7;
			this.commentLabel.Text = "Коментар";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(10, 326);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(99, 13);
			this.dateLabel.TabIndex = 8;
			this.dateLabel.Text = "Дата формування";
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(208, 279);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Скасувати";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 100;
			this.toolTip.ReshowDelay = 100;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 462);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.commentLabel);
			this.Controls.Add(this.countLabel);
			this.Controls.Add(this.priceLabel);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.orderNumberLabel);
			this.Controls.Add(this.itemsFlowLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "OrderForm";
			this.Text = "Замовлення";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel itemsFlowLayoutPanel;
		private System.Windows.Forms.Label orderNumberLabel;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.Label commentLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ToolTip toolTip;
	}
}