﻿// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using DiffbotApi.JsonTypes;
using JsonCSharpClassGenerator;
using Newtonsoft.Json.Linq;
using System;

namespace DiffbotApi
{

    public class Article
    {

        public Article(string json)
            : this(JObject.Parse(json))
        {
        }

        private JObject __jobject;
        public Article(JObject obj)
        {
            this.__jobject = obj;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string[] _tags;
        public string[] Tags
        {
            get
            {
                if (_tags == null)
                    _tags = (string[])JsonClassHelper.ReadArray<string>(JsonClassHelper.GetJToken<JArray>(__jobject, "tags"), JsonClassHelper.ReadString, typeof(string[]));
                return _tags;
            }
        }

        public string Summary
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "summary"));
            }
        }

        public string Author
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "author"));
            }
        }

        public string Text
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "text"));
            }
        }

        public string Html
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "html"));
            }
        }

        public string Title
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "title"));
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Stats _stats;
        public Stats Stats
        {
            get
            {
                if (_stats == null)
                    _stats = JsonClassHelper.ReadStronglyTypedObject<Stats>(JsonClassHelper.GetJToken<JObject>(__jobject, "stats"));
                return _stats;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Medium[] _media;
        public Medium[] Media
        {
            get
            {
                if (_media == null)
                    _media = (Medium[])JsonClassHelper.ReadArray<Medium>(JsonClassHelper.GetJToken<JArray>(__jobject, "media"), JsonClassHelper.ReadStronglyTypedObject<Medium>, typeof(Medium[]));
                return _media;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Comments _comments;
        public Comments Comments
        {
            get
            {
                if (_comments == null)
                    _comments = JsonClassHelper.ReadStronglyTypedObject<Comments>(JsonClassHelper.GetJToken<JObject>(__jobject, "comments"));
                return _comments;
            }
        }

        public string Url
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "url"));
            }
        }

        public string Xpath
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "xpath"));
            }
        }

        public DateTime? Date
        {
            get
            {
                return JsonClassHelper.ReadNullableDate(JsonClassHelper.GetJToken<JValue>(__jobject, "date"));
            }
        }

        public string Error
        {
            get
            {
                return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(__jobject, "error"));
            }
        }

        public int? ErrorCode
        {
            get
            {
                return JsonClassHelper.ReadNullableInteger(JsonClassHelper.GetJToken<JValue>(__jobject, "errorCode"));
            }
        }
    }
}
