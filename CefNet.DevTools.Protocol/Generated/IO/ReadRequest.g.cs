//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IO
{
    public sealed class ReadRequest
    {
        /// <summary>Handle of the stream to read.</summary>
        public CefNet.DevTools.Protocol.IO.StreamHandle Handle { get; set; }

        /// <summary>
        /// Seek to the specified offset before reading (if not specificed, proceed with offset
        /// following the last read). Some types of streams may only support sequential reads.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Maximum number of bytes to read (left upon the agent discretion if not specified).
        /// </summary>
        public int? Size { get; set; }
    }
}
