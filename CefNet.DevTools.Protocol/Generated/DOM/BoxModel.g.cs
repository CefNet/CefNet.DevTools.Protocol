//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>Box model.</summary>
    public sealed class BoxModel
    {
        /// <summary>Content box</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Content { get; set; }

        /// <summary>Padding box</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Padding { get; set; }

        /// <summary>Border box</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Border { get; set; }

        /// <summary>Margin box</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Margin { get; set; }

        /// <summary>Node width</summary>
        public int Width { get; set; }

        /// <summary>Node height</summary>
        public int Height { get; set; }

        /// <summary>Shape outside coordinates</summary>
        public CefNet.DevTools.Protocol.DOM.ShapeOutsideInfo? ShapeOutside { get; set; }
    }
}
