//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class ScreencastFrameEventArgs
        : System.EventArgs
    {
        /// <summary>Base64-encoded compressed image.</summary>
        public byte[] Data { get; set; }

        /// <summary>Screencast frame metadata.</summary>
        public CefNet.DevTools.Protocol.Page.ScreencastFrameMetadata Metadata { get; set; }

        /// <summary>Frame number.</summary>
        public int SessionId { get; set; }
    }
}
