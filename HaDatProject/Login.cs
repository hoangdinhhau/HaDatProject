using HaDatProject.DAO;
using HaDatProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaDatProject
{
    public partial class Login : Form
    {

        BindingSource listcheckout = new BindingSource();

        public Login()
        {
            InitializeComponent();

        }      

        bool Login2(string userName, string passWord)
        {
            return UserDAO.Instance.Login(userName, passWord);
        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPasswords.Text;
            if (Login2(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công");
                main f = new main();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thoát chương trình ?");
            Application.Exit();
        }

        private void txtPasswords_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btLogin_Click_1(sender, e);
            }
        }
    }

}
