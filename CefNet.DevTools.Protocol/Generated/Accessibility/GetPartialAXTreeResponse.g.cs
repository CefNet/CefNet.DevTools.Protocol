//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Accessibility
{
    public sealed class GetPartialAXTreeResponse
    {
        /// <summary>
        /// The `Accessibility.AXNode` for this DOM node, if it exists, plus its ancestors, siblings and
        /// children, if requested.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXNode> Nodes { get; set; }
    }
}
