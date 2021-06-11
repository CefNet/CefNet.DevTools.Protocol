//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IO
{
    public sealed class ReadResponse
    {
        /// <summary>Set if the data is base64-encoded</summary>
        public bool? Base64Encoded { get; set; }

        /// <summary>Data that were read.</summary>
        public string Data { get; set; }

        /// <summary>
        /// Set if the end-of-file condition occurred while reading.
        /// </summary>
        public bool Eof { get; set; }
    }
}
