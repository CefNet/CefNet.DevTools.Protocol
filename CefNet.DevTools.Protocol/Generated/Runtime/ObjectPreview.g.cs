//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// [Experimental] Object containing abbreviated remote object value.
    /// </summary>
    public sealed class ObjectPreview
    {
        /// <summary>Object type.</summary>
        public CefNet.DevTools.Protocol.Runtime.ObjectPreviewType Type { get; set; }

        /// <summary>
        /// Object subtype hint. Specified for `object` type values only.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype? Subtype { get; set; }

        /// <summary>String representation of the object.</summary>
        public string? Description { get; set; }

        /// <summary>
        /// True iff some of the properties or entries of the original object did not fit.
        /// </summary>
        public bool Overflow { get; set; }

        /// <summary>List of the properties.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.PropertyPreview> Properties { get; set; }

        /// <summary>
        /// List of the entries. Specified for `map` and `set` subtype values only.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.EntryPreview>? Entries { get; set; }
    }
}
