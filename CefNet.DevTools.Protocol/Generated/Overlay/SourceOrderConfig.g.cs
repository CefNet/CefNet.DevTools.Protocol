//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>
    /// Configuration data for drawing the source order of an elements children.
    /// </summary>
    public sealed class SourceOrderConfig
    {
        /// <summary>
        /// the color to outline the givent element in.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA ParentOutlineColor { get; set; }

        /// <summary>
        /// the color to outline the child elements in.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA ChildOutlineColor { get; set; }
    }
}
