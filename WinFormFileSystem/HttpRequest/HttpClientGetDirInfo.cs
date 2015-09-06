using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filesystem;
using System.Diagnostics;
using System.Reflection;

namespace WinFormFileSystem.HttpRequest
{
    class HttpClientGetDirInfo : HttpClientBase
    {
        public HttpClientGetDirInfo() : base("getDirInfo") { }
        public override object GetResponse()
        {
            DoRequest();
            DirInfo dirInfo = DirInfo.Parser.ParseFrom(mResponse);
            foreach (PropertyInfo p in dirInfo.GetType().GetProperties())
            {
                string str = string.Format("{0}->{1}", p.Name, p.GetValue(dirInfo));
                Debug.WriteLine(str);
            }
            return dirInfo;
        }
    }
}
