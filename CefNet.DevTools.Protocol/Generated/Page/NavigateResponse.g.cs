//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class NavigateResponse
    {
        /// <summary>
        /// Frame id that has navigated (or failed to navigate)
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>Loader identifier.</summary>
        public CefNet.DevTools.Protocol.Network.LoaderId? LoaderId { get; set; }

        /// <summary>
        /// User friendly error message, present if and only if navigation has failed.
        /// </summary>
        public string? ErrorText { get; set; }
    }
}
