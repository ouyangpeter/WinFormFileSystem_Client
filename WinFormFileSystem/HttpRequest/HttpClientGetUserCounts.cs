using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFileSystem.HttpRequest
{
    class HttpClientGetUserCounts : HttpClientBase
    {
        public HttpClientGetUserCounts()
            : base("getUserCounts") { }
        public override object GetResponse()
        {
            DoRequest();
            JsonHelper jsonHelper = new JsonHelper(mResponse);
            return UInt64.Parse(jsonHelper.GetVal("Counts"));
        }
    }
}
