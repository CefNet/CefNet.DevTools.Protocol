//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>[Experimental] </summary>
    public sealed class PropertyPreview
    {
        /// <summary>Property name.</summary>
        public string Name { get; set; }

        /// <summary>
        /// Object type. Accessor means that the property itself is an accessor property.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.PropertyPreviewType Type { get; set; }

        /// <summary>User-friendly property value string.</summary>
        public string? Value { get; set; }

        /// <summary>Nested value preview.</summary>
        public CefNet.DevTools.Protocol.Runtime.ObjectPreview? ValuePreview { get; set; }

        /// <summary>
        /// Object subtype hint. Specified for `object` type values only.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype? Subtype { get; set; }
    }
}
