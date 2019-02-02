namespace Exercise4
{
    partial class MainForm
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
            this.secondsEntryLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondsEntryLabel
            // 
            this.secondsEntryLabel.AutoSize = true;
            this.secondsEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsEntryLabel.Location = new System.Drawing.Point(10, 47);
            this.secondsEntryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondsEntryLabel.Name = "secondsEntryLabel";
            this.secondsEntryLabel.Size = new System.Drawing.Size(219, 20);
            this.secondsEntryLabel.TabIndex = 0;
            this.secondsEntryLabel.Text = "Enter the number of seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTextBox.Location = new System.Drawing.Point(230, 45);
            this.secondsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(86, 26);
            this.secondsTextBox.TabIndex = 1;
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedLabel.Location = new System.Drawing.Point(10, 85);
            this.convertedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(0, 20);
            this.convertedLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(171, 112);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(84, 31);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 159);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.secondsEntryLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Seconds to Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsEntryLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

