using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filesystem;
namespace WinFormFileSystem.HttpRequest
{
    class HttpClientListUsers : HttpClientBase
    {
        public HttpClientListUsers()
            : base("getUserList")
        {

        }
        public override object GetResponse()
        {
            DoRequest();
            UserInfoList userInfoList = UserInfoList.Parser.ParseFrom(mResponse);
            return userInfoList;
        }
    }
}
