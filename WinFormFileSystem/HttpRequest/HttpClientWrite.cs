using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFileSystem.HttpRequest
{
    class HttpClientWrite : HttpClientBase
    {
        public HttpClientWrite() : base("write") { }

        public override object GetResponse()
        {
            DoRequest();
            JsonHelper jsonHelper = new JsonHelper(mResponse);
            //Debug.WriteLine(jsonHelper.GetVal("Result"));
            return jsonHelper;
        }
    }
}
