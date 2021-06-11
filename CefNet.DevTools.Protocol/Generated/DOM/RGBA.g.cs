//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>A structure holding an RGBA color.</summary>
    public sealed class RGBA
    {
        /// <summary>The red component, in the [0-255] range.</summary>
        public int R { get; set; }

        /// <summary>
        /// The green component, in the [0-255] range.
        /// </summary>
        public int G { get; set; }

        /// <summary>
        /// The blue component, in the [0-255] range.
        /// </summary>
        public int B { get; set; }

        /// <summary>
        /// The alpha component, in the [0-1] range (default: 1).
        /// </summary>
        public double? A { get; set; }
    }
}
