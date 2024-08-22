using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerGYM_System.Forms
{
    public partial class Login : Form
    {
        string x = "1";
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_textBox.Text))
            {
                MessageBox.Show("يجب إدخال اسم المستخدم ", "خطأ إدخال");
                username_textBox.Focus();
            }
            else if (string.IsNullOrEmpty(password_textBox.Text))
            {
                MessageBox.Show("يجب إدخال كلمة المرور ", "خطأ إدخال");
                password_textBox.Focus();
            }
            else
            {

                if (username_textBox.Text == x && password_textBox.Text == x)
                {
                    this.Hide();
                    Main m = new Main();
                    m.ShowDialog();
                    Application.Exit(); // Terminate the application
                }
                else
                {
                    MessageBox.Show("هناك خطأ في اسم المستخدم أو كلمة المرور", "خطأ إدخال");
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
