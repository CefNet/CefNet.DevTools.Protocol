//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Accessibility
{
    /// <summary>
    /// A single source for a computed AX property.
    /// </summary>
    public sealed class AXValueSource
    {
        /// <summary>What type of source this is.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValueSourceType Type { get; set; }

        /// <summary>The value of this property source.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? Value { get; set; }

        /// <summary>
        /// The name of the relevant attribute, if any.
        /// </summary>
        public string? Attribute { get; set; }

        /// <summary>
        /// The value of the relevant attribute, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? AttributeValue { get; set; }

        /// <summary>
        /// Whether this source is superseded by a higher priority source.
        /// </summary>
        public bool? Superseded { get; set; }

        /// <summary>
        /// The native markup source for this value, e.g. a <label> element.
        /// </summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType? NativeSource { get; set; }

        /// <summary>
        /// The value, such as a node or node list, of the native source.
        /// </summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? NativeSourceValue { get; set; }

        /// <summary>
        /// Whether the value for this property is invalid.
        /// </summary>
        public bool? Invalid { get; set; }

        /// <summary>
        /// Reason for the value being invalid, if it is.
        /// </summary>
        public string? InvalidReason { get; set; }
    }
}
