namespace AnnualPay
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.dollarsPerHourLabel = new System.Windows.Forms.Label();
            this.weeksWorkedLabel = new System.Windows.Forms.Label();
            this.totalAnnualLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.hoursWorkedText = new System.Windows.Forms.TextBox();
            this.dollarsPerHourText = new System.Windows.Forms.TextBox();
            this.weeksWorkedText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(12, 48);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(130, 13);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours Worked Per Week:";
            // 
            // dollarsPerHourLabel
            // 
            this.dollarsPerHourLabel.AutoSize = true;
            this.dollarsPerHourLabel.Location = new System.Drawing.Point(12, 73);
            this.dollarsPerHourLabel.Name = "dollarsPerHourLabel";
            this.dollarsPerHourLabel.Size = new System.Drawing.Size(133, 13);
            this.dollarsPerHourLabel.TabIndex = 1;
            this.dollarsPerHourLabel.Text = "Dollars per Hour Pay Rate:";
            // 
            // weeksWorkedLabel
            // 
            this.weeksWorkedLabel.AutoSize = true;
            this.weeksWorkedLabel.Location = new System.Drawing.Point(12, 100);
            this.weeksWorkedLabel.Name = "weeksWorkedLabel";
            this.weeksWorkedLabel.Size = new System.Drawing.Size(128, 13);
            this.weeksWorkedLabel.TabIndex = 2;
            this.weeksWorkedLabel.Text = "Weeks Worked per Year:";
            // 
            // totalAnnualLabel
            // 
            this.totalAnnualLabel.AutoSize = true;
            this.totalAnnualLabel.Location = new System.Drawing.Point(54, 146);
            this.totalAnnualLabel.Name = "totalAnnualLabel";
            this.totalAnnualLabel.Size = new System.Drawing.Size(91, 13);
            this.totalAnnualLabel.TabIndex = 3;
            this.totalAnnualLabel.Text = "Total Annual Pay:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(148, 141);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedText
            // 
            this.hoursWorkedText.Location = new System.Drawing.Point(148, 45);
            this.hoursWorkedText.Name = "hoursWorkedText";
            this.hoursWorkedText.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedText.TabIndex = 5;
            // 
            // dollarsPerHourText
            // 
            this.dollarsPerHourText.Location = new System.Drawing.Point(148, 70);
            this.dollarsPerHourText.Name = "dollarsPerHourText";
            this.dollarsPerHourText.Size = new System.Drawing.Size(100, 20);
            this.dollarsPerHourText.TabIndex = 6;
            // 
            // weeksWorkedText
            // 
            this.weeksWorkedText.Location = new System.Drawing.Point(148, 97);
            this.weeksWorkedText.Name = "weeksWorkedText";
            this.weeksWorkedText.Size = new System.Drawing.Size(100, 20);
            this.weeksWorkedText.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(57, 208);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 49);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Annual Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(148, 208);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 49);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(238, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 289);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weeksWorkedText);
            this.Controls.Add(this.dollarsPerHourText);
            this.Controls.Add(this.hoursWorkedText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalAnnualLabel);
            this.Controls.Add(this.weeksWorkedLabel);
            this.Controls.Add(this.dollarsPerHourLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "Annual Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label dollarsPerHourLabel;
        private System.Windows.Forms.Label weeksWorkedLabel;
        private System.Windows.Forms.Label totalAnnualLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox hoursWorkedText;
        private System.Windows.Forms.TextBox dollarsPerHourText;
        private System.Windows.Forms.TextBox weeksWorkedText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

