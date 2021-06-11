//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class FileChooserOpenedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// [Experimental] Id of the frame containing input node.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>[Experimental] Input node id.</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendNodeId { get; set; }

        /// <summary>Input mode.</summary>
        public CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode Mode { get; set; }
    }
}
