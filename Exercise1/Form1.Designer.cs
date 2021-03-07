
namespace Exercise1
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
            this.submitButton = new System.Windows.Forms.Button();
            this.skuNumber = new System.Windows.Forms.TextBox();
            this.skuNumberLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(203, 541);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // skuNumber
            // 
            this.skuNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skuNumber.Location = new System.Drawing.Point(203, 5);
            this.skuNumber.Name = "skuNumber";
            this.skuNumber.Size = new System.Drawing.Size(113, 33);
            this.skuNumber.TabIndex = 1;
            // 
            // skuNumberLabel
            // 
            this.skuNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skuNumberLabel.AutoSize = true;
            this.skuNumberLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skuNumberLabel.Location = new System.Drawing.Point(12, 16);
            this.skuNumberLabel.Margin = new System.Windows.Forms.Padding(3);
            this.skuNumberLabel.Name = "skuNumberLabel";
            this.skuNumberLabel.Size = new System.Drawing.Size(117, 22);
            this.skuNumberLabel.TabIndex = 3;
            this.skuNumberLabel.Text = "Sku Number";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemNameLabel.Location = new System.Drawing.Point(12, 69);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(105, 22);
            this.itemNameLabel.TabIndex = 4;
            this.itemNameLabel.Text = "Item Name";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(12, 188);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 22);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemDescriptionLabel.Location = new System.Drawing.Point(12, 128);
            this.itemDescriptionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(157, 22);
            this.itemDescriptionLabel.TabIndex = 8;
            this.itemDescriptionLabel.Text = "Item Description";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(392, 541);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemName.Location = new System.Drawing.Point(203, 58);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(445, 33);
            this.itemName.TabIndex = 10;
            // 
            // itemDescription
            // 
            this.itemDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemDescription.Location = new System.Drawing.Point(203, 117);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(445, 33);
            this.itemDescription.TabIndex = 11;
            this.itemDescription.TextChanged += new System.EventHandler(this.itemDescription_TextChanged);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(203, 177);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 33);
            this.quantity.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(573, 541);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 645);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.skuNumberLabel);
            this.Controls.Add(this.skuNumber);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox skuNumber;
        private System.Windows.Forms.Label skuNumberLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemDescription;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button cancelButton;
    }
}

