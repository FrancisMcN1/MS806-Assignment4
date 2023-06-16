namespace MyBagelShop
{
    partial class MyBagelShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShop));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.BagelTypeListBox = new System.Windows.Forms.ListBox();
            this.BagelSizeListBox = new System.Windows.Forms.ListBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceOutputTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChooseBagelLabel = new System.Windows.Forms.Label();
            this.ChooseSizeLabel = new System.Windows.Forms.Label();
            this.OrderedItemsListBox = new System.Windows.Forms.ListBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SalesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StockToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.DateSearchButton = new System.Windows.Forms.Button();
            this.IDSearchButton = new System.Windows.Forms.Button();
            this.SearchBoxLabel = new System.Windows.Forms.Label();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchIDRadioButton = new System.Windows.Forms.RadioButton();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.DateTxtBox = new System.Windows.Forms.TextBox();
            this.TransactionsListBox = new System.Windows.Forms.ListBox();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.CompleteOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddToOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BagelListLabel = new System.Windows.Forms.Label();
            this.SizeListLabel = new System.Windows.Forms.Label();
            this.QuantityListLabel = new System.Windows.Forms.Label();
            this.IDNumLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.QuantityListBoxLabel = new System.Windows.Forms.Label();
            this.TypeListLabel = new System.Windows.Forms.Label();
            this.PriceListLabel = new System.Windows.Forms.Label();
            this.TotalListLabel = new System.Windows.Forms.Label();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.ClearSearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(527, 242);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(436, 108);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EnterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterLabel.Location = new System.Drawing.Point(638, 373);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(237, 25);
            this.EnterLabel.TabIndex = 1;
            this.EnterLabel.Text = "Press enter to begin order.";
            this.EnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.Location = new System.Drawing.Point(693, 422);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(112, 34);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "&Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // BagelTypeListBox
            // 
            this.BagelTypeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BagelTypeListBox.FormattingEnabled = true;
            this.BagelTypeListBox.ItemHeight = 25;
            this.BagelTypeListBox.Items.AddRange(new object[] {
            "Plain",
            "Sesame",
            "Classic",
            "Everything",
            "Cheese",
            "Garlic",
            "Chicken",
            "Blueberry",
            "Raisin",
            "Cinnamon",
            "Whole Grain",
            "Chocolate",
            "Egg"});
            this.BagelTypeListBox.Location = new System.Drawing.Point(18, 42);
            this.BagelTypeListBox.Name = "BagelTypeListBox";
            this.BagelTypeListBox.Size = new System.Drawing.Size(211, 327);
            this.BagelTypeListBox.TabIndex = 1;
            this.BagelTypeListBox.Visible = false;
            // 
            // BagelSizeListBox
            // 
            this.BagelSizeListBox.FormattingEnabled = true;
            this.BagelSizeListBox.ItemHeight = 25;
            this.BagelSizeListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Regular ",
            "Large",
            "Extra Large"});
            this.BagelSizeListBox.Location = new System.Drawing.Point(18, 420);
            this.BagelSizeListBox.Name = "BagelSizeListBox";
            this.BagelSizeListBox.Size = new System.Drawing.Size(211, 129);
            this.BagelSizeListBox.TabIndex = 2;
            this.BagelSizeListBox.Visible = false;
          
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderGroupBox.Controls.Add(this.TotalPriceTextBox);
            this.OrderGroupBox.Controls.Add(this.PriceOutputTxtBox);
            this.OrderGroupBox.Controls.Add(this.QuantityTextBox);
            this.OrderGroupBox.Controls.Add(this.AddToOrderButton);
            this.OrderGroupBox.Controls.Add(this.TotalLabel);
            this.OrderGroupBox.Controls.Add(this.QuantityLabel);
            this.OrderGroupBox.Controls.Add(this.PriceLabel);
            this.OrderGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderGroupBox.Location = new System.Drawing.Point(260, 42);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(360, 240);
            this.OrderGroupBox.TabIndex = 4;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order Details";
            this.OrderGroupBox.Visible = false;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceTextBox.Location = new System.Drawing.Point(204, 122);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(74, 31);
            this.TotalPriceTextBox.TabIndex = 4;
            this.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceOutputTxtBox
            // 
            this.PriceOutputTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceOutputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceOutputTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceOutputTxtBox.Location = new System.Drawing.Point(204, 31);
            this.PriceOutputTxtBox.Name = "PriceOutputTxtBox";
            this.PriceOutputTxtBox.Size = new System.Drawing.Size(74, 31);
            this.PriceOutputTxtBox.TabIndex = 4;
            this.PriceOutputTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityTextBox.Location = new System.Drawing.Point(204, 76);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(74, 31);
            this.QuantityTextBox.TabIndex = 4;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddToOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToOrderButton.Location = new System.Drawing.Point(104, 175);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(152, 34);
            this.AddToOrderButton.TabIndex = 6;
            this.AddToOrderButton.Text = "&Add to order";
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            this.AddToOrderButton.Visible = false;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(73, 124);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 25);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(73, 76);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(92, 25);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(73, 31);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(59, 25);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(260, 514);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(132, 40);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "&Clear";
            this.ClearTip.SetToolTip(this.ClearButton, "Press to clear order.");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Visible = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChooseBagelLabel
            // 
            this.ChooseBagelLabel.AutoSize = true;
            this.ChooseBagelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ChooseBagelLabel.Location = new System.Drawing.Point(57, 14);
            this.ChooseBagelLabel.Name = "ChooseBagelLabel";
            this.ChooseBagelLabel.Size = new System.Drawing.Size(127, 25);
            this.ChooseBagelLabel.TabIndex = 5;
            this.ChooseBagelLabel.Text = "Choose Bagel";
            this.ChooseBagelLabel.Visible = false;
            // 
            // ChooseSizeLabel
            // 
            this.ChooseSizeLabel.AutoSize = true;
            this.ChooseSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ChooseSizeLabel.Location = new System.Drawing.Point(71, 392);
            this.ChooseSizeLabel.Name = "ChooseSizeLabel";
            this.ChooseSizeLabel.Size = new System.Drawing.Size(113, 25);
            this.ChooseSizeLabel.TabIndex = 5;
            this.ChooseSizeLabel.Text = "Choose Size";
            this.ChooseSizeLabel.Visible = false;
            // 
            // OrderedItemsListBox
            // 
            this.OrderedItemsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderedItemsListBox.FormattingEnabled = true;
            this.OrderedItemsListBox.ItemHeight = 25;
            this.OrderedItemsListBox.Location = new System.Drawing.Point(260, 345);
            this.OrderedItemsListBox.Name = "OrderedItemsListBox";
            this.OrderedItemsListBox.Size = new System.Drawing.Size(360, 152);
            this.OrderedItemsListBox.TabIndex = 6;
            this.OrderedItemsListBox.Visible = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SalesButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Location = new System.Drawing.Point(672, 41);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(197, 197);
            this.ButtonPanel.TabIndex = 7;
            this.ButtonPanel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(31, 133);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 34);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Press to exit form.");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalesButton.Location = new System.Drawing.Point(31, 80);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(132, 34);
            this.SalesButton.TabIndex = 9;
            this.SalesButton.Text = "&Sales View";
            this.SalesToolTip.SetToolTip(this.SalesButton, "Press to view sales.");
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(31, 27);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(132, 34);
            this.SummaryButton.TabIndex = 8;
            this.SummaryButton.Text = "&Summary";
            this.SummaryToolTip.SetToolTip(this.SummaryButton, "Press for summary view.");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearTip
            // 
            this.ClearTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearTip.ToolTipTitle = "Information";
            // 
            // SummaryToolTip
            // 
            this.SummaryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SummaryToolTip.ToolTipTitle = "Information";
            // 
            // SalesToolTip
            // 
            this.SalesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SalesToolTip.ToolTipTitle = "Information";
            // 
            // StockToolTip
            // 
            this.StockToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StockToolTip.ToolTipTitle = "Information";
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExitToolTip.ToolTipTitle = "Information";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.DateSearchButton);
            this.SearchPanel.Controls.Add(this.IDSearchButton);
            this.SearchPanel.Controls.Add(this.SearchBoxLabel);
            this.SearchPanel.Controls.Add(this.DateRadioButton);
            this.SearchPanel.Controls.Add(this.SearchIDRadioButton);
            this.SearchPanel.Controls.Add(this.IDTxtBox);
            this.SearchPanel.Controls.Add(this.DateTxtBox);
            this.SearchPanel.Location = new System.Drawing.Point(931, 41);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(536, 154);
            this.SearchPanel.TabIndex = 8;
            this.SearchPanel.Visible = false;
            // 
            // DateSearchButton
            // 
            this.DateSearchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DateSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateSearchButton.Location = new System.Drawing.Point(373, 98);
            this.DateSearchButton.Name = "DateSearchButton";
            this.DateSearchButton.Size = new System.Drawing.Size(132, 34);
            this.DateSearchButton.TabIndex = 10;
            this.DateSearchButton.Text = "&Search";
            this.DateSearchButton.UseVisualStyleBackColor = false;
            this.DateSearchButton.Click += new System.EventHandler(this.DateSearchButton_Click);
            // 
            // IDSearchButton
            // 
            this.IDSearchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IDSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDSearchButton.Location = new System.Drawing.Point(373, 47);
            this.IDSearchButton.Name = "IDSearchButton";
            this.IDSearchButton.Size = new System.Drawing.Size(132, 34);
            this.IDSearchButton.TabIndex = 10;
            this.IDSearchButton.Text = "&Search";
            this.SearchToolTip.SetToolTip(this.IDSearchButton, "Press to search transactions.");
            this.IDSearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchBoxLabel
            // 
            this.SearchBoxLabel.AutoSize = true;
            this.SearchBoxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBoxLabel.Location = new System.Drawing.Point(139, 6);
            this.SearchBoxLabel.Name = "SearchBoxLabel";
            this.SearchBoxLabel.Size = new System.Drawing.Size(256, 25);
            this.SearchBoxLabel.TabIndex = 2;
            this.SearchBoxLabel.Text = "Search previous transactions";
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateRadioButton.Location = new System.Drawing.Point(29, 103);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(82, 29);
            this.DateRadioButton.TabIndex = 1;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date:";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            this.DateRadioButton.CheckedChanged += new System.EventHandler(this.DateRadioButton_CheckedChanged);
            // 
            // SearchIDRadioButton
            // 
            this.SearchIDRadioButton.AutoSize = true;
            this.SearchIDRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchIDRadioButton.Location = new System.Drawing.Point(29, 50);
            this.SearchIDRadioButton.Name = "SearchIDRadioButton";
            this.SearchIDRadioButton.Size = new System.Drawing.Size(165, 29);
            this.SearchIDRadioButton.TabIndex = 1;
            this.SearchIDRadioButton.TabStop = true;
            this.SearchIDRadioButton.Text = "Transaction ID:";
            this.SearchIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(195, 50);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(150, 31);
            this.IDTxtBox.TabIndex = 0;
            this.IDTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Location = new System.Drawing.Point(195, 101);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(150, 31);
            this.DateTxtBox.TabIndex = 0;
            this.DateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransactionsListBox
            // 
            this.TransactionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionsListBox.FormattingEnabled = true;
            this.TransactionsListBox.ItemHeight = 25;
            this.TransactionsListBox.Location = new System.Drawing.Point(1039, 217);
            this.TransactionsListBox.Name = "TransactionsListBox";
            this.TransactionsListBox.Size = new System.Drawing.Size(428, 302);
            this.TransactionsListBox.TabIndex = 9;
            this.TransactionsListBox.Visible = false;
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CompleteOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteOrderButton.Location = new System.Drawing.Point(450, 514);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(170, 40);
            this.CompleteOrderButton.TabIndex = 7;
            this.CompleteOrderButton.Text = "&Complete Order";
            this.CompleteOrderToolTip.SetToolTip(this.CompleteOrderButton, "Press to complete order.");
            this.CompleteOrderButton.UseVisualStyleBackColor = false;
            this.CompleteOrderButton.Visible = false;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // CompleteOrderToolTip
            // 
            this.CompleteOrderToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CompleteOrderToolTip.ToolTipTitle = "Information";
            // 
            // AddToOrderToolTip
            // 
            this.AddToOrderToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AddToOrderToolTip.ToolTipTitle = "Press to add to order.";
            // 
            // SearchToolTip
            // 
            this.SearchToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SearchToolTip.ToolTipTitle = "Information";
            // 
            // BagelListLabel
            // 
            this.BagelListLabel.AutoSize = true;
            this.BagelListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BagelListLabel.Location = new System.Drawing.Point(269, 317);
            this.BagelListLabel.Name = "BagelListLabel";
            this.BagelListLabel.Size = new System.Drawing.Size(65, 25);
            this.BagelListLabel.TabIndex = 9;
            this.BagelListLabel.Text = "Bagel ";
            this.BagelListLabel.Visible = false;
            // 
            // SizeListLabel
            // 
            this.SizeListLabel.AutoSize = true;
            this.SizeListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SizeListLabel.Location = new System.Drawing.Point(407, 317);
            this.SizeListLabel.Name = "SizeListLabel";
            this.SizeListLabel.Size = new System.Drawing.Size(46, 25);
            this.SizeListLabel.TabIndex = 9;
            this.SizeListLabel.Text = "Size";
            this.SizeListLabel.Visible = false;
            // 
            // QuantityListLabel
            // 
            this.QuantityListLabel.AutoSize = true;
            this.QuantityListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.QuantityListLabel.Location = new System.Drawing.Point(522, 317);
            this.QuantityListLabel.Name = "QuantityListLabel";
            this.QuantityListLabel.Size = new System.Drawing.Size(87, 25);
            this.QuantityListLabel.TabIndex = 9;
            this.QuantityListLabel.Text = "Quantity";
            this.QuantityListLabel.Visible = false;
            // 
            // IDNumLabel
            // 
            this.IDNumLabel.AutoSize = true;
            this.IDNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDNumLabel.Location = new System.Drawing.Point(931, 239);
            this.IDNumLabel.Name = "IDNumLabel";
            this.IDNumLabel.Size = new System.Drawing.Size(82, 25);
            this.IDNumLabel.TabIndex = 10;
            this.IDNumLabel.Text = "ID Num:";
            this.IDNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IDNumLabel.Visible = false;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateTimeLabel.Location = new System.Drawing.Point(931, 285);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(107, 25);
            this.DateTimeLabel.TabIndex = 10;
            this.DateTimeLabel.Text = "Date/Time:";
            this.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateTimeLabel.Visible = false;
            // 
            // QuantityListBoxLabel
            // 
            this.QuantityListBoxLabel.AutoSize = true;
            this.QuantityListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityListBoxLabel.Location = new System.Drawing.Point(931, 331);
            this.QuantityListBoxLabel.Name = "QuantityListBoxLabel";
            this.QuantityListBoxLabel.Size = new System.Drawing.Size(92, 25);
            this.QuantityListBoxLabel.TabIndex = 10;
            this.QuantityListBoxLabel.Text = "Quantity:";
            this.QuantityListBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuantityListBoxLabel.Visible = false;
            // 
            // TypeListLabel
            // 
            this.TypeListLabel.AutoSize = true;
            this.TypeListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeListLabel.Location = new System.Drawing.Point(931, 377);
            this.TypeListLabel.Name = "TypeListLabel";
            this.TypeListLabel.Size = new System.Drawing.Size(58, 25);
            this.TypeListLabel.TabIndex = 10;
            this.TypeListLabel.Text = "Type:";
            this.TypeListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TypeListLabel.Visible = false;
            // 
            // PriceListLabel
            // 
            this.PriceListLabel.AutoSize = true;
            this.PriceListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceListLabel.Location = new System.Drawing.Point(931, 423);
            this.PriceListLabel.Name = "PriceListLabel";
            this.PriceListLabel.Size = new System.Drawing.Size(59, 25);
            this.PriceListLabel.TabIndex = 10;
            this.PriceListLabel.Text = "Price:";
            this.PriceListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceListLabel.Visible = false;
            // 
            // TotalListLabel
            // 
            this.TotalListLabel.AutoSize = true;
            this.TotalListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalListLabel.Location = new System.Drawing.Point(931, 469);
            this.TotalListLabel.Name = "TotalListLabel";
            this.TotalListLabel.Size = new System.Drawing.Size(59, 25);
            this.TotalListLabel.TabIndex = 10;
            this.TotalListLabel.Text = "Total:";
            this.TotalListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalListLabel.Visible = false;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearSearchButton.Location = new System.Drawing.Point(1169, 537);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(180, 34);
            this.ClearSearchButton.TabIndex = 11;
            this.ClearSearchButton.Text = "&Clear Search";
            this.ClearSearchToolTip.SetToolTip(this.ClearSearchButton, "Press to clear search form.\r\n");
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Visible = false;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // ClearSearchToolTip
            // 
            this.ClearSearchToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearSearchToolTip.ToolTipTitle = "Information";
            // 
            // MyBagelShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1491, 661);
            this.Controls.Add(this.ClearSearchButton);
            this.Controls.Add(this.TotalListLabel);
            this.Controls.Add(this.PriceListLabel);
            this.Controls.Add(this.TypeListLabel);
            this.Controls.Add(this.QuantityListBoxLabel);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.IDNumLabel);
            this.Controls.Add(this.TransactionsListBox);
            this.Controls.Add(this.QuantityListLabel);
            this.Controls.Add(this.SizeListLabel);
            this.Controls.Add(this.BagelListLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.CompleteOrderButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.OrderedItemsListBox);
            this.Controls.Add(this.ChooseSizeLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ChooseBagelLabel);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.BagelSizeListBox);
            this.Controls.Add(this.BagelTypeListBox);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBagelShop";
            this.Text = "MyBagelShop";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoPictureBox;
        private Label EnterLabel;
        private Button EnterButton;
        private ListBox BagelTypeListBox;
        private ListBox BagelSizeListBox;
        private GroupBox OrderGroupBox;
        private Label ChooseBagelLabel;
        private Label ChooseSizeLabel;
        private Button AddToOrderButton;
        private Button ClearButton;
        private TextBox QuantityTextBox;
        private Label TotalLabel;
        private Label QuantityLabel;
        private Label PriceLabel;
        private ListBox OrderedItemsListBox;
        private ToolTip ClearToolTip;
        private Panel ButtonPanel;
        private Button SalesButton;
        private Button SummaryButton;
        private ToolTip ClearTip;
        private ToolTip StockToolTip;
        private ToolTip SalesToolTip;
        private ToolTip SummaryToolTip;
        private Button ExitButton;
        private ToolTip ExitToolTip;
        private Panel SearchPanel;
        private Label SearchBoxLabel;
        private RadioButton DateRadioButton;
        private RadioButton SearchIDRadioButton;
        private TextBox DateTxtBox;
        private Button CompleteOrderButton;
        private ListBox TransactionsListBox;
        private Button IDSearchButton;
        private ToolTip CompleteOrderToolTip;
        private ToolTip AddToOrderToolTip;
        private ToolTip SearchToolTip;
        private Label BagelListLabel;
        private Label SizeListLabel;
        private Label QuantityListLabel;
        private TextBox TotalPriceTextBox;
        private TextBox PriceOutputTxtBox;
        private Button DateSearchButton;
        private Label IDNumLabel;
        private Label DateTimeLabel;
        private Label QuantityListBoxLabel;
        private Label TypeListLabel;
        private Label PriceListLabel;
        private Label TotalListLabel;
        private TextBox IDTxtBox;
        private Button ClearSearchButton;
        private ToolTip ClearSearchToolTip;
    }
}