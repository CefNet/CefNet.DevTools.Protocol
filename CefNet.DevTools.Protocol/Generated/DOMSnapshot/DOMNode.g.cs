//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>A Node in the DOM tree.</summary>
    public sealed class DOMNode
    {
        /// <summary>`Node`'s nodeType.</summary>
        public int NodeType { get; set; }

        /// <summary>`Node`'s nodeName.</summary>
        public string NodeName { get; set; }

        /// <summary>`Node`'s nodeValue.</summary>
        public string NodeValue { get; set; }

        /// <summary>
        /// Only set for textarea elements, contains the text value.
        /// </summary>
        public string? TextValue { get; set; }

        /// <summary>
        /// Only set for input elements, contains the input's associated text value.
        /// </summary>
        public string? InputValue { get; set; }

        /// <summary>
        /// Only set for radio and checkbox input elements, indicates if the element has been checked
        /// </summary>
        public bool? InputChecked { get; set; }

        /// <summary>
        /// Only set for option elements, indicates if the element has been selected
        /// </summary>
        public bool? OptionSelected { get; set; }

        /// <summary>
        /// `Node`'s id, corresponds to DOM.Node.backendNodeId.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendNodeId { get; set; }

        /// <summary>
        /// The indexes of the node's child nodes in the `domNodes` array returned by `getSnapshot`, if
        /// any.
        /// </summary>
        public System.Collections.Generic.List<int>? ChildNodeIndexes { get; set; }

        /// <summary>Attributes of an `Element` node.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.NameValue>? Attributes { get; set; }

        /// <summary>
        /// Indexes of pseudo elements associated with this node in the `domNodes` array returned by
        /// `getSnapshot`, if any.
        /// </summary>
        public System.Collections.Generic.List<int>? PseudoElementIndexes { get; set; }

        /// <summary>
        /// The index of the node's related layout tree node in the `layoutTreeNodes` array returned by
        /// `getSnapshot`, if any.
        /// </summary>
        public int? LayoutNodeIndex { get; set; }

        /// <summary>
        /// Document URL that `Document` or `FrameOwner` node points to.
        /// </summary>
        public string? DocumentURL { get; set; }

        /// <summary>
        /// Base URL that `Document` or `FrameOwner` node uses for URL completion.
        /// </summary>
        public string? BaseURL { get; set; }

        /// <summary>
        /// Only set for documents, contains the document's content language.
        /// </summary>
        public string? ContentLanguage { get; set; }

        /// <summary>
        /// Only set for documents, contains the document's character set encoding.
        /// </summary>
        public string? DocumentEncoding { get; set; }

        /// <summary>`DocumentType` node's publicId.</summary>
        public string? PublicId { get; set; }

        /// <summary>`DocumentType` node's systemId.</summary>
        public string? SystemId { get; set; }

        /// <summary>
        /// Frame ID for frame owner elements and also for the document node.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId? FrameId { get; set; }

        /// <summary>
        /// The index of a frame owner element's content document in the `domNodes` array returned by
        /// `getSnapshot`, if any.
        /// </summary>
        public int? ContentDocumentIndex { get; set; }

        /// <summary>Type of a pseudo element node.</summary>
        public CefNet.DevTools.Protocol.DOM.PseudoType? PseudoType { get; set; }

        /// <summary>Shadow root type.</summary>
        public CefNet.DevTools.Protocol.DOM.ShadowRootType? ShadowRootType { get; set; }

        /// <summary>
        /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
        /// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
        /// clicked.
        /// </summary>
        public bool? IsClickable { get; set; }

        /// <summary>
        /// Details of the node's event listeners, if any.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMDebugger.EventListener>? EventListeners { get; set; }

        /// <summary>
        /// The selected url for nodes with a srcset attribute.
        /// </summary>
        public string? CurrentSourceURL { get; set; }

        /// <summary>
        /// The url of the script (if any) that generates this node.
        /// </summary>
        public string? OriginURL { get; set; }

        /// <summary>
        /// Scroll offsets, set when this node is a Document.
        /// </summary>
        public double? ScrollOffsetX { get; set; }

        public double? ScrollOffsetY { get; set; }
    }
}
