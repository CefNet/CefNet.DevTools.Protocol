//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>Document snapshot.</summary>
    public sealed class DocumentSnapshot
    {
        /// <summary>
        /// Document URL that `Document` or `FrameOwner` node points to.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex DocumentURL { get; set; }

        /// <summary>Document title.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex Title { get; set; }

        /// <summary>
        /// Base URL that `Document` or `FrameOwner` node uses for URL completion.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex BaseURL { get; set; }

        /// <summary>
        /// Contains the document's content language.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex ContentLanguage { get; set; }

        /// <summary>
        /// Contains the document's character set encoding.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex EncodingName { get; set; }

        /// <summary>`DocumentType` node's publicId.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex PublicId { get; set; }

        /// <summary>`DocumentType` node's systemId.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex SystemId { get; set; }

        /// <summary>
        /// Frame ID for frame owner elements and also for the document node.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.StringIndex FrameId { get; set; }

        /// <summary>A table with dom nodes.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.NodeTreeSnapshot Nodes { get; set; }

        /// <summary>The nodes in the layout tree.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.LayoutTreeSnapshot Layout { get; set; }

        /// <summary>The post-layout inline text nodes.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.TextBoxSnapshot TextBoxes { get; set; }

        /// <summary>Horizontal scroll offset.</summary>
        public double? ScrollOffsetX { get; set; }

        /// <summary>Vertical scroll offset.</summary>
        public double? ScrollOffsetY { get; set; }

        /// <summary>Document content width.</summary>
        public double? ContentWidth { get; set; }

        /// <summary>Document content height.</summary>
        public double? ContentHeight { get; set; }
    }
}
