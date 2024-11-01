namespace Test1
{
    partial class signup
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
            label1 = new Label();
            name_box = new TextBox();
            username_box = new TextBox();
            gender_box = new ComboBox();
            birth_box = new DateTimePicker();
            email_box = new TextBox();
            password_box = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            img = new PictureBox();
            imgbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(349, 15);
            label1.Name = "label1";
            label1.Size = new Size(252, 67);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // name_box
            // 
            name_box.Location = new Point(12, 85);
            name_box.Name = "name_box";
            name_box.PlaceholderText = "Enter your name here";
            name_box.Size = new Size(273, 27);
            name_box.TabIndex = 1;
            // 
            // username_box
            // 
            username_box.Location = new Point(12, 140);
            username_box.Name = "username_box";
            username_box.PlaceholderText = "Enter your user name";
            username_box.Size = new Size(273, 27);
            username_box.TabIndex = 2;
            // 
            // gender_box
            // 
            gender_box.FormattingEnabled = true;
            gender_box.Items.AddRange(new object[] { "Male", "Female" });
            gender_box.Location = new Point(12, 316);
            gender_box.Name = "gender_box";
            gender_box.Size = new Size(131, 28);
            gender_box.TabIndex = 3;
            // 
            // birth_box
            // 
            birth_box.Location = new Point(12, 386);
            birth_box.Name = "birth_box";
            birth_box.Size = new Size(238, 27);
            birth_box.TabIndex = 4;
            // 
            // email_box
            // 
            email_box.Location = new Point(12, 197);
            email_box.Name = "email_box";
            email_box.PlaceholderText = "Enter your Email";
            email_box.Size = new Size(273, 27);
            email_box.TabIndex = 5;
            email_box.TextChanged += textBox3_TextChanged;
            // 
            // password_box
            // 
            password_box.Location = new Point(12, 255);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.PlaceholderText = "Enter your password";
            password_box.Size = new Size(273, 27);
            password_box.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(314, 565);
            button1.Name = "button1";
            button1.Size = new Size(323, 60);
            button1.TabIndex = 7;
            button1.Text = "Create an account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__6_;
            pictureBox1.Location = new Point(304, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 444);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // img
            // 
            img.BackColor = Color.LightSteelBlue;
            img.Location = new Point(35, 430);
            img.Name = "img";
            img.Size = new Size(227, 99);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.TabIndex = 9;
            img.TabStop = false;
            img.Click += img_Click;
            // 
            // imgbtn
            // 
            imgbtn.Location = new Point(100, 552);
            imgbtn.Name = "imgbtn";
            imgbtn.Size = new Size(94, 29);
            imgbtn.TabIndex = 10;
            imgbtn.Text = "Browse";
            imgbtn.UseVisualStyleBackColor = true;
            imgbtn.Click += imgbtn_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(949, 628);
            Controls.Add(imgbtn);
            Controls.Add(img);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(password_box);
            Controls.Add(email_box);
            Controls.Add(birth_box);
            Controls.Add(gender_box);
            Controls.Add(username_box);
            Controls.Add(name_box);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_box;
        private TextBox username_box;
        private ComboBox gender_box;
        private DateTimePicker birth_box;
        private TextBox email_box;
        private TextBox password_box;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox img;
        private Button imgbtn;
    }
}