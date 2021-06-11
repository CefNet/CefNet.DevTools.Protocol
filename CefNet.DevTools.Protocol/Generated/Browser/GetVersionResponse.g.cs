//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class GetVersionResponse
    {
        /// <summary>Protocol version.</summary>
        public string ProtocolVersion { get; set; }

        /// <summary>Product name.</summary>
        public string Product { get; set; }

        /// <summary>Product revision.</summary>
        public string Revision { get; set; }

        /// <summary>User-Agent.</summary>
        public string UserAgent { get; set; }

        /// <summary>V8 version.</summary>
        public string JsVersion { get; set; }
    }
}
