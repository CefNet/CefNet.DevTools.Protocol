//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Layout viewport position and dimensions.</summary>
    public sealed class LayoutViewport
    {
        /// <summary>
        /// Horizontal offset relative to the document (CSS pixels).
        /// </summary>
        public int PageX { get; set; }

        /// <summary>
        /// Vertical offset relative to the document (CSS pixels).
        /// </summary>
        public int PageY { get; set; }

        /// <summary>
        /// Width (CSS pixels), excludes scrollbar if present.
        /// </summary>
        public int ClientWidth { get; set; }

        /// <summary>
        /// Height (CSS pixels), excludes scrollbar if present.
        /// </summary>
        public int ClientHeight { get; set; }
    }
}
