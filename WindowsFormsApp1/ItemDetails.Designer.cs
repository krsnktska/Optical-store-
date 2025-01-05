namespace WindowsFormsApp1
{
	partial class ItemDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetails));
			this.itemCost = new System.Windows.Forms.Label();
			this.itemCountOf = new System.Windows.Forms.Label();
			this.itemProducer = new System.Windows.Forms.Label();
			this.itemDescription = new System.Windows.Forms.Label();
			this.addToCartButton = new System.Windows.Forms.Button();
			this.itemName = new System.Windows.Forms.Label();
			this.characteristicsLabel = new System.Windows.Forms.Label();
			this.propertiesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.feedbackFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.feedbackLabel = new System.Windows.Forms.Label();
			this.ratingLabel = new System.Windows.Forms.Label();
			this.reviewButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// itemCost
			// 
			this.itemCost.AutoSize = true;
			this.itemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemCost.ForeColor = System.Drawing.Color.Gray;
			this.itemCost.Location = new System.Drawing.Point(472, 87);
			this.itemCost.Name = "itemCost";
			this.itemCost.Size = new System.Drawing.Size(51, 20);
			this.itemCost.TabIndex = 1;
			this.itemCost.Text = "Ціна:";
			// 
			// itemCountOf
			// 
			this.itemCountOf.AutoSize = true;
			this.itemCountOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemCountOf.ForeColor = System.Drawing.Color.DarkRed;
			this.itemCountOf.Location = new System.Drawing.Point(472, 113);
			this.itemCountOf.Name = "itemCountOf";
			this.itemCountOf.Size = new System.Drawing.Size(126, 20);
			this.itemCountOf.TabIndex = 2;
			this.itemCountOf.Text = "Залишилось: ";
			// 
			// itemProducer
			// 
			this.itemProducer.AutoSize = true;
			this.itemProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemProducer.ForeColor = System.Drawing.Color.Gray;
			this.itemProducer.Location = new System.Drawing.Point(37, 89);
			this.itemProducer.Name = "itemProducer";
			this.itemProducer.Size = new System.Drawing.Size(90, 20);
			this.itemProducer.TabIndex = 3;
			this.itemProducer.Text = "Виробник";
			// 
			// itemDescription
			// 
			this.itemDescription.AutoEllipsis = true;
			this.itemDescription.AutoSize = true;
			this.itemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemDescription.ForeColor = System.Drawing.Color.Black;
			this.itemDescription.Location = new System.Drawing.Point(39, 117);
			this.itemDescription.MaximumSize = new System.Drawing.Size(427, 64);
			this.itemDescription.Name = "itemDescription";
			this.itemDescription.Size = new System.Drawing.Size(46, 16);
			this.itemDescription.TabIndex = 4;
			this.itemDescription.Text = "Опис: ";
			// 
			// addToCartButton
			// 
			this.addToCartButton.Location = new System.Drawing.Point(475, 143);
			this.addToCartButton.Name = "addToCartButton";
			this.addToCartButton.Size = new System.Drawing.Size(117, 42);
			this.addToCartButton.TabIndex = 5;
			this.addToCartButton.Text = "Додати до кошика";
			this.addToCartButton.UseVisualStyleBackColor = true;
			this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
			// 
			// itemName
			// 
			this.itemName.AutoSize = true;
			this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.itemName.Location = new System.Drawing.Point(37, 35);
			this.itemName.MaximumSize = new System.Drawing.Size(685, 52);
			this.itemName.Name = "itemName";
			this.itemName.Size = new System.Drawing.Size(75, 26);
			this.itemName.TabIndex = 0;
			this.itemName.Text = "Назва";
			// 
			// characteristicsLabel
			// 
			this.characteristicsLabel.AutoSize = true;
			this.characteristicsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.characteristicsLabel.Location = new System.Drawing.Point(38, 211);
			this.characteristicsLabel.Name = "characteristicsLabel";
			this.characteristicsLabel.Size = new System.Drawing.Size(158, 20);
			this.characteristicsLabel.TabIndex = 6;
			this.characteristicsLabel.Text = "Характеристики: ";
			// 
			// propertiesFlowPanel
			// 
			this.propertiesFlowPanel.AutoScroll = true;
			this.propertiesFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.propertiesFlowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.propertiesFlowPanel.Location = new System.Drawing.Point(40, 234);
			this.propertiesFlowPanel.Name = "propertiesFlowPanel";
			this.propertiesFlowPanel.Size = new System.Drawing.Size(334, 208);
			this.propertiesFlowPanel.TabIndex = 7;
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 100;
			// 
			// feedbackFlowPanel
			// 
			this.feedbackFlowPanel.AutoScroll = true;
			this.feedbackFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.feedbackFlowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.feedbackFlowPanel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.feedbackFlowPanel.Location = new System.Drawing.Point(400, 234);
			this.feedbackFlowPanel.Name = "feedbackFlowPanel";
			this.feedbackFlowPanel.Size = new System.Drawing.Size(334, 185);
			this.feedbackFlowPanel.TabIndex = 11;
			// 
			// feedbackLabel
			// 
			this.feedbackLabel.AutoSize = true;
			this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.feedbackLabel.Location = new System.Drawing.Point(396, 211);
			this.feedbackLabel.Name = "feedbackLabel";
			this.feedbackLabel.Size = new System.Drawing.Size(72, 20);
			this.feedbackLabel.TabIndex = 10;
			this.feedbackLabel.Text = "Відгуки";
			// 
			// ratingLabel
			// 
			this.ratingLabel.AutoSize = true;
			this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ratingLabel.ForeColor = System.Drawing.Color.DarkGreen;
			this.ratingLabel.Location = new System.Drawing.Point(397, 422);
			this.ratingLabel.Name = "ratingLabel";
			this.ratingLabel.Size = new System.Drawing.Size(74, 16);
			this.ratingLabel.TabIndex = 12;
			this.ratingLabel.Text = "Оцінка: x/5";
			// 
			// reviewButton
			// 
			this.reviewButton.Enabled = false;
			this.reviewButton.Location = new System.Drawing.Point(614, 419);
			this.reviewButton.Name = "reviewButton";
			this.reviewButton.Size = new System.Drawing.Size(120, 23);
			this.reviewButton.TabIndex = 13;
			this.reviewButton.Text = "Залишити відгук";
			this.reviewButton.UseVisualStyleBackColor = true;
			this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
			// 
			// ItemDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 454);
			this.Controls.Add(this.reviewButton);
			this.Controls.Add(this.ratingLabel);
			this.Controls.Add(this.feedbackFlowPanel);
			this.Controls.Add(this.feedbackLabel);
			this.Controls.Add(this.propertiesFlowPanel);
			this.Controls.Add(this.characteristicsLabel);
			this.Controls.Add(this.addToCartButton);
			this.Controls.Add(this.itemDescription);
			this.Controls.Add(this.itemProducer);
			this.Controls.Add(this.itemCountOf);
			this.Controls.Add(this.itemCost);
			this.Controls.Add(this.itemName);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ItemDetails";
			this.Text = "Деталі товару";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label itemCost;
		private System.Windows.Forms.Label itemCountOf;
		private System.Windows.Forms.Label itemProducer;
		private System.Windows.Forms.Label itemDescription;
		private System.Windows.Forms.Button addToCartButton;
		private System.Windows.Forms.Label characteristicsLabel;
		private System.Windows.Forms.FlowLayoutPanel propertiesFlowPanel;
		private System.Windows.Forms.Label itemName;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.FlowLayoutPanel feedbackFlowPanel;
		private System.Windows.Forms.Label feedbackLabel;
		private System.Windows.Forms.Label ratingLabel;
		private System.Windows.Forms.Button reviewButton;
	}
}