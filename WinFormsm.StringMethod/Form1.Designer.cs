namespace WinFormsm.StringMethod
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
            txtFullName = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSplitName = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(164, 65);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(551, 34);
            txtFullName.TabIndex = 0;
            txtFullName.Text = "นายกิตติภูมิ พงษ์ไทย";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(164, 177);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(306, 34);
            txtTitle.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(164, 230);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(306, 34);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(164, 281);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(306, 34);
            txtLastName.TabIndex = 0;
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(759, 65);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(123, 50);
            btnSplitName.TabIndex = 1;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 2;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 183);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 2;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 236);
            label3.Name = "label3";
            label3.Size = new Size(35, 28);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 287);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 2;
            label4.Text = "นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(782, 118);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 3;
            label5.Text = "btnSplitName";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(532, 102);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 3;
            label6.Text = "txtFullname";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(476, 177);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 3;
            label7.Text = "txtTitle";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(476, 233);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 3;
            label8.Text = "txtFirstName";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(476, 284);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 3;
            label9.Text = "txtLastName";
            label9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 491);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSplitName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullName);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "WinForm.StringMethod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSplitName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
