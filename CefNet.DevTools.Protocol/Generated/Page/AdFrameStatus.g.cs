//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>
    /// [Experimental] Indicates whether a frame has been identified as an ad and why.
    /// </summary>
    public sealed class AdFrameStatus
    {
        public CefNet.DevTools.Protocol.Page.AdFrameType AdFrameType { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.AdFrameExplanation>? Explanations { get; set; }
    }
}
