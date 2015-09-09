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
using System.Threading;


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
            this.Text += "_"+Account.GetUname();
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
                    ListDir(fileName);
                    textBox_curDir.Text = textBox_curDir.Text + fileName + "/";
                    curDir = fileName;
                }
                else
                {
                    MessageBox.Show(jsonHelper.GetErrorMsg());
                }
            }
            else if ("1" == fileType)
            {
                if (DoCommond("readFile", fileName))
                {

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
            else if (commond == "newFile")
            {
                return Commond_newFile(prams);
            }
            else if (commond == "readFile")
            {
                return Commond_readFile(prams);
            }
            else if (commond == "delDir")
            {
                return Commond_delDir(prams);
            }
            else if (commond == "delFile")
            {
                return Commond_delFile(prams);
            }
            else if(commond == "save")
            {
                return Commond_save();
            }
            return false;
        }

        bool Commond_save()
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "save");
            httpClient.AddHeader("file-params", "");
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

        bool Commond_delDir(string dirName)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "delDir");
            httpClient.AddHeader("file-params", dirName);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }
        bool Commond_delFile(string fileName)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "delFile");
            httpClient.AddHeader("file-params", fileName);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
        }

        bool Commond_readFile(string fileName)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "readFile");
            httpClient.AddHeader("file-params", fileName);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            if (!jsonHelper.IsSuccess())
                return jsonHelper.IsSuccess();
            Form_readFile form_readFile = new Form_readFile(fileName, jsonHelper.GetContext());
            form_readFile.ShowDialog();
            return jsonHelper.IsSuccess();
        }

        bool Commond_newFile(string newFileName)
        {
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientFileOperation();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "newFile");
            httpClient.AddHeader("file-params", newFileName);
            httpClient.AddHeader("dir-ls", curDir);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            return jsonHelper.IsSuccess();
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
            if (DoCommond("newDir", newDirName))
            {
                textBox_NewDirName.Text = "";
                ListDir(curDir);
            }
            else
            {
                MessageBox.Show(jsonHelper.GetErrorMsg());
            }
        }

        private void button_NewFile_Click(object sender, EventArgs e)
        {
            string newDirName = textBox_NewFileName.Text.Trim();
            if (newDirName == "")
            {
                MessageBox.Show("文件名字不能为空");
                return;
            }
            if (DoCommond("newFile", newDirName))
            {
                textBox_NewFileName.Text = "";
                ListDir(curDir);
            }
            else
            {
                MessageBox.Show(jsonHelper.GetErrorMsg());
            }
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {
            ListDir(curDir);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string fileType = "";
            try
            {
                fileName = listView_Dir.SelectedItems[0].SubItems[0].Text;
                fileType = listView_Dir.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("没有选中要删除的文件");
                return;
            }

            if (fileType == "0") //文件夹
            {
                if (DoCommond("delDir", fileName))
                {
                    ListDir(curDir);
                }
                else
                {
                    MessageBox.Show(jsonHelper.GetErrorMsg());
                }
            }
            else if (fileType == "1")
            {
                if (DoCommond("delFile", fileName))
                {
                    ListDir(curDir);
                }
                else
                {
                    MessageBox.Show(jsonHelper.GetErrorMsg());
                }
            }

        }

        private void toolStripButton_exit_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(fun => { Application.Run(new Form_Login()); });
            th.Start();
            this.Close();
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            if (DoCommond("save"))
            {
                MessageBox.Show("已存盘");
            }
            else
                MessageBox.Show("存盘失败");
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string fileType = "";
            try
            {
                fileName = listView_Dir.SelectedItems[0].SubItems[0].Text;
                fileType = listView_Dir.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("没有选中要写入的文件");
                return;
            }
            if(textBox_input.Text == "")
            {
                MessageBox.Show("没有输入要写入的字符");
                return;
            }
            if(fileType == "0")
            {
                MessageBox.Show("不能对文件夹写入");
                return;
            }
            string uname = Account.GetUname();
            string passwd = Account.GetPasswd();
            HttpClientBase httpClient = new HttpClientWrite();
            httpClient.AddHeader("user-uname", uname);
            httpClient.AddHeader("user-passwd", passwd);
            httpClient.AddHeader("file-commond", "back");
            httpClient.AddHeader("file-params", fileName);
            httpClient.AddHeader("dir-ls", curDir);
            httpClient.AddHeader("file-input", textBox_input.Text);
            jsonHelper = (JsonHelper)httpClient.GetResponse();
            if(jsonHelper.IsSuccess())
            {
                MessageBox.Show("写入成功");
                textBox_input.Text = "";
            }
            else
            {
                MessageBox.Show(jsonHelper.GetErrorMsg());
            }
        }



    }
}
