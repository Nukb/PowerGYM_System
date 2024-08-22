
namespace PowerGYM_System.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.top_pictureBox = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PowerGYM_System.Properties.Resources.icons8_password_48;
            this.pictureBox3.Location = new System.Drawing.Point(73, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PowerGYM_System.Properties.Resources.icons8_user_48;
            this.pictureBox2.Location = new System.Drawing.Point(73, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // top_pictureBox
            // 
            this.top_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("top_pictureBox.Image")));
            this.top_pictureBox.Location = new System.Drawing.Point(-9, -7);
            this.top_pictureBox.Name = "top_pictureBox";
            this.top_pictureBox.Size = new System.Drawing.Size(523, 159);
            this.top_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top_pictureBox.TabIndex = 0;
            this.top_pictureBox.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.username_label.Location = new System.Drawing.Point(111, 247);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(97, 24);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "اسم المستخدم";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password_label.Location = new System.Drawing.Point(112, 365);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(88, 24);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "كلمة المرور";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.username_textBox.Location = new System.Drawing.Point(73, 296);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(344, 30);
            this.username_textBox.TabIndex = 5;
            this.username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password_textBox.Location = new System.Drawing.Point(73, 413);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(344, 30);
            this.password_textBox.TabIndex = 6;
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_button.Location = new System.Drawing.Point(187, 498);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(122, 37);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "موافق";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.login_label.Location = new System.Drawing.Point(173, 148);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(155, 35);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "تسجيل الدخول";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Image = global::PowerGYM_System.Properties.Resources.icons8_close_48;
            this.close_button.Location = new System.Drawing.Point(454, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(53, 51);
            this.close_button.TabIndex = 9;
            this.close_button.TabStop = false;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 606);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.top_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox top_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button close_button;
    }
}