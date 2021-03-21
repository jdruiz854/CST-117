
namespace Exercise5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.TextBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.outputTextCalculation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(180, 67);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(250, 29);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.termsLabel.Location = new System.Drawing.Point(12, 67);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(150, 25);
            this.termsLabel.TabIndex = 1;
            this.termsLabel.Text = "Enter # of terms:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(19, 139);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 54);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Location = new System.Drawing.Point(42, 250);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(353, 22);
            this.outputText.TabIndex = 3;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(251, 139);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 54);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(42, 229);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(65, 21);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "Answer:";
            // 
            // outputTextCalculation
            // 
            this.outputTextCalculation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.outputTextCalculation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextCalculation.Location = new System.Drawing.Point(42, 285);
            this.outputTextCalculation.Name = "outputTextCalculation";
            this.outputTextCalculation.Size = new System.Drawing.Size(353, 22);
            this.outputTextCalculation.TabIndex = 6;
            this.outputTextCalculation.TextChanged += new System.EventHandler(this.outputTextCalculation_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.outputTextCalculation);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.inputText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox outputTextCalculation;
    }
}

