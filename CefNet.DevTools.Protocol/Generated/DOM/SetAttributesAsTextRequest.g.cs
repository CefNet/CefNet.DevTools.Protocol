//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class SetAttributesAsTextRequest
    {
        /// <summary>Id of the element to set attributes for.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>
        /// Text with a number of attributes. Will parse this text using HTML parser.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Attribute name to replace with new attributes derived from text in case text parsed
        /// successfully.
        /// </summary>
        public string? Name { get; set; }
    }
}
