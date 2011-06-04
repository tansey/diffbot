// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace DiffbotApi.JsonTypes
{

    public class Medium
    {

        private JObject __jobject;
        public Medium(JObject obj)
        {
            this.__jobject = obj;
        }

        public string Link
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "link"));
            }
        }

        public string Type
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "type"));
            }
        }

        public string Primary
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "primary"));
            }
        }

    }
}
