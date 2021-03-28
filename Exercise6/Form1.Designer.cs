
namespace Exercise6
{
    partial class closeButton
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
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.diceFaceValueOne = new System.Windows.Forms.RichTextBox();
            this.diceFaceValueTwo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rollDiceButton.Location = new System.Drawing.Point(37, 39);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(139, 106);
            this.rollDiceButton.TabIndex = 0;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // diceFaceValueOne
            // 
            this.diceFaceValueOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diceFaceValueOne.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diceFaceValueOne.Location = new System.Drawing.Point(203, 39);
            this.diceFaceValueOne.Name = "diceFaceValueOne";
            this.diceFaceValueOne.Size = new System.Drawing.Size(115, 106);
            this.diceFaceValueOne.TabIndex = 1;
            this.diceFaceValueOne.Text = "";
            // 
            // diceFaceValueTwo
            // 
            this.diceFaceValueTwo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diceFaceValueTwo.Location = new System.Drawing.Point(364, 39);
            this.diceFaceValueTwo.Name = "diceFaceValueTwo";
            this.diceFaceValueTwo.Size = new System.Drawing.Size(117, 106);
            this.diceFaceValueTwo.TabIndex = 2;
            this.diceFaceValueTwo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // closeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diceFaceValueTwo);
            this.Controls.Add(this.diceFaceValueOne);
            this.Controls.Add(this.rollDiceButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "closeButton";
            this.Text = "Dice Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.RichTextBox diceFaceValueOne;
        private System.Windows.Forms.RichTextBox diceFaceValueTwo;
        private System.Windows.Forms.Button button1;
    }
}

