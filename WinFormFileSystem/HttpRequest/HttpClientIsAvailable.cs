using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinFormFileSystem.HttpRequest
{
    class HttpClientIsAvailable:HttpClientBase
    {
        public HttpClientIsAvailable() : base("isAvailable") { }

        public override object GetResponse()
        {
            DoRequest();
            JsonHelper jsonHelper = new JsonHelper(mResponse);
            Debug.WriteLine(jsonHelper.GetVal("Result"));
            return jsonHelper;
        }
    }
}
