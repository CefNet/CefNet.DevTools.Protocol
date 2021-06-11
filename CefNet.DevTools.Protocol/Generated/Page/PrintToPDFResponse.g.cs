//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class PrintToPDFResponse
    {
        /// <summary>
        /// Base64-encoded pdf data. Empty if |returnAsStream| is specified.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// [Experimental] A handle of the stream that holds resulting PDF data.
        /// </summary>
        public CefNet.DevTools.Protocol.IO.StreamHandle? Stream { get; set; }
    }
}
