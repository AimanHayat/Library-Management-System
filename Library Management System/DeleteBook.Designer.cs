﻿namespace Library_Management_System
{
    partial class DeleteBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(330, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 16;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 14;
            label1.Text = "Book ISBN";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 317);
            panel1.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(102, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(336, 23);
            textBox7.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 263);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 16;
            label7.Text = "Author";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(99, 124);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(336, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 23);
            textBox4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 218);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 289);
            button2.Name = "button2";
            button2.Size = new Size(425, 25);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 78);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(336, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 23);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 170);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 7;
            label4.Text = "Publish Date";
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DeleteBook";
            Size = new Size(445, 360);
            Load += DeleteBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label6;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox7;
        private Label label7;
    }
}
