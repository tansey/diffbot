// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace DiffbotApi.JsonTypes
{

    public class Comments
    {

        private JObject __jobject;
        public Comments(JObject obj)
        {
            this.__jobject = obj;
        }

        public int Count
        {
            get
            {
                return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(__jobject, "count"));
            }
        }

    }
}
