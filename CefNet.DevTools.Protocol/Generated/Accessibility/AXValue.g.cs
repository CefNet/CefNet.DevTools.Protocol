//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Accessibility
{
    /// <summary>A single computed AX property.</summary>
    public sealed class AXValue
    {
        /// <summary>The type of this value.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValueType Type { get; set; }

        /// <summary>The computed value of this property.</summary>
        public object? Value { get; set; }

        /// <summary>
        /// One or more related nodes, if applicable.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXRelatedNode>? RelatedNodes { get; set; }

        /// <summary>
        /// The sources which contributed to the computation of this property.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXValueSource>? Sources { get; set; }
    }
}
