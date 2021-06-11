//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Viewport for capturing screenshot.</summary>
    public sealed class Viewport
    {
        /// <summary>
        /// X offset in device independent pixels (dip).
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y offset in device independent pixels (dip).
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Rectangle width in device independent pixels (dip).
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Rectangle height in device independent pixels (dip).
        /// </summary>
        public double Height { get; set; }

        /// <summary>Page scale factor.</summary>
        public double Scale { get; set; }
    }
}
