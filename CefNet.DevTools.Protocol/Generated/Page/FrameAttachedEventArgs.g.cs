//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class FrameAttachedEventArgs
        : System.EventArgs
    {
        /// <summary>Id of the frame that has been attached.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>Parent frame identifier.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId ParentFrameId { get; set; }

        /// <summary>
        /// JavaScript stack trace of when frame was attached, only set if frame initiated from script.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? Stack { get; set; }
    }
}
