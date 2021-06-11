//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Accessibility
{
    public sealed class AXRelatedNode
    {
        /// <summary>
        /// The BackendNodeId of the related DOM node.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendDOMNodeId { get; set; }

        /// <summary>The IDRef value provided, if any.</summary>
        public string? Idref { get; set; }

        /// <summary>
        /// The text alternative of this node in the current context.
        /// </summary>
        public string? Text { get; set; }
    }
}
