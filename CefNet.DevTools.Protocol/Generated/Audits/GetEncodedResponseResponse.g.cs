//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class GetEncodedResponseResponse
    {
        /// <summary>
        /// The encoded body as a base64 string. Omitted if sizeOnly is true.
        /// </summary>
        public byte[]? Body { get; set; }

        /// <summary>Size before re-encoding.</summary>
        public int OriginalSize { get; set; }

        /// <summary>Size after re-encoding.</summary>
        public int EncodedSize { get; set; }
    }
}
