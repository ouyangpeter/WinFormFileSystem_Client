using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormFileSystem.HttpRequest;

namespace WinFormFileSystem.Forms
{
    public partial class Form_Signup : Form
    {
        public Form_Signup()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            if(textBox_account.Text.Trim() == "" || textBox_passwd.Text.Trim() == "")
            {
                MessageBox.Show("注册失败");
                return;
            }
            bool isSuccess = false;
            HttpClientBase httpClient = new HttpClientSignUp();
            try
            {
                httpClient.AddHeader("user-uname", textBox_account.Text.Trim());
                httpClient.AddHeader("user-passwd", textBox_passwd.Text.Trim());
                isSuccess = Convert.ToBoolean(httpClient.GetResponse());

            }catch(Exception ex)
            {
                Debug.WriteLine("exception:" + ex.ToString());
            }
            if (isSuccess)
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
            else
                MessageBox.Show("注册失败");
        }


        private void textBox_passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signup_Click(null, null);
            }
        }
    }
}
