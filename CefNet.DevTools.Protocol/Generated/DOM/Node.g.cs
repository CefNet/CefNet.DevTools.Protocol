//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>
    /// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes.
    /// DOMNode is a base node mirror type.
    /// </summary>
    public sealed class Node
    {
        /// <summary>
        /// Node identifier that is passed into the rest of the DOM messages as the `nodeId`. Backend
        /// will only push node with given `id` once. It is aware of all requested nodes and will only
        /// fire DOM events for nodes known to the client.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>The id of the parent node if any.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? ParentId { get; set; }

        /// <summary>The BackendNodeId for this node.</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendNodeId { get; set; }

        /// <summary>`Node`'s nodeType.</summary>
        public int NodeType { get; set; }

        /// <summary>`Node`'s nodeName.</summary>
        public string NodeName { get; set; }

        /// <summary>`Node`'s localName.</summary>
        public string LocalName { get; set; }

        /// <summary>`Node`'s nodeValue.</summary>
        public string NodeValue { get; set; }

        /// <summary>Child count for `Container` nodes.</summary>
        public int? ChildNodeCount { get; set; }

        /// <summary>
        /// Child nodes of this node when requested with children.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.Node>? Children { get; set; }

        /// <summary>
        /// Attributes of the `Element` node in the form of flat array `[name1, value1, name2, value2]`.
        /// </summary>
        public System.Collections.Generic.List<string>? Attributes { get; set; }

        /// <summary>
        /// Document URL that `Document` or `FrameOwner` node points to.
        /// </summary>
        public string? DocumentURL { get; set; }

        /// <summary>
        /// Base URL that `Document` or `FrameOwner` node uses for URL completion.
        /// </summary>
        public string? BaseURL { get; set; }

        /// <summary>`DocumentType`'s publicId.</summary>
        public string? PublicId { get; set; }

        /// <summary>`DocumentType`'s systemId.</summary>
        public string? SystemId { get; set; }

        /// <summary>`DocumentType`'s internalSubset.</summary>
        public string? InternalSubset { get; set; }

        /// <summary>
        /// `Document`'s XML version in case of XML documents.
        /// </summary>
        public string? XmlVersion { get; set; }

        /// <summary>`Attr`'s name.</summary>
        public string? Name { get; set; }

        /// <summary>`Attr`'s value.</summary>
        public string? Value { get; set; }

        /// <summary>Pseudo element type for this node.</summary>
        public CefNet.DevTools.Protocol.DOM.PseudoType? PseudoType { get; set; }

        /// <summary>Shadow root type.</summary>
        public CefNet.DevTools.Protocol.DOM.ShadowRootType? ShadowRootType { get; set; }

        /// <summary>Frame ID for frame owner elements.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId? FrameId { get; set; }

        /// <summary>
        /// Content document for frame owner elements.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Node? ContentDocument { get; set; }

        /// <summary>Shadow root list for given element host.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.Node>? ShadowRoots { get; set; }

        /// <summary>
        /// Content document fragment for template elements.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Node? TemplateContent { get; set; }

        /// <summary>
        /// Pseudo elements associated with this node.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.Node>? PseudoElements { get; set; }

        /// <summary>
        /// [Deprecated] Deprecated, as the HTML Imports API has been removed (crbug.com/937746).
        /// This property used to return the imported document for the HTMLImport links.
        /// The property is always undefined now.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.DOM.Node? ImportedDocument { get; set; }

        /// <summary>
        /// Distributed nodes for given insertion point.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.BackendNode>? DistributedNodes { get; set; }

        /// <summary>Whether the node is SVG.</summary>
        public bool? IsSVG { get; set; }

        public CefNet.DevTools.Protocol.DOM.CompatibilityMode? CompatibilityMode { get; set; }
    }
}
