
namespace Exercise4
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.timeEntry = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterTimeInSeconds = new System.Windows.Forms.Label();
            this.outPutText = new System.Windows.Forms.TextBox();
            this.conversionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 180);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // timeEntry
            // 
            this.timeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEntry.Location = new System.Drawing.Point(179, 40);
            this.timeEntry.Name = "timeEntry";
            this.timeEntry.Size = new System.Drawing.Size(198, 26);
            this.timeEntry.TabIndex = 1;
            this.timeEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(146, 180);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(269, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterTimeInSeconds
            // 
            this.enterTimeInSeconds.AutoSize = true;
            this.enterTimeInSeconds.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTimeInSeconds.Location = new System.Drawing.Point(12, 40);
            this.enterTimeInSeconds.Name = "enterTimeInSeconds";
            this.enterTimeInSeconds.Size = new System.Drawing.Size(113, 22);
            this.enterTimeInSeconds.TabIndex = 4;
            this.enterTimeInSeconds.Text = "Time (Secs)";
            // 
            // outPutText
            // 
            this.outPutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutText.Location = new System.Drawing.Point(189, 111);
            this.outPutText.Name = "outPutText";
            this.outPutText.ReadOnly = true;
            this.outPutText.Size = new System.Drawing.Size(188, 26);
            this.outPutText.TabIndex = 5;
            this.outPutText.TextChanged += new System.EventHandler(this.outPutText_TextChanged);
            // 
            // conversionOutput
            // 
            this.conversionOutput.AutoSize = true;
            this.conversionOutput.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionOutput.Location = new System.Drawing.Point(12, 111);
            this.conversionOutput.Name = "conversionOutput";
            this.conversionOutput.Size = new System.Drawing.Size(171, 22);
            this.conversionOutput.TabIndex = 6;
            this.conversionOutput.Text = "Conversion Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 304);
            this.Controls.Add(this.conversionOutput);
            this.Controls.Add(this.outPutText);
            this.Controls.Add(this.enterTimeInSeconds);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeEntry);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Time Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox timeEntry;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label enterTimeInSeconds;
        private System.Windows.Forms.TextBox outPutText;
        private System.Windows.Forms.Label conversionOutput;
    }
}

