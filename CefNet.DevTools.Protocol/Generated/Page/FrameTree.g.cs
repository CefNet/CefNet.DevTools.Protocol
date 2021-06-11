//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Information about the Frame hierarchy.</summary>
    public sealed class FrameTree
    {
        /// <summary>Frame information for this tree item.</summary>
        public CefNet.DevTools.Protocol.Page.Frame Frame { get; set; }

        /// <summary>Child frames.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.FrameTree>? ChildFrames { get; set; }
    }
}
