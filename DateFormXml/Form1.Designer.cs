namespace DateFormXml
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            DateWeekComboBox = new ComboBox();
            DateMonthComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 144);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 48);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 144);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 48);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 0;
            label5.Text = "כתיבת התאריך";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 144);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 0;
            label6.Text = "היום בשבוע";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 144);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 0;
            label7.Text = "היום בחודש";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 144);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 0;
            label8.Text = "חודש";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 144);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 0;
            label9.Text = "שנה";
            // 
            // DateWeekComboBox
            // 
            DateWeekComboBox.FormattingEnabled = true;
            DateWeekComboBox.Location = new Point(571, 204);
            DateWeekComboBox.Name = "DateWeekComboBox";
            DateWeekComboBox.Size = new Size(92, 28);
            DateWeekComboBox.TabIndex = 1;
            // 
            // DateMonthComboBox
            // 
            DateMonthComboBox.FormattingEnabled = true;
            DateMonthComboBox.Location = new Point(459, 204);
            DateMonthComboBox.Name = "DateMonthComboBox";
            DateMonthComboBox.Size = new Size(92, 28);
            DateMonthComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Location = new Point(337, 204);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(92, 28);
            MonthComboBox.TabIndex = 1;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new Point(208, 204);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(92, 28);
            YearComboBox.TabIndex = 1;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(337, 280);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(131, 46);
            SendButton.TabIndex = 2;
            SendButton.Text = "שליחה";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendButton);
            Controls.Add(YearComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(DateMonthComboBox);
            Controls.Add(DateWeekComboBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox DateWeekComboBox;
        private ComboBox DateMonthComboBox;
        private ComboBox MonthComboBox;
        private ComboBox YearComboBox;
        private Button SendButton;
    }
}
