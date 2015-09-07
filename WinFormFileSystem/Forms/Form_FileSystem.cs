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
        private string curDir;
        public Form_FileSystem()
        {
            InitializeComponent();
            curDir = "root";
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
            listView_Dir.Items.Clear();
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
                if (DoCommond("cd", fileName))
                {
                    //TODO
                    //                    Debug.WriteLine("cd true");
                    ListDir(fileName);
                    textBox_curDir.Text = textBox_curDir.Text + fileName + "/";
                    curDir = fileName;
                }
                else
                {
                    MessageBox.Show(jsonHelper.GetErrorMsg());
                }
            }
        }

        bool DoCommond(string commond, string prams = "")
        {
            if (commond == "cd")
            {
                return Commond_cd(prams);
            }
            else if (commond == "back")
            {
                return Commond_back();
            }
            else if (commond == "newDir")
            {
                return Commond_newDir(prams);
            }
            return false;
        }

        bool Commond_newDir(string newDirName)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "newDir");
            httpClient.AddHeader("file-params", newDirName);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

        bool Commond_cd(string dir)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "cd");
            httpClient.AddHeader("file-params", dir);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

        bool Commond_back()
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "back");
            httpClient.AddHeader("file-params", "");
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (textBox_curDir.Text == "/")
            {
                MessageBox.Show("已是根目录");
                return;
            }
            if (DoCommond("back"))
            {
                string origin = textBox_curDir.Text.Trim();
                string[] split = origin.Split(new string[] { "/", "/" }, StringSplitOptions.RemoveEmptyEntries);
                Debug.WriteLine("cnt:" + split.Length);
                string newstr = "/";
                for (int i = 0; i < split.Length - 1; ++i)
                    newstr = newstr + split[i] + "/";
                Debug.WriteLine("newstr:" + newstr);
                textBox_curDir.Text = newstr;

                if (split.Length == 1)
                    curDir = "root";
                else
                    curDir = split[split.Length - 2];
                ListDir(curDir);
            }
            else
                MessageBox.Show(jsonHelper.GetErrorMsg());
        }

        private void toolStripMenuItem_NewDir_Click(object sender, EventArgs e)
        {

        }

        private void button_NewDir_Click(object sender, EventArgs e)
        {
            string newDirName = textBox_NewDirName.Text.Trim();
            if (newDirName == "")
            {
                MessageBox.Show("文件夹名字不能为空");
                return;
            }
            if(DoCommond("newDir", newDirName))
            {
                textBox_NewDirName.Text = "";
                ListDir(curDir);
            }
            else
            {
                MessageBox.Show(jsonHelper.GetErrorMsg());
            }
        }


    }
}
