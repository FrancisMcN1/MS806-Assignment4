namespace MyBagelShop
{
    partial class MyBagelShopSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShopSummary));
            this.NumBagelsSoldLabel = new System.Windows.Forms.Label();
            this.ValueofSalesLabel = new System.Windows.Forms.Label();
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.AvgValueTransactionLabel = new System.Windows.Forms.Label();
            this.CloseSummaryButton = new System.Windows.Forms.Button();
            this.CloseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NumBaglesTxtBox = new System.Windows.Forms.TextBox();
            this.TotalValueSalesTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTransactionTxtBox = new System.Windows.Forms.TextBox();
            this.AvgValueTransactionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumBagelsSoldLabel
            // 
            this.NumBagelsSoldLabel.AutoSize = true;
            this.NumBagelsSoldLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NumBagelsSoldLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumBagelsSoldLabel.Location = new System.Drawing.Point(90, 66);
            this.NumBagelsSoldLabel.Name = "NumBagelsSoldLabel";
            this.NumBagelsSoldLabel.Size = new System.Drawing.Size(257, 25);
            this.NumBagelsSoldLabel.TabIndex = 0;
            this.NumBagelsSoldLabel.Text = "Total Number of Bagels sold:";
            this.NumBagelsSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueofSalesLabel
            // 
            this.ValueofSalesLabel.AutoSize = true;
            this.ValueofSalesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ValueofSalesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueofSalesLabel.Location = new System.Drawing.Point(90, 141);
            this.ValueofSalesLabel.Name = "ValueofSalesLabel";
            this.ValueofSalesLabel.Size = new System.Drawing.Size(179, 25);
            this.ValueofSalesLabel.TabIndex = 0;
            this.ValueofSalesLabel.Text = "Total value of sales:";
            this.ValueofSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.AutoSize = true;
            this.TotalTransactionsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TotalTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(90, 217);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(168, 25);
            this.TotalTransactionsLabel.TabIndex = 0;
            this.TotalTransactionsLabel.Text = "Total transactions:";
            this.TotalTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgValueTransactionLabel
            // 
            this.AvgValueTransactionLabel.AutoSize = true;
            this.AvgValueTransactionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AvgValueTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvgValueTransactionLabel.Location = new System.Drawing.Point(90, 296);
            this.AvgValueTransactionLabel.Name = "AvgValueTransactionLabel";
            this.AvgValueTransactionLabel.Size = new System.Drawing.Size(278, 25);
            this.AvgValueTransactionLabel.TabIndex = 0;
            this.AvgValueTransactionLabel.Text = "Average value of a transaction:";
            this.AvgValueTransactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseSummaryButton
            // 
            this.CloseSummaryButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseSummaryButton.Location = new System.Drawing.Point(232, 377);
            this.CloseSummaryButton.Name = "CloseSummaryButton";
            this.CloseSummaryButton.Size = new System.Drawing.Size(112, 34);
            this.CloseSummaryButton.TabIndex = 1;
            this.CloseSummaryButton.Text = "&Close";
            this.CloseToolTip.SetToolTip(this.CloseSummaryButton, "Press to close form.");
            this.CloseSummaryButton.UseVisualStyleBackColor = false;
            this.CloseSummaryButton.Click += new System.EventHandler(this.CloseSummaryButton_Click);
            // 
            // CloseToolTip
            // 
            this.CloseToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CloseToolTip.ToolTipTitle = "Information";
            // 
            // NumBaglesTxtBox
            // 
            this.NumBaglesTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumBaglesTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumBaglesTxtBox.Location = new System.Drawing.Point(390, 60);
            this.NumBaglesTxtBox.Name = "NumBaglesTxtBox";
            this.NumBaglesTxtBox.Size = new System.Drawing.Size(73, 31);
            this.NumBaglesTxtBox.TabIndex = 2;
            this.NumBaglesTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalValueSalesTxtBox
            // 
            this.TotalValueSalesTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalValueSalesTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalValueSalesTxtBox.Location = new System.Drawing.Point(390, 135);
            this.TotalValueSalesTxtBox.Name = "TotalValueSalesTxtBox";
            this.TotalValueSalesTxtBox.Size = new System.Drawing.Size(73, 31);
            this.TotalValueSalesTxtBox.TabIndex = 2;
            this.TotalValueSalesTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTransactionTxtBox
            // 
            this.TotalTransactionTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalTransactionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTransactionTxtBox.Location = new System.Drawing.Point(390, 211);
            this.TotalTransactionTxtBox.Name = "TotalTransactionTxtBox";
            this.TotalTransactionTxtBox.Size = new System.Drawing.Size(73, 31);
            this.TotalTransactionTxtBox.TabIndex = 2;
            this.TotalTransactionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AvgValueTransactionTxtBox
            // 
            this.AvgValueTransactionTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvgValueTransactionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgValueTransactionTxtBox.Location = new System.Drawing.Point(390, 290);
            this.AvgValueTransactionTxtBox.Name = "AvgValueTransactionTxtBox";
            this.AvgValueTransactionTxtBox.Size = new System.Drawing.Size(73, 31);
            this.AvgValueTransactionTxtBox.TabIndex = 2;
            this.AvgValueTransactionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyBagelShopSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.AvgValueTransactionTxtBox);
            this.Controls.Add(this.TotalTransactionTxtBox);
            this.Controls.Add(this.TotalValueSalesTxtBox);
            this.Controls.Add(this.NumBaglesTxtBox);
            this.Controls.Add(this.CloseSummaryButton);
            this.Controls.Add(this.AvgValueTransactionLabel);
            this.Controls.Add(this.TotalTransactionsLabel);
            this.Controls.Add(this.ValueofSalesLabel);
            this.Controls.Add(this.NumBagelsSoldLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBagelShopSummary";
            this.Text = "MyBagelShop Summary";
            this.Load += new System.EventHandler(this.MyBagelShopSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NumBagelsSoldLabel;
        private Label ValueofSalesLabel;
        private Label TotalTransactionsLabel;
        private Label AvgValueTransactionLabel;
        private Button CloseSummaryButton;
        private ToolTip CloseToolTip;
        private TextBox NumBaglesTxtBox;
        private TextBox TotalValueSalesTxtBox;
        private TextBox TotalTransactionTxtBox;
        private TextBox AvgValueTransactionTxtBox;
    }
}