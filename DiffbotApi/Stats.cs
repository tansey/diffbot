// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace DiffbotApi.JsonTypes
{

    public class Stats
    {

        private JObject __jobject;
        public Stats(JObject obj)
        {
            this.__jobject = obj;
        }

        public int FetchTime
        {
            get
            {
                return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(__jobject, "fetchTime"));
            }
        }

        public string Confidence
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "confidence"));
            }
        }

    }
}
