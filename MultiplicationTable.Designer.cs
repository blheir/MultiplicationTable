namespace MultiplicationTable
{
    partial class MultiplicationTable
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
            userInteger = new TextBox();
            button1 = new Button();
            resultsBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 103);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 0;
            label1.Text = "1-10 Multiplication Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(140, 183);
            label2.Name = "label2";
            label2.Size = new Size(549, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter any integer, and I'll give you the product of it and numbers 1-10! ";
            // 
            // userInteger
            // 
            userInteger.Font = new Font("Segoe UI", 9F);
            userInteger.Location = new Point(299, 235);
            userInteger.Name = "userInteger";
            userInteger.Size = new Size(100, 23);
            userInteger.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(441, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultsBox
            // 
            resultsBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resultsBox.FormattingEnabled = true;
            resultsBox.ItemHeight = 15;
            resultsBox.Location = new Point(207, 275);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(401, 154);
            resultsBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsBox);
            Controls.Add(button1);
            Controls.Add(userInteger);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MultiplicationTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userInteger;
        private Button button1;
        private ListBox resultsBox;
    }
}
