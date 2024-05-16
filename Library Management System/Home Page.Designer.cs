namespace Library_Management_System
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button14 = new Button();
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(241, 196, 15);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(119, 387);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(112, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(19, 15, 64);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 107);
            button1.Name = "button1";
            button1.Size = new Size(112, 35);
            button1.TabIndex = 3;
            button1.Text = "User";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(19, 15, 64);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 148);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 2;
            button2.Text = "Book";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.White;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(19, 15, 64);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 189);
            button3.Name = "button3";
            button3.Size = new Size(112, 35);
            button3.TabIndex = 4;
            button3.Text = "Issue Book";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(19, 15, 64);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 230);
            button4.Name = "button4";
            button4.Size = new Size(112, 35);
            button4.TabIndex = 5;
            button4.Text = "Receive Book";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button14
            // 
            button14.FlatAppearance.BorderColor = Color.White;
            button14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.FromArgb(19, 15, 64);
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(3, 271);
            button14.Name = "button14";
            button14.Size = new Size(112, 35);
            button14.TabIndex = 7;
            button14.Text = "Pay Fine";
            button14.TextAlign = ContentAlignment.MiddleRight;
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(125, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 164);
            panel1.TabIndex = 1;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderColor = Color.White;
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.FromArgb(19, 15, 64);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(3, 126);
            button9.Name = "button9";
            button9.Size = new Size(112, 35);
            button9.TabIndex = 7;
            button9.Text = "Delete User";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = Color.White;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(19, 15, 64);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 85);
            button8.Name = "button8";
            button8.Size = new Size(112, 35);
            button8.TabIndex = 6;
            button8.Text = "Update User";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.White;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(19, 15, 64);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 44);
            button7.Name = "button7";
            button7.Size = new Size(112, 35);
            button7.TabIndex = 5;
            button7.Text = "View User";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.White;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(19, 15, 64);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(112, 35);
            button6.TabIndex = 4;
            button6.Text = "Add User";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(123, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 164);
            panel2.TabIndex = 11;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderColor = Color.White;
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.FromArgb(19, 15, 64);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(3, 126);
            button10.Name = "button10";
            button10.Size = new Size(112, 35);
            button10.TabIndex = 7;
            button10.Text = "Delete Book";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderColor = Color.White;
            button11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.FromArgb(19, 15, 64);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(3, 85);
            button11.Name = "button11";
            button11.Size = new Size(112, 35);
            button11.TabIndex = 6;
            button11.Text = "Update Book";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.FlatAppearance.BorderColor = Color.White;
            button12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.FromArgb(19, 15, 64);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(3, 44);
            button12.Name = "button12";
            button12.Size = new Size(112, 35);
            button12.TabIndex = 5;
            button12.Text = "View Book";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.FlatAppearance.BorderColor = Color.White;
            button13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.FromArgb(19, 15, 64);
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(3, 3);
            button13.Name = "button13";
            button13.Size = new Size(112, 35);
            button13.TabIndex = 4;
            button13.Text = "Add Book";
            button13.TextAlign = ContentAlignment.MiddleRight;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(125, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 86);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Location = new Point(259, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 360);
            panel4.TabIndex = 12;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 385);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += Home_Page_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel3;
        private Panel panel2;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        public Panel panel4;
        private Button button14;
    }
}