using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFileSystem.HttpRequest
{
    abstract class HttpClientBase
    {
        private const string mUriPre = "http://123.57.68.8:8000/api";
        private string mUri;
        private HttpClient mHttpClient;
        protected Stream mResponse;
        public HttpClientBase(string action)
        {
            mHttpClient = new HttpClient();
            mUri = mUriPre + "/" + action;
        }

        public void AddHeader(string key, string val)
        {
            mHttpClient.DefaultRequestHeaders.Add(key, val);
        }

        protected void DoRequest()
        {
            HttpResponseMessage response = mHttpClient.GetAsync(new Uri(mUri)).Result;
            mResponse = response.Content.ReadAsStreamAsync().Result;
        }

        public abstract Object GetResponse();





    }
}
