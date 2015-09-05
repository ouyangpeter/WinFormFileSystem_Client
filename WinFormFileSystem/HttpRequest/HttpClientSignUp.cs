using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFileSystem.HttpRequest
{
    class HttpClientSignUp:HttpClientBase
    {
        public HttpClientSignUp() : base("signUp") { }
        public override object GetResponse()
        {
            DoRequest();
            JsonHelper jsonHelper = new JsonHelper(mResponse);
            Debug.WriteLine(jsonHelper.GetVal("Result"));
            if (jsonHelper.GetVal("Result").ToLower() == "true")
                return true;
            return false;
        }
    }
}
