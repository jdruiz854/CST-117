
namespace Exercise_8
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.fatCaloriesOutput = new System.Windows.Forms.TextBox();
            this.gramsCarbsInput = new System.Windows.Forms.TextBox();
            this.gramsCarbsOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(64, 303);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(108, 39);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(232, 303);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 39);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(399, 303);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 39);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Location = new System.Drawing.Point(292, 56);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(100, 23);
            this.fatGramsInput.TabIndex = 3;
            // 
            // fatCaloriesOutput
            // 
            this.fatCaloriesOutput.Location = new System.Drawing.Point(292, 105);
            this.fatCaloriesOutput.Name = "fatCaloriesOutput";
            this.fatCaloriesOutput.ReadOnly = true;
            this.fatCaloriesOutput.Size = new System.Drawing.Size(100, 23);
            this.fatCaloriesOutput.TabIndex = 4;
            // 
            // gramsCarbsInput
            // 
            this.gramsCarbsInput.Location = new System.Drawing.Point(292, 165);
            this.gramsCarbsInput.Name = "gramsCarbsInput";
            this.gramsCarbsInput.Size = new System.Drawing.Size(100, 23);
            this.gramsCarbsInput.TabIndex = 5;
            // 
            // gramsCarbsOutput
            // 
            this.gramsCarbsOutput.Location = new System.Drawing.Point(292, 224);
            this.gramsCarbsOutput.Name = "gramsCarbsOutput";
            this.gramsCarbsOutput.ReadOnly = true;
            this.gramsCarbsOutput.Size = new System.Drawing.Size(100, 23);
            this.gramsCarbsOutput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grams of Fat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calories from Fat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grams of Carbs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calories from Carbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gramsCarbsOutput);
            this.Controls.Add(this.gramsCarbsInput);
            this.Controls.Add(this.fatCaloriesOutput);
            this.Controls.Add(this.fatGramsInput);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox fatGramsInput;
        private System.Windows.Forms.TextBox fatCaloriesOutput;
        private System.Windows.Forms.TextBox gramsCarbsInput;
        private System.Windows.Forms.TextBox gramsCarbsOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox O;
    }
}

