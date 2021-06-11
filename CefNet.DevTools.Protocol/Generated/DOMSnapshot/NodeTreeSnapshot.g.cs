//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>Table containing nodes.</summary>
    public sealed class NodeTreeSnapshot
    {
        /// <summary>Parent node index.</summary>
        public System.Collections.Generic.List<int>? ParentIndex { get; set; }

        /// <summary>`Node`'s nodeType.</summary>
        public System.Collections.Generic.List<int>? NodeType { get; set; }

        /// <summary>`Node`'s nodeName.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex>? NodeName { get; set; }

        /// <summary>`Node`'s nodeValue.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex>? NodeValue { get; set; }

        /// <summary>
        /// `Node`'s id, corresponds to DOM.Node.backendNodeId.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.BackendNodeId>? BackendNodeId { get; set; }

        /// <summary>
        /// Attributes of an `Element` node. Flatten name, value pairs.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.ArrayOfStrings>? Attributes { get; set; }

        /// <summary>
        /// Only set for textarea elements, contains the text value.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareStringData? TextValue { get; set; }

        /// <summary>
        /// Only set for input elements, contains the input's associated text value.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareStringData? InputValue { get; set; }

        /// <summary>
        /// Only set for radio and checkbox input elements, indicates if the element has been checked
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareBooleanData? InputChecked { get; set; }

        /// <summary>
        /// Only set for option elements, indicates if the element has been selected
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareBooleanData? OptionSelected { get; set; }

        /// <summary>
        /// The index of the document in the list of the snapshot documents.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareIntegerData? ContentDocumentIndex { get; set; }

        /// <summary>Type of a pseudo element node.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareStringData? PseudoType { get; set; }

        /// <summary>
        /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
        /// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
        /// clicked.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareBooleanData? IsClickable { get; set; }

        /// <summary>
        /// The selected url for nodes with a srcset attribute.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareStringData? CurrentSourceURL { get; set; }

        /// <summary>
        /// The url of the script (if any) that generates this node.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareStringData? OriginURL { get; set; }
    }
}
