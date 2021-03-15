
namespace ProgrammingExercise2
{
    partial class Form1
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
            this.breakfastEggOptions = new System.Windows.Forms.CheckedListBox();
            this.breakfastRadioButton = new System.Windows.Forms.RadioButton();
            this.lunchRadioButton = new System.Windows.Forms.RadioButton();
            this.dinnerRadioButton = new System.Windows.Forms.RadioButton();
            this.lunchMainOptions = new System.Windows.Forms.CheckedListBox();
            this.dinnerMainOptions = new System.Windows.Forms.CheckedListBox();
            this.breakfastMeatOptions = new System.Windows.Forms.CheckedListBox();
            this.breakfastToastOptions = new System.Windows.Forms.CheckedListBox();
            this.eggOptionsLabel = new System.Windows.Forms.Label();
            this.breakfastMeatOptionsLabel = new System.Windows.Forms.Label();
            this.breadOptionsLabel = new System.Windows.Forms.Label();
            this.beverageOptionsLabel = new System.Windows.Forms.Label();
            this.breakfastBeverageOptions = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lunchSideOptions = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.orderSummaryList = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.dinnerDeliveryTimes = new System.Windows.Forms.ListBox();
            this.dinnerDeliveryTimeLabel = new System.Windows.Forms.Label();
            this.lunchDeliveryTimeLabel = new System.Windows.Forms.Label();
            this.lunchDeliveryTimes = new System.Windows.Forms.ListBox();
            this.breakfastDeliveryTimeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.breakfastDeliveryTimes = new System.Windows.Forms.ListBox();
            this.dinnerBeveragLabel = new System.Windows.Forms.Label();
            this.dinnerBeverageOptions = new System.Windows.Forms.CheckedListBox();
            this.dinnerSidesLabel = new System.Windows.Forms.Label();
            this.dinnerSideOptions = new System.Windows.Forms.CheckedListBox();
            this.dinnerMainsLabel = new System.Windows.Forms.Label();
            this.lunchMainsLabel = new System.Windows.Forms.Label();
            this.lunchBeverageLabel = new System.Windows.Forms.Label();
            this.lunchSidesLabel = new System.Windows.Forms.Label();
            this.lunchBeverageOptions = new System.Windows.Forms.CheckedListBox();
            this.headerDinner = new System.Windows.Forms.Label();
            this.headerLunch = new System.Windows.Forms.Label();
            this.headerBreakfast = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakfastEggOptions
            // 
            this.breakfastEggOptions.FormattingEnabled = true;
            this.breakfastEggOptions.Items.AddRange(new object[] {
            "Scrambled Eggs",
            "Sunny Side Up",
            "Over Easy Eggs",
            "Over Medium Eggs",
            "Over Hard Eggs",
            "Poached Eggs"});
            this.breakfastEggOptions.Location = new System.Drawing.Point(59, 86);
            this.breakfastEggOptions.Name = "breakfastEggOptions";
            this.breakfastEggOptions.Size = new System.Drawing.Size(170, 130);
            this.breakfastEggOptions.TabIndex = 0;
            this.breakfastEggOptions.Visible = false;
            // 
            // breakfastRadioButton
            // 
            this.breakfastRadioButton.AutoSize = true;
            this.breakfastRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breakfastRadioButton.Location = new System.Drawing.Point(22, 56);
            this.breakfastRadioButton.Name = "breakfastRadioButton";
            this.breakfastRadioButton.Size = new System.Drawing.Size(113, 29);
            this.breakfastRadioButton.TabIndex = 1;
            this.breakfastRadioButton.TabStop = true;
            this.breakfastRadioButton.Text = "Breakfast";
            this.breakfastRadioButton.UseVisualStyleBackColor = true;
            this.breakfastRadioButton.CheckedChanged += new System.EventHandler(this.breakfastRadioButton_CheckedChanged);
            // 
            // lunchRadioButton
            // 
            this.lunchRadioButton.AutoSize = true;
            this.lunchRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lunchRadioButton.Location = new System.Drawing.Point(24, 106);
            this.lunchRadioButton.Name = "lunchRadioButton";
            this.lunchRadioButton.Size = new System.Drawing.Size(84, 29);
            this.lunchRadioButton.TabIndex = 2;
            this.lunchRadioButton.Text = "Lunch";
            this.lunchRadioButton.UseVisualStyleBackColor = true;
            this.lunchRadioButton.CheckedChanged += new System.EventHandler(this.lunchRadioButton_CheckedChanged);
            // 
            // dinnerRadioButton
            // 
            this.dinnerRadioButton.AutoSize = true;
            this.dinnerRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dinnerRadioButton.Location = new System.Drawing.Point(22, 159);
            this.dinnerRadioButton.Name = "dinnerRadioButton";
            this.dinnerRadioButton.Size = new System.Drawing.Size(91, 29);
            this.dinnerRadioButton.TabIndex = 3;
            this.dinnerRadioButton.Text = "Dinner";
            this.dinnerRadioButton.UseVisualStyleBackColor = true;
            this.dinnerRadioButton.CheckedChanged += new System.EventHandler(this.dinnerRadioButton_CheckedChanged);
            // 
            // lunchMainOptions
            // 
            this.lunchMainOptions.FormattingEnabled = true;
            this.lunchMainOptions.Items.AddRange(new object[] {
            "Ham and Cheese Sandwich",
            "Reuben Sandwich",
            "Cheeseburger",
            "Philly Cheesesteak",
            "Cheese Pizza",
            "Pepperoni Pizza",
            "Supreme Pizza"});
            this.lunchMainOptions.Location = new System.Drawing.Point(61, 86);
            this.lunchMainOptions.Name = "lunchMainOptions";
            this.lunchMainOptions.Size = new System.Drawing.Size(170, 184);
            this.lunchMainOptions.TabIndex = 5;
            this.lunchMainOptions.Visible = false;
            // 
            // dinnerMainOptions
            // 
            this.dinnerMainOptions.FormattingEnabled = true;
            this.dinnerMainOptions.Items.AddRange(new object[] {
            "T-Bone Steak",
            "Rib Eye Steak",
            "Chicken Parmesean",
            "Chicken Fettucini Alfredo",
            "Lemon Pepper Crusted Salmon",
            "Jerk Chicken"});
            this.dinnerMainOptions.Location = new System.Drawing.Point(61, 86);
            this.dinnerMainOptions.Name = "dinnerMainOptions";
            this.dinnerMainOptions.Size = new System.Drawing.Size(193, 184);
            this.dinnerMainOptions.TabIndex = 6;
            this.dinnerMainOptions.Visible = false;
            // 
            // breakfastMeatOptions
            // 
            this.breakfastMeatOptions.FormattingEnabled = true;
            this.breakfastMeatOptions.Items.AddRange(new object[] {
            "Bacon",
            "Sausage",
            "Canadian Bacon",
            "Ham Steak",
            "Breakfast Ham",
            "Turkey Bacon",
            "Turkey Sausage"});
            this.breakfastMeatOptions.Location = new System.Drawing.Point(61, 259);
            this.breakfastMeatOptions.Name = "breakfastMeatOptions";
            this.breakfastMeatOptions.Size = new System.Drawing.Size(170, 148);
            this.breakfastMeatOptions.TabIndex = 7;
            this.breakfastMeatOptions.Visible = false;
            this.breakfastMeatOptions.SelectedIndexChanged += new System.EventHandler(this.breakfastMeatOptions_SelectedIndexChanged);
            // 
            // breakfastToastOptions
            // 
            this.breakfastToastOptions.FormattingEnabled = true;
            this.breakfastToastOptions.Items.AddRange(new object[] {
            "Wheat Toast",
            "White Toast",
            "Sourdough Toast",
            "Rye Toast",
            "English Muffin",
            "Blueberry Muffin"});
            this.breakfastToastOptions.Location = new System.Drawing.Point(61, 448);
            this.breakfastToastOptions.Name = "breakfastToastOptions";
            this.breakfastToastOptions.Size = new System.Drawing.Size(170, 130);
            this.breakfastToastOptions.TabIndex = 8;
            this.breakfastToastOptions.Visible = false;
            // 
            // eggOptionsLabel
            // 
            this.eggOptionsLabel.AutoSize = true;
            this.eggOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eggOptionsLabel.Location = new System.Drawing.Point(57, 59);
            this.eggOptionsLabel.Name = "eggOptionsLabel";
            this.eggOptionsLabel.Size = new System.Drawing.Size(95, 21);
            this.eggOptionsLabel.TabIndex = 9;
            this.eggOptionsLabel.Text = "Egg Options";
            this.eggOptionsLabel.Visible = false;
            this.eggOptionsLabel.Click += new System.EventHandler(this.eggOptionsLabel_Click);
            // 
            // breakfastMeatOptionsLabel
            // 
            this.breakfastMeatOptionsLabel.AutoSize = true;
            this.breakfastMeatOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastMeatOptionsLabel.Location = new System.Drawing.Point(59, 235);
            this.breakfastMeatOptionsLabel.Name = "breakfastMeatOptionsLabel";
            this.breakfastMeatOptionsLabel.Size = new System.Drawing.Size(172, 21);
            this.breakfastMeatOptionsLabel.TabIndex = 10;
            this.breakfastMeatOptionsLabel.Text = "Breakfast Meat Options";
            this.breakfastMeatOptionsLabel.Visible = false;
            // 
            // breadOptionsLabel
            // 
            this.breadOptionsLabel.AutoSize = true;
            this.breadOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breadOptionsLabel.Location = new System.Drawing.Point(59, 424);
            this.breadOptionsLabel.Name = "breadOptionsLabel";
            this.breadOptionsLabel.Size = new System.Drawing.Size(109, 21);
            this.breadOptionsLabel.TabIndex = 11;
            this.breadOptionsLabel.Text = "Bread Options";
            this.breadOptionsLabel.Visible = false;
            // 
            // beverageOptionsLabel
            // 
            this.beverageOptionsLabel.AutoSize = true;
            this.beverageOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beverageOptionsLabel.Location = new System.Drawing.Point(59, 597);
            this.beverageOptionsLabel.Name = "beverageOptionsLabel";
            this.beverageOptionsLabel.Size = new System.Drawing.Size(133, 21);
            this.beverageOptionsLabel.TabIndex = 12;
            this.beverageOptionsLabel.Text = "Beverage Options";
            this.beverageOptionsLabel.Visible = false;
            // 
            // breakfastBeverageOptions
            // 
            this.breakfastBeverageOptions.FormattingEnabled = true;
            this.breakfastBeverageOptions.Items.AddRange(new object[] {
            "Coffee",
            "Decaf Coffee",
            "Orange Juice",
            "Apple Juice",
            "Milk",
            "Bottled Water",
            "Mimosa",
            "Bloody Mary"});
            this.breakfastBeverageOptions.Location = new System.Drawing.Point(59, 621);
            this.breakfastBeverageOptions.Name = "breakfastBeverageOptions";
            this.breakfastBeverageOptions.Size = new System.Drawing.Size(170, 166);
            this.breakfastBeverageOptions.TabIndex = 13;
            this.breakfastBeverageOptions.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.dinnerRadioButton);
            this.groupBox1.Controls.Add(this.lunchRadioButton);
            this.groupBox1.Controls.Add(this.breakfastRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(48, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 221);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Meal";
            // 
            // lunchSideOptions
            // 
            this.lunchSideOptions.FormattingEnabled = true;
            this.lunchSideOptions.Items.AddRange(new object[] {
            "French Fries",
            "Mac and Cheese",
            "Apple Slices",
            "Tater Tots",
            "Onion Rings"});
            this.lunchSideOptions.Location = new System.Drawing.Point(63, 307);
            this.lunchSideOptions.Name = "lunchSideOptions";
            this.lunchSideOptions.Size = new System.Drawing.Size(170, 130);
            this.lunchSideOptions.TabIndex = 15;
            this.lunchSideOptions.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.orderSummaryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.orderSummaryList);
            this.splitContainer1.Panel2.Controls.Add(this.resetButton);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerDeliveryTimes);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerDeliveryTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchDeliveryTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchDeliveryTimes);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastDeliveryTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.deliveryTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.submitButton);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastDeliveryTimes);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerBeveragLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerBeverageOptions);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerSidesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerSideOptions);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerMainsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchMainsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchBeverageLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchSidesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lunchBeverageOptions);
            this.splitContainer1.Panel2.Controls.Add(this.headerDinner);
            this.splitContainer1.Panel2.Controls.Add(this.headerLunch);
            this.splitContainer1.Panel2.Controls.Add(this.headerBreakfast);
            this.splitContainer1.Panel2.Controls.Add(this.lunchSideOptions);
            this.splitContainer1.Panel2.Controls.Add(this.breadOptionsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.beverageOptionsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastBeverageOptions);
            this.splitContainer1.Panel2.Controls.Add(this.dinnerMainOptions);
            this.splitContainer1.Panel2.Controls.Add(this.lunchMainOptions);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastEggOptions);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastToastOptions);
            this.splitContainer1.Panel2.Controls.Add(this.eggOptionsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastMeatOptionsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.breakfastMeatOptions);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 854);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 16;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderSummaryLabel.Location = new System.Drawing.Point(584, 31);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(188, 28);
            this.orderSummaryLabel.TabIndex = 37;
            this.orderSummaryLabel.Text = "Order Summary";
            // 
            // orderSummaryList
            // 
            this.orderSummaryList.FormattingEnabled = true;
            this.orderSummaryList.ItemHeight = 15;
            this.orderSummaryList.Location = new System.Drawing.Point(604, 86);
            this.orderSummaryList.Name = "orderSummaryList";
            this.orderSummaryList.Size = new System.Drawing.Size(149, 394);
            this.orderSummaryList.TabIndex = 36;
            this.orderSummaryList.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(259, 805);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 40);
            this.resetButton.TabIndex = 35;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dinnerDeliveryTimes
            // 
            this.dinnerDeliveryTimes.FormattingEnabled = true;
            this.dinnerDeliveryTimes.ItemHeight = 15;
            this.dinnerDeliveryTimes.Items.AddRange(new object[] {
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM"});
            this.dinnerDeliveryTimes.Location = new System.Drawing.Point(375, 86);
            this.dinnerDeliveryTimes.Name = "dinnerDeliveryTimes";
            this.dinnerDeliveryTimes.Size = new System.Drawing.Size(106, 244);
            this.dinnerDeliveryTimes.TabIndex = 34;
            this.dinnerDeliveryTimes.Visible = false;
            // 
            // dinnerDeliveryTimeLabel
            // 
            this.dinnerDeliveryTimeLabel.AutoSize = true;
            this.dinnerDeliveryTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerDeliveryTimeLabel.Location = new System.Drawing.Point(375, 58);
            this.dinnerDeliveryTimeLabel.Name = "dinnerDeliveryTimeLabel";
            this.dinnerDeliveryTimeLabel.Size = new System.Drawing.Size(57, 21);
            this.dinnerDeliveryTimeLabel.TabIndex = 33;
            this.dinnerDeliveryTimeLabel.Text = "Dinner";
            this.dinnerDeliveryTimeLabel.Visible = false;
            // 
            // lunchDeliveryTimeLabel
            // 
            this.lunchDeliveryTimeLabel.AutoSize = true;
            this.lunchDeliveryTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchDeliveryTimeLabel.Location = new System.Drawing.Point(375, 58);
            this.lunchDeliveryTimeLabel.Name = "lunchDeliveryTimeLabel";
            this.lunchDeliveryTimeLabel.Size = new System.Drawing.Size(52, 21);
            this.lunchDeliveryTimeLabel.TabIndex = 32;
            this.lunchDeliveryTimeLabel.Text = "Lunch";
            this.lunchDeliveryTimeLabel.Visible = false;
            // 
            // lunchDeliveryTimes
            // 
            this.lunchDeliveryTimes.FormattingEnabled = true;
            this.lunchDeliveryTimes.ItemHeight = 15;
            this.lunchDeliveryTimes.Items.AddRange(new object[] {
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM"});
            this.lunchDeliveryTimes.Location = new System.Drawing.Point(375, 86);
            this.lunchDeliveryTimes.Name = "lunchDeliveryTimes";
            this.lunchDeliveryTimes.Size = new System.Drawing.Size(106, 169);
            this.lunchDeliveryTimes.TabIndex = 31;
            this.lunchDeliveryTimes.Visible = false;
            // 
            // breakfastDeliveryTimeLabel
            // 
            this.breakfastDeliveryTimeLabel.AutoSize = true;
            this.breakfastDeliveryTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastDeliveryTimeLabel.Location = new System.Drawing.Point(375, 58);
            this.breakfastDeliveryTimeLabel.Name = "breakfastDeliveryTimeLabel";
            this.breakfastDeliveryTimeLabel.Size = new System.Drawing.Size(74, 21);
            this.breakfastDeliveryTimeLabel.TabIndex = 30;
            this.breakfastDeliveryTimeLabel.Text = "Breakfast";
            this.breakfastDeliveryTimeLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(424, 805);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryTimeLabel.Location = new System.Drawing.Point(338, 3);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(167, 56);
            this.deliveryTimeLabel.TabIndex = 29;
            this.deliveryTimeLabel.Text = "Please Select \r\nDelivery Time";
            this.deliveryTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(91, 805);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 40);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // breakfastDeliveryTimes
            // 
            this.breakfastDeliveryTimes.FormattingEnabled = true;
            this.breakfastDeliveryTimes.ItemHeight = 15;
            this.breakfastDeliveryTimes.Items.AddRange(new object[] {
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM"});
            this.breakfastDeliveryTimes.Location = new System.Drawing.Point(375, 86);
            this.breakfastDeliveryTimes.Name = "breakfastDeliveryTimes";
            this.breakfastDeliveryTimes.Size = new System.Drawing.Size(106, 169);
            this.breakfastDeliveryTimes.TabIndex = 28;
            this.breakfastDeliveryTimes.Visible = false;
            // 
            // dinnerBeveragLabel
            // 
            this.dinnerBeveragLabel.AutoSize = true;
            this.dinnerBeveragLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerBeveragLabel.Location = new System.Drawing.Point(63, 467);
            this.dinnerBeveragLabel.Name = "dinnerBeveragLabel";
            this.dinnerBeveragLabel.Size = new System.Drawing.Size(133, 21);
            this.dinnerBeveragLabel.TabIndex = 27;
            this.dinnerBeveragLabel.Text = "Beverage Options";
            this.dinnerBeveragLabel.Visible = false;
            // 
            // dinnerBeverageOptions
            // 
            this.dinnerBeverageOptions.FormattingEnabled = true;
            this.dinnerBeverageOptions.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Sprite",
            "Sprite Zero",
            "Unsweet Iced Tea",
            "Sweet Tea",
            "Hot Tea",
            "Coffee",
            "Decaf Coffee",
            "Dr. Pepper",
            "Barqs Root Beer"});
            this.dinnerBeverageOptions.Location = new System.Drawing.Point(61, 491);
            this.dinnerBeverageOptions.Name = "dinnerBeverageOptions";
            this.dinnerBeverageOptions.Size = new System.Drawing.Size(170, 220);
            this.dinnerBeverageOptions.TabIndex = 26;
            this.dinnerBeverageOptions.Visible = false;
            this.dinnerBeverageOptions.SelectedIndexChanged += new System.EventHandler(this.dinnerBeverageOptions_SelectedIndexChanged);
            // 
            // dinnerSidesLabel
            // 
            this.dinnerSidesLabel.AutoSize = true;
            this.dinnerSidesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerSidesLabel.Location = new System.Drawing.Point(63, 283);
            this.dinnerSidesLabel.Name = "dinnerSidesLabel";
            this.dinnerSidesLabel.Size = new System.Drawing.Size(47, 21);
            this.dinnerSidesLabel.TabIndex = 25;
            this.dinnerSidesLabel.Text = "Sides";
            this.dinnerSidesLabel.Visible = false;
            // 
            // dinnerSideOptions
            // 
            this.dinnerSideOptions.FormattingEnabled = true;
            this.dinnerSideOptions.Items.AddRange(new object[] {
            "French Fries",
            "Mashed Potatoes",
            "Loaded Mashed Potatoes",
            "Baked Potato",
            "Loaded Baked Potato",
            "Steamed Mixed Vegetables",
            "Gravy",
            "Grilled Asparagus"});
            this.dinnerSideOptions.Location = new System.Drawing.Point(63, 307);
            this.dinnerSideOptions.Name = "dinnerSideOptions";
            this.dinnerSideOptions.Size = new System.Drawing.Size(170, 148);
            this.dinnerSideOptions.TabIndex = 24;
            this.dinnerSideOptions.Visible = false;
            // 
            // dinnerMainsLabel
            // 
            this.dinnerMainsLabel.AutoSize = true;
            this.dinnerMainsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerMainsLabel.Location = new System.Drawing.Point(63, 58);
            this.dinnerMainsLabel.Name = "dinnerMainsLabel";
            this.dinnerMainsLabel.Size = new System.Drawing.Size(52, 21);
            this.dinnerMainsLabel.TabIndex = 23;
            this.dinnerMainsLabel.Text = "Mains";
            this.dinnerMainsLabel.Visible = false;
            // 
            // lunchMainsLabel
            // 
            this.lunchMainsLabel.AutoSize = true;
            this.lunchMainsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchMainsLabel.Location = new System.Drawing.Point(59, 59);
            this.lunchMainsLabel.Name = "lunchMainsLabel";
            this.lunchMainsLabel.Size = new System.Drawing.Size(52, 21);
            this.lunchMainsLabel.TabIndex = 22;
            this.lunchMainsLabel.Text = "Mains";
            this.lunchMainsLabel.Visible = false;
            this.lunchMainsLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // lunchBeverageLabel
            // 
            this.lunchBeverageLabel.AutoSize = true;
            this.lunchBeverageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchBeverageLabel.Location = new System.Drawing.Point(61, 467);
            this.lunchBeverageLabel.Name = "lunchBeverageLabel";
            this.lunchBeverageLabel.Size = new System.Drawing.Size(133, 21);
            this.lunchBeverageLabel.TabIndex = 21;
            this.lunchBeverageLabel.Text = "Beverage Options";
            this.lunchBeverageLabel.Visible = false;
            // 
            // lunchSidesLabel
            // 
            this.lunchSidesLabel.AutoSize = true;
            this.lunchSidesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchSidesLabel.Location = new System.Drawing.Point(63, 283);
            this.lunchSidesLabel.Name = "lunchSidesLabel";
            this.lunchSidesLabel.Size = new System.Drawing.Size(47, 21);
            this.lunchSidesLabel.TabIndex = 20;
            this.lunchSidesLabel.Text = "Sides";
            this.lunchSidesLabel.Visible = false;
            // 
            // lunchBeverageOptions
            // 
            this.lunchBeverageOptions.FormattingEnabled = true;
            this.lunchBeverageOptions.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Sprite",
            "Sprite Zero",
            "Unsweet Iced Tea",
            "Sweet Tea",
            "Hot Tea",
            "Coffee",
            "Decaf Coffee",
            "Dr. Pepper",
            "Barqs Root Beer"});
            this.lunchBeverageOptions.Location = new System.Drawing.Point(63, 491);
            this.lunchBeverageOptions.Name = "lunchBeverageOptions";
            this.lunchBeverageOptions.Size = new System.Drawing.Size(170, 220);
            this.lunchBeverageOptions.TabIndex = 19;
            this.lunchBeverageOptions.Visible = false;
            // 
            // headerDinner
            // 
            this.headerDinner.AutoSize = true;
            this.headerDinner.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerDinner.Location = new System.Drawing.Point(63, 7);
            this.headerDinner.Name = "headerDinner";
            this.headerDinner.Size = new System.Drawing.Size(89, 28);
            this.headerDinner.TabIndex = 18;
            this.headerDinner.Text = "Dinner";
            this.headerDinner.Visible = false;
            // 
            // headerLunch
            // 
            this.headerLunch.AutoSize = true;
            this.headerLunch.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerLunch.Location = new System.Drawing.Point(63, 7);
            this.headerLunch.Name = "headerLunch";
            this.headerLunch.Size = new System.Drawing.Size(78, 28);
            this.headerLunch.TabIndex = 17;
            this.headerLunch.Text = "Lunch";
            this.headerLunch.Visible = false;
            // 
            // headerBreakfast
            // 
            this.headerBreakfast.AutoSize = true;
            this.headerBreakfast.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerBreakfast.Location = new System.Drawing.Point(57, 7);
            this.headerBreakfast.Name = "headerBreakfast";
            this.headerBreakfast.Size = new System.Drawing.Size(120, 28);
            this.headerBreakfast.TabIndex = 16;
            this.headerBreakfast.Text = "Breakfast";
            this.headerBreakfast.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 859);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Meal Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox breakfastEggOptions;
        private System.Windows.Forms.RadioButton breakfastRadioButton;
        private System.Windows.Forms.RadioButton lunchRadioButton;
        private System.Windows.Forms.RadioButton dinnerRadioButton;
        private System.Windows.Forms.CheckedListBox lunchMainOptions;
        private System.Windows.Forms.CheckedListBox dinnerMainOptions;
        private System.Windows.Forms.CheckedListBox breakfastMeatOptions;
        private System.Windows.Forms.CheckedListBox breakfastToastOptions;
        private System.Windows.Forms.Label eggOptionsLabel;
        private System.Windows.Forms.Label breakfastMeatOptionsLabel;
        private System.Windows.Forms.Label breadOptionsLabel;
        private System.Windows.Forms.Label beverageOptionsLabel;
        private System.Windows.Forms.CheckedListBox breakfastBeverageOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lunchSideOptions;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lunchMainsLabel;
        private System.Windows.Forms.Label lunchBeverageLabel;
        private System.Windows.Forms.Label lunchSidesLabel;
        private System.Windows.Forms.CheckedListBox lunchBeverageOptions;
        private System.Windows.Forms.Label headerDinner;
        private System.Windows.Forms.Label headerLunch;
        private System.Windows.Forms.Label headerBreakfast;
        private System.Windows.Forms.Label dinnerBeveragLabel;
        private System.Windows.Forms.CheckedListBox dinnerBeverageOptions;
        private System.Windows.Forms.Label dinnerSidesLabel;
        private System.Windows.Forms.CheckedListBox dinnerSideOptions;
        private System.Windows.Forms.Label dinnerMainsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox breakfastDeliveryTimes;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.Label breakfastDeliveryTimeLabel;
        private System.Windows.Forms.ListBox dinnerDeliveryTimes;
        private System.Windows.Forms.Label dinnerDeliveryTimeLabel;
        private System.Windows.Forms.Label lunchDeliveryTimeLabel;
        private System.Windows.Forms.ListBox lunchDeliveryTimes;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.ListBox orderSummaryList;
    }
}

