//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>CSS Shape Outside details.</summary>
    public sealed class ShapeOutsideInfo
    {
        /// <summary>Shape bounds</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Bounds { get; set; }

        /// <summary>Shape coordinate details</summary>
        public System.Collections.Generic.List<object> Shape { get; set; }

        /// <summary>Margin shape bounds</summary>
        public System.Collections.Generic.List<object> MarginShape { get; set; }
    }
}
