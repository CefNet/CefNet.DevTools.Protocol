//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    public sealed class GetSnapshotResponse
    {
        /// <summary>
        /// The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.DOMNode> DomNodes { get; set; }

        /// <summary>The nodes in the layout tree.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.LayoutTreeNode> LayoutTreeNodes { get; set; }

        /// <summary>
        /// Whitelisted ComputedStyle properties for each node in the layout tree.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.ComputedStyle> ComputedStyles { get; set; }
    }
}
