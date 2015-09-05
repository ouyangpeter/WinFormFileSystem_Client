using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WinFormFileSystem.HttpRequest;
using System.Diagnostics;

namespace WinFormFileSystem.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_signup_Click_1(object sender, EventArgs e)
        {
            Form_Signup form_Signup = new Form_Signup();
            form_Signup.ShowDialog();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            HttpClientBase httpClient = new HttpClientLogin();
            string uname = textBox_account.Text.Trim();
            string passwd = textBox_passwd.Text.Trim();

            try
            {
                httpClient.AddHeader("user-uname", uname);
                httpClient.AddHeader("user-passwd", passwd);
                isSuccess = Convert.ToBoolean(httpClient.GetResponse());
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            if (isSuccess)
            {
                Account.SetUname(uname);
                Account.SetPasswd(passwd);
                Thread th = new Thread(fun => { Application.Run(new Form_FileSystem()); });
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }


        private void toolStripButton_ListUsers_Click(object sender, EventArgs e)
        {
            Form_ListUsers form_ListUsers = new Form_ListUsers();
            form_ListUsers.ShowDialog();
        }

        private void toolStripButton_test_Click(object sender, EventArgs e)
        {
            Form_test form_Signup = new Form_test();
            form_Signup.ShowDialog();
        }


        private void textBox_passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_signin_Click(null, null);
            }
        }



    }
}
