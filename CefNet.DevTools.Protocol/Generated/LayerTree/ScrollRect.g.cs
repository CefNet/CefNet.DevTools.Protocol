//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    /// <summary>
    /// Rectangle where scrolling happens on the main thread.
    /// </summary>
    public sealed class ScrollRect
    {
        /// <summary>Rectangle itself.</summary>
        public CefNet.DevTools.Protocol.DOM.Rect Rect { get; set; }

        /// <summary>
        /// Reason for rectangle to force scrolling on the main thread
        /// </summary>
        public CefNet.DevTools.Protocol.LayerTree.ScrollRectType Type { get; set; }
    }
}
