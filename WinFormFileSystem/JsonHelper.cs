using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
namespace WinFormFileSystem
{
    class JsonHelper
    {
        private JObject jsonObj;

        public JsonHelper(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            Debug.WriteLine(str);
            jsonObj = JObject.Parse(str);
        }

        public string GetVal(string key)
        {
            Debug.WriteLine(jsonObj.ToString());
            return jsonObj[key].ToString();
        }

        public bool IsSuccess()
        {
            if (GetVal("Result").ToLower() == "true")
                return true;
            return false;
        }

        public string GetErrorMsg()
        {
            return GetVal("ErrorMsg");
        }
        public string GetContext()
        {
            return GetVal("Context");
        }
         

    }
}
