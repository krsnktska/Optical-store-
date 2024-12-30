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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetails));
			this.itemCost = new System.Windows.Forms.Label();
			this.itemCountOf = new System.Windows.Forms.Label();
			this.itemProducer = new System.Windows.Forms.Label();
			this.itemDescription = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.itemName = new System.Windows.Forms.Label();
			this.characteristicsLabel = new System.Windows.Forms.Label();
			this.propertiesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
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
			this.itemDescription.AutoSize = true;
			this.itemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemDescription.ForeColor = System.Drawing.Color.Black;
			this.itemDescription.Location = new System.Drawing.Point(39, 119);
			this.itemDescription.Name = "itemDescription";
			this.itemDescription.Size = new System.Drawing.Size(46, 16);
			this.itemDescription.TabIndex = 4;
			this.itemDescription.Text = "Опис: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(475, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 42);
			this.button1.TabIndex = 5;
			this.button1.Text = "До кошика";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// itemName
			// 
			this.itemName.AutoSize = true;
			this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.itemName.Location = new System.Drawing.Point(37, 35);
			this.itemName.Name = "itemName";
			this.itemName.Size = new System.Drawing.Size(0, 26);
			this.itemName.TabIndex = 0;
			// 
			// characteristicsLabel
			// 
			this.characteristicsLabel.AutoSize = true;
			this.characteristicsLabel.Location = new System.Drawing.Point(41, 218);
			this.characteristicsLabel.Name = "characteristicsLabel";
			this.characteristicsLabel.Size = new System.Drawing.Size(96, 13);
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
			this.propertiesFlowPanel.Size = new System.Drawing.Size(248, 156);
			this.propertiesFlowPanel.TabIndex = 7;
			// 
			// ItemDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 454);
			this.Controls.Add(this.propertiesFlowPanel);
			this.Controls.Add(this.characteristicsLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.itemDescription);
			this.Controls.Add(this.itemProducer);
			this.Controls.Add(this.itemCountOf);
			this.Controls.Add(this.itemCost);
			this.Controls.Add(this.itemName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label characteristicsLabel;
		private System.Windows.Forms.FlowLayoutPanel propertiesFlowPanel;
		private System.Windows.Forms.Label itemName;
	}
}