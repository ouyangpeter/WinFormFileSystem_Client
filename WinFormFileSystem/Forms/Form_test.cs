using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Filesystem;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using WinFormFileSystem.HttpRequest;
using WinFormFileSystem;
using WinFormFileSystem.Forms;

namespace WinFormFileSystem.Forms
{
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string strURL = "http://123.57.68.8:8000/api/test";
        //    HttpWebRequest request;
        //    // 创建一个HTTP请求
        //    request = (HttpWebRequest)WebRequest.Create(strURL);
        //    //request.Method="get";
        //    HttpWebResponse response;
        //    response = (HttpWebResponse)request.GetResponse();
        //    Stream s;
        //    s = response.GetResponseStream();
        //    UserInfo userInfo = UserInfo.Parser.ParseFrom(s);
        //    string uname = userInfo.Uname;
        //    Debug.WriteLine(uname);
        //}
        private void button1_Click(object sender, EventArgs e)
        {

            HttpClientBase httpClient;
            if(radioButton_test.Checked)
            {
                string uri = "http://123.57.68.8:8000/api/fileOperation";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("user-uname", "test1234");
                client.DefaultRequestHeaders.Add("user-passwd", "hahaha");
                client.DefaultRequestHeaders.Add("file-commond", "ls");
                client.DefaultRequestHeaders.Add("file-params", "1/2/3");
                HttpResponseMessage response = client.GetAsync(new Uri(uri)).Result;
                Stream body = response.Content.ReadAsStreamAsync().Result;
                UserInfo userInfo = UserInfo.Parser.ParseFrom(body);
                //string uname = userInfo.Uname;
                //Debug.WriteLine(uname);
                DebugWriteAll(userInfo);
            }
            if(radioButton_getUserCounts.Checked)
            {
                httpClient = new HttpClientGetUserCounts();
                string response = Convert.ToUInt64(httpClient.GetResponse()).ToString();
                DebugWrite("Counts: " +response);
            }

            if(radioButton_login.Checked)
            {
                httpClient = new HttpClientLogin();
                string uname = "user1";
                string passwd = "123456";
                httpClient.AddHeader("user-uname", uname);
                httpClient.AddHeader("user-passwd", passwd);
                string response = Convert.ToBoolean(httpClient.GetResponse()).ToString();
                DebugWrite("result: " + response);
            }
           

        }

        private void  DebugWrite(string str)
        {
            textBox1.Text += str +"\r\n";

        }

        private void DebugWriteAll(object obj)
        {
            textBox1.Text = "";
            string str;
            foreach(PropertyInfo p in obj.GetType().GetProperties())
            {
                str = string.Format("{0}->{1}", p.Name, p.GetValue(obj));
                DebugWrite(str);
            }
        }

    }
}
