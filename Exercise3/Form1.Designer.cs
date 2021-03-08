
namespace Exercise3
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
            this.weightStandardLabel = new System.Windows.Forms.Label();
            this.weightMetricLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.standardWeightLbs = new System.Windows.Forms.TextBox();
            this.metricWeightKgs = new System.Windows.Forms.TextBox();
            this.lbsLabel = new System.Windows.Forms.Label();
            this.kgsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightStandardLabel
            // 
            this.weightStandardLabel.AutoSize = true;
            this.weightStandardLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightStandardLabel.Location = new System.Drawing.Point(12, 31);
            this.weightStandardLabel.Name = "weightStandardLabel";
            this.weightStandardLabel.Size = new System.Drawing.Size(176, 25);
            this.weightStandardLabel.TabIndex = 0;
            this.weightStandardLabel.Text = "Weight (Standard)";
            // 
            // weightMetricLabel
            // 
            this.weightMetricLabel.AutoSize = true;
            this.weightMetricLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightMetricLabel.Location = new System.Drawing.Point(12, 94);
            this.weightMetricLabel.Name = "weightMetricLabel";
            this.weightMetricLabel.Size = new System.Drawing.Size(151, 25);
            this.weightMetricLabel.TabIndex = 1;
            this.weightMetricLabel.Text = "Weight (Metric)";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(12, 172);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 47);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(352, 173);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 47);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // standardWeightLbs
            // 
            this.standardWeightLbs.Location = new System.Drawing.Point(211, 31);
            this.standardWeightLbs.Name = "standardWeightLbs";
            this.standardWeightLbs.Size = new System.Drawing.Size(124, 23);
            this.standardWeightLbs.TabIndex = 4;
            this.standardWeightLbs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metricWeightKgs
            // 
            this.metricWeightKgs.Location = new System.Drawing.Point(211, 95);
            this.metricWeightKgs.Name = "metricWeightKgs";
            this.metricWeightKgs.Size = new System.Drawing.Size(124, 23);
            this.metricWeightKgs.TabIndex = 5;
            this.metricWeightKgs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbsLabel
            // 
            this.lbsLabel.AutoSize = true;
            this.lbsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsLabel.Location = new System.Drawing.Point(341, 31);
            this.lbsLabel.Name = "lbsLabel";
            this.lbsLabel.Size = new System.Drawing.Size(35, 21);
            this.lbsLabel.TabIndex = 6;
            this.lbsLabel.Text = "Lbs";
            // 
            // kgsLabel
            // 
            this.kgsLabel.AutoSize = true;
            this.kgsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kgsLabel.Location = new System.Drawing.Point(341, 97);
            this.kgsLabel.Name = "kgsLabel";
            this.kgsLabel.Size = new System.Drawing.Size(37, 21);
            this.kgsLabel.TabIndex = 7;
            this.kgsLabel.Text = "Kgs";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(182, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kgsLabel);
            this.Controls.Add(this.lbsLabel);
            this.Controls.Add(this.metricWeightKgs);
            this.Controls.Add(this.standardWeightLbs);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightMetricLabel);
            this.Controls.Add(this.weightStandardLabel);
            this.Name = "Form1";
            this.Text = "Weight Conversion Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightStandardLabel;
        private System.Windows.Forms.Label weightMetricLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox standardWeightLbs;
        private System.Windows.Forms.TextBox metricWeightKgs;
        private System.Windows.Forms.Label lbsLabel;
        private System.Windows.Forms.Label kgsLabel;
        private System.Windows.Forms.Button button1;
    }
}

