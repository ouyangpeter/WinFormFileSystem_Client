using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormFileSystem.HttpRequest;
using Filesystem;
using System.Diagnostics;

namespace WinFormFileSystem.Forms
{
    public partial class Form_ListUsers : Form
    {
        public Form_ListUsers()
        {
            InitializeComponent();
        }

        private void Form_ListUsers_Load(object sender, EventArgs e)
        {
            HttpClientBase httpClient = new HttpClientListUsers();

            UserInfoList userInfoList;

            try
            {
                userInfoList = (UserInfoList)httpClient.GetResponse();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("exception" + ex.ToString());
                MessageBox.Show("Exception!");
                return;
            }
            if (userInfoList.UserInfo.Count == 0)
            {

                MessageBox.Show("暂无用户存在");
                this.Close();
            }
            this.listView_UserLists.BeginUpdate();
            foreach (UserInfo userInfo in userInfoList.UserInfo)
            {
                ListViewItem item = listView_UserLists.Items.Add(userInfo.Uid.ToString());
                item.SubItems.Add(userInfo.Uname);
                item.SubItems.Add("******");
                item.SubItems.Add(userInfo.Gid.ToString());
            }
            this.listView_UserLists.EndUpdate();


        }

    }
}
