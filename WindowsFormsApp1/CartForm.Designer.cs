namespace WindowsFormsApp1
{
	partial class CartForm
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
			this.totalPriceLabel = new System.Windows.Forms.Label();
			this.totalQuantityLabel = new System.Windows.Forms.Label();
			this.cartLabel = new System.Windows.Forms.Label();
			this.orderButton = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// itemsFlowLayoutPanel
			// 
			this.itemsFlowLayoutPanel.AutoScroll = true;
			this.itemsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemsFlowLayoutPanel.Location = new System.Drawing.Point(12, 32);
			this.itemsFlowLayoutPanel.Name = "itemsFlowLayoutPanel";
			this.itemsFlowLayoutPanel.Size = new System.Drawing.Size(395, 374);
			this.itemsFlowLayoutPanel.TabIndex = 0;
			// 
			// totalPriceLabel
			// 
			this.totalPriceLabel.AutoSize = true;
			this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.totalPriceLabel.ForeColor = System.Drawing.Color.DarkGreen;
			this.totalPriceLabel.Location = new System.Drawing.Point(9, 409);
			this.totalPriceLabel.Name = "totalPriceLabel";
			this.totalPriceLabel.Size = new System.Drawing.Size(79, 16);
			this.totalPriceLabel.TabIndex = 1;
			this.totalPriceLabel.Text = "TotalPrice";
			// 
			// totalQuantityLabel
			// 
			this.totalQuantityLabel.AutoSize = true;
			this.totalQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.totalQuantityLabel.ForeColor = System.Drawing.Color.Gray;
			this.totalQuantityLabel.Location = new System.Drawing.Point(9, 425);
			this.totalQuantityLabel.Name = "totalQuantityLabel";
			this.totalQuantityLabel.Size = new System.Drawing.Size(86, 16);
			this.totalQuantityLabel.TabIndex = 2;
			this.totalQuantityLabel.Text = "TotalQuantity";
			// 
			// cartLabel
			// 
			this.cartLabel.AutoSize = true;
			this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cartLabel.Location = new System.Drawing.Point(8, 9);
			this.cartLabel.Name = "cartLabel";
			this.cartLabel.Size = new System.Drawing.Size(91, 20);
			this.cartLabel.TabIndex = 3;
			this.cartLabel.Text = "В кошику:";
			// 
			// orderButton
			// 
			this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.orderButton.Location = new System.Drawing.Point(176, 412);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(231, 29);
			this.orderButton.TabIndex = 4;
			this.orderButton.Text = "Оформити замовлення";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 100;
			this.toolTip.ReshowDelay = 100;
			// 
			// CartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 450);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.cartLabel);
			this.Controls.Add(this.totalQuantityLabel);
			this.Controls.Add(this.totalPriceLabel);
			this.Controls.Add(this.itemsFlowLayoutPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CartForm";
			this.Text = "Кошик";
			this.Load += new System.EventHandler(this.CartForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel itemsFlowLayoutPanel;
		private System.Windows.Forms.Label totalPriceLabel;
		private System.Windows.Forms.Label totalQuantityLabel;
		private System.Windows.Forms.Label cartLabel;
		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.ToolTip toolTip;
	}
}