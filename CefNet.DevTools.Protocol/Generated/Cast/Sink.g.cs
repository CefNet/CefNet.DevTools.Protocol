//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Cast
{
    public sealed class Sink
    {
        public string Name { get; set; }

        public string Id { get; set; }

        /// <summary>
        /// Text describing the current session. Present only if there is an active
        /// session on the sink.
        /// </summary>
        public string? Session { get; set; }
    }
}
