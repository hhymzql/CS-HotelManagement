using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelServer_1
{
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            string strUserName = "";
            string strPWD = "";

            strUserName = login_user.Text.Trim();
            strPWD = login_pwd.Text.Trim();

            if (strUserName == "1" && strPWD == "1")
            {
                this.Hide();
                Form main = new main();
                main.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误!");
            }
        }

        private void but_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
