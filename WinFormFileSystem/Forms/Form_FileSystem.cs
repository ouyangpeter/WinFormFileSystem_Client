using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormFileSystem.HttpRequest;
using Filesystem;
using System.Diagnostics;


namespace WinFormFileSystem.Forms
{
    public partial class Form_FileSystem : Form
    {
        private JsonHelper jsonHelper;
        public Form_FileSystem()
        {
            InitializeComponent();
        }

        private void Form_FileSystem_Load(object sender, EventArgs e)
        {
            ListDir("root");
            textBox_curDir.Text = "/";
        }

        void ListDir(string dir)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientGetDirInfo();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("dir-ls", dir);
            FlushList((DirInfo)httpClient.GetResponse());
        }

        private void FlushList(DirInfo dirInfo)
        {
            this.listView_Dir.BeginUpdate();
            foreach (FileInfo fileInfo in dirInfo.FileInfo)
            {
                ListViewItem item = listView_Dir.Items.Add(fileInfo.FileName);
                item.SubItems.Add(fileInfo.Type.ToString());
                item.SubItems.Add(fileInfo.Length.ToString());
                item.SubItems.Add(fileInfo.FatherDir);
                item.SubItems.Add(fileInfo.Owner);
                item.SubItems.Add(fileInfo.Group);
                item.SubItems.Add(Convert.ToString(fileInfo.Power, 2));

            }
            this.listView_Dir.EndUpdate();
        }

        private void listView_Dir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileName = listView_Dir.SelectedItems[0].SubItems[0].Text;
            string fileType = listView_Dir.SelectedItems[0].SubItems[1].Text;
            if ("0" == fileType)
            {
                if(DoCommond("cd", fileName))
                {
                    ListDir(fileName);
                    textBox_curDir.Text = textBox_curDir.Text + "/" + fileName;
                }
                else
                {
                    MessageBox.Show(jsonHelper.GetErrorMsg());
                }
            }
        }

        bool DoCommond(string commond, string prams = "")
        {
            if(commond == "cd")
            {
                return Commond_cd(prams);
            }
            return false;
        }

        bool Commond_cd(string dir)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientGetDirInfo();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "cd");
            httpClient.AddHeader("file-params", dir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

    }
}
