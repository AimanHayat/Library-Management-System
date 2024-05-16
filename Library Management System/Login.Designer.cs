namespace Library_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            Username = new Label();
            UsernameText = new TextBox();
            button1 = new Button();
            PasswordText = new TextBox();
            Password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(364, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(306, 124);
            Username.Name = "Username";
            Username.Size = new Size(69, 17);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // UsernameText
            // 
            UsernameText.Anchor = AnchorStyles.None;
            UsernameText.Location = new Point(309, 153);
            UsernameText.Margin = new Padding(0);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(201, 23);
            UsernameText.TabIndex = 3;
            UsernameText.TextChanged += UsernameText_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(309, 279);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(201, 35);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.None;
            PasswordText.Location = new Point(309, 225);
            PasswordText.Margin = new Padding(0);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(201, 23);
            PasswordText.TabIndex = 8;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(306, 196);
            Password.Name = "Password";
            Password.Size = new Size(66, 17);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 396);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(541, 365);
            Controls.Add(PasswordText);
            Controls.Add(Password);
            Controls.Add(button1);
            Controls.Add(UsernameText);
            Controls.Add(Username);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label Username;
        private TextBox UsernameText;
        private Button button1;
        private TextBox PasswordText;
        private Label Password;
        private PictureBox pictureBox1;
    }
}