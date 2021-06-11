//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class SetAttributeValueRequest
    {
        /// <summary>Id of the element to set attribute for.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>Attribute name.</summary>
        public string Name { get; set; }

        /// <summary>Attribute value.</summary>
        public string Value { get; set; }
    }
}
