//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>
    /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
    /// that has an `id`. This `id` can be used to get additional information on the Node, resolve it into
    /// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
    /// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
    /// and never sends the same node twice. It is client's responsibility to collect information about
    /// the nodes that were sent to the client.<p>Note that `iframe` owner elements will return
    /// corresponding document elements as their child nodes.</p>
    /// </summary>
    public readonly struct DOMApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DOMApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Experimental] Collects class names for the node with given id and all of it's child nodes.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.CollectClassNamesFromSubtreeResponse> CollectClassNamesFromSubtreeAsync(
            CefNet.DevTools.Protocol.DOM.CollectClassNamesFromSubtreeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.CollectClassNamesFromSubtreeRequest, CefNet.DevTools.Protocol.DOM.CollectClassNamesFromSubtreeResponse>(
                    "DOM.collectClassNamesFromSubtree", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Creates a deep copy of the specified node and places it into the target container before the
        /// given anchor.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.CopyToResponse> CopyToAsync(
            CefNet.DevTools.Protocol.DOM.CopyToRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.CopyToRequest, CefNet.DevTools.Protocol.DOM.CopyToResponse>(
                    "DOM.copyTo", parameters, cancellationToken);
        }

        /// <summary>
        /// Describes node given its id, does not require domain to be enabled. Does not start tracking any
        /// objects, can be used for automation.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.DescribeNodeResponse> DescribeNodeAsync(
            CefNet.DevTools.Protocol.DOM.DescribeNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.DescribeNodeRequest, CefNet.DevTools.Protocol.DOM.DescribeNodeResponse>(
                    "DOM.describeNode", parameters, cancellationToken);
        }

        /// <summary>Disables DOM agent for the given page.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Discards search results from the session with the given id. `getSearchResults` should no longer
        /// be called for that search.
        /// </summary>
        public readonly System.Threading.Tasks.Task DiscardSearchResultsAsync(
            CefNet.DevTools.Protocol.DOM.DiscardSearchResultsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.DiscardSearchResultsRequest>(
                    "DOM.discardSearchResults", parameters, cancellationToken);
        }

        /// <summary>Enables DOM agent for the given page.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Focuses the given element.</summary>
        public readonly System.Threading.Tasks.Task FocusAsync(
            CefNet.DevTools.Protocol.DOM.FocusRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.FocusRequest>(
                    "DOM.focus", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns attributes for the specified node.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetAttributesResponse> GetAttributesAsync(
            CefNet.DevTools.Protocol.DOM.GetAttributesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetAttributesRequest, CefNet.DevTools.Protocol.DOM.GetAttributesResponse>(
                    "DOM.getAttributes", parameters, cancellationToken);
        }

        /// <summary>Returns boxes for the given node.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetBoxModelResponse> GetBoxModelAsync(
            CefNet.DevTools.Protocol.DOM.GetBoxModelRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetBoxModelRequest, CefNet.DevTools.Protocol.DOM.GetBoxModelResponse>(
                    "DOM.getBoxModel", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the container of the given node based on container query conditions.
        /// If containerName is given, it will find the nearest container with a matching name;
        /// otherwise it will find the nearest container regardless of its container name.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetContainerForNodeResponse> GetContainerForNodeAsync(
            CefNet.DevTools.Protocol.DOM.GetContainerForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetContainerForNodeRequest, CefNet.DevTools.Protocol.DOM.GetContainerForNodeResponse>(
                    "DOM.getContainerForNode", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns quads that describe node position on the page. This method
        /// might return multiple quads for inline nodes.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetContentQuadsResponse> GetContentQuadsAsync(
            CefNet.DevTools.Protocol.DOM.GetContentQuadsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetContentQuadsRequest, CefNet.DevTools.Protocol.DOM.GetContentQuadsResponse>(
                    "DOM.getContentQuads", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns the root DOM node (and optionally the subtree) to the caller.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetDocumentResponse> GetDocumentAsync(
            CefNet.DevTools.Protocol.DOM.GetDocumentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetDocumentRequest, CefNet.DevTools.Protocol.DOM.GetDocumentResponse>(
                    "DOM.getDocument", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns file information for the given
        /// File wrapper.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetFileInfoResponse> GetFileInfoAsync(
            CefNet.DevTools.Protocol.DOM.GetFileInfoRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetFileInfoRequest, CefNet.DevTools.Protocol.DOM.GetFileInfoResponse>(
                    "DOM.getFileInfo", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Returns the root DOM node (and optionally the subtree) to the caller.
        /// Deprecated, as it is not designed to work well with the rest of the DOM agent.
        /// Use DOMSnapshot.captureSnapshot instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetFlattenedDocumentResponse> GetFlattenedDocumentAsync(
            CefNet.DevTools.Protocol.DOM.GetFlattenedDocumentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetFlattenedDocumentRequest, CefNet.DevTools.Protocol.DOM.GetFlattenedDocumentResponse>(
                    "DOM.getFlattenedDocument", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns iframe node that owns iframe with the given domain.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetFrameOwnerResponse> GetFrameOwnerAsync(
            CefNet.DevTools.Protocol.DOM.GetFrameOwnerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetFrameOwnerRequest, CefNet.DevTools.Protocol.DOM.GetFrameOwnerResponse>(
                    "DOM.getFrameOwner", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns node id at given location. Depending on whether DOM domain is enabled, nodeId is
        /// either returned or not.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetNodeForLocationResponse> GetNodeForLocationAsync(
            CefNet.DevTools.Protocol.DOM.GetNodeForLocationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetNodeForLocationRequest, CefNet.DevTools.Protocol.DOM.GetNodeForLocationResponse>(
                    "DOM.getNodeForLocation", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Finds nodes with a given computed style in a subtree.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetNodesForSubtreeByStyleResponse> GetNodesForSubtreeByStyleAsync(
            CefNet.DevTools.Protocol.DOM.GetNodesForSubtreeByStyleRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetNodesForSubtreeByStyleRequest, CefNet.DevTools.Protocol.DOM.GetNodesForSubtreeByStyleResponse>(
                    "DOM.getNodesForSubtreeByStyle", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetNodeStackTracesResponse> GetNodeStackTracesAsync(
            CefNet.DevTools.Protocol.DOM.GetNodeStackTracesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetNodeStackTracesRequest, CefNet.DevTools.Protocol.DOM.GetNodeStackTracesResponse>(
                    "DOM.getNodeStackTraces", parameters, cancellationToken);
        }

        /// <summary>Returns node's HTML markup.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetOuterHTMLResponse> GetOuterHTMLAsync(
            CefNet.DevTools.Protocol.DOM.GetOuterHTMLRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetOuterHTMLRequest, CefNet.DevTools.Protocol.DOM.GetOuterHTMLResponse>(
                    "DOM.getOuterHTML", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the id of the nearest ancestor that is a relayout boundary.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetRelayoutBoundaryResponse> GetRelayoutBoundaryAsync(
            CefNet.DevTools.Protocol.DOM.GetRelayoutBoundaryRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetRelayoutBoundaryRequest, CefNet.DevTools.Protocol.DOM.GetRelayoutBoundaryResponse>(
                    "DOM.getRelayoutBoundary", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns search results from given `fromIndex` to given `toIndex` from the search with the given
        /// identifier.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.GetSearchResultsResponse> GetSearchResultsAsync(
            CefNet.DevTools.Protocol.DOM.GetSearchResultsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.GetSearchResultsRequest, CefNet.DevTools.Protocol.DOM.GetSearchResultsResponse>(
                    "DOM.getSearchResults", parameters, cancellationToken);
        }

        /// <summary>Hides any highlight.</summary>
        public readonly System.Threading.Tasks.Task HideHighlightAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.hideHighlight", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Highlights DOM node.</summary>
        public readonly System.Threading.Tasks.Task HighlightNodeAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.highlightNode", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Highlights given rectangle.</summary>
        public readonly System.Threading.Tasks.Task HighlightRectAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.highlightRect", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Marks last undoable state.
        /// </summary>
        public readonly System.Threading.Tasks.Task MarkUndoableStateAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.markUndoableState", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Moves node into the new container, places it before the given anchor.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.MoveToResponse> MoveToAsync(
            CefNet.DevTools.Protocol.DOM.MoveToRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.MoveToRequest, CefNet.DevTools.Protocol.DOM.MoveToResponse>(
                    "DOM.moveTo", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Searches for a given string in the DOM tree. Use `getSearchResults` to access search results or
        /// `cancelSearch` to end this search session.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.PerformSearchResponse> PerformSearchAsync(
            CefNet.DevTools.Protocol.DOM.PerformSearchRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.PerformSearchRequest, CefNet.DevTools.Protocol.DOM.PerformSearchResponse>(
                    "DOM.performSearch", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Requests that the node is sent to the caller given its path. // FIXME, use XPath
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.PushNodeByPathToFrontendResponse> PushNodeByPathToFrontendAsync(
            CefNet.DevTools.Protocol.DOM.PushNodeByPathToFrontendRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.PushNodeByPathToFrontendRequest, CefNet.DevTools.Protocol.DOM.PushNodeByPathToFrontendResponse>(
                    "DOM.pushNodeByPathToFrontend", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Requests that a batch of nodes is sent to the caller given their backend node ids.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.PushNodesByBackendIdsToFrontendResponse> PushNodesByBackendIdsToFrontendAsync(
            CefNet.DevTools.Protocol.DOM.PushNodesByBackendIdsToFrontendRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.PushNodesByBackendIdsToFrontendRequest, CefNet.DevTools.Protocol.DOM.PushNodesByBackendIdsToFrontendResponse>(
                    "DOM.pushNodesByBackendIdsToFrontend", parameters, cancellationToken);
        }

        /// <summary>
        /// Executes `querySelector` on a given node.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.QuerySelectorResponse> QuerySelectorAsync(
            CefNet.DevTools.Protocol.DOM.QuerySelectorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.QuerySelectorRequest, CefNet.DevTools.Protocol.DOM.QuerySelectorResponse>(
                    "DOM.querySelector", parameters, cancellationToken);
        }

        /// <summary>
        /// Executes `querySelectorAll` on a given node.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.QuerySelectorAllResponse> QuerySelectorAllAsync(
            CefNet.DevTools.Protocol.DOM.QuerySelectorAllRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.QuerySelectorAllRequest, CefNet.DevTools.Protocol.DOM.QuerySelectorAllResponse>(
                    "DOM.querySelectorAll", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Re-does the last undone action.
        /// </summary>
        public readonly System.Threading.Tasks.Task RedoAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.redo", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Removes attribute with given name from an element with given id.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveAttributeAsync(
            CefNet.DevTools.Protocol.DOM.RemoveAttributeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.RemoveAttributeRequest>(
                    "DOM.removeAttribute", parameters, cancellationToken);
        }

        /// <summary>Removes node with given id.</summary>
        public readonly System.Threading.Tasks.Task RemoveNodeAsync(
            CefNet.DevTools.Protocol.DOM.RemoveNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.RemoveNodeRequest>(
                    "DOM.removeNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that children of the node with given id are returned to the caller in form of
        /// `setChildNodes` events where not only immediate children are retrieved, but all children down to
        /// the specified depth.
        /// </summary>
        public readonly System.Threading.Tasks.Task RequestChildNodesAsync(
            CefNet.DevTools.Protocol.DOM.RequestChildNodesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.RequestChildNodesRequest>(
                    "DOM.requestChildNodes", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that the node is sent to the caller given the JavaScript node object reference. All
        /// nodes that form the path from the node to the root are also sent to the client as a series of
        /// `setChildNodes` notifications.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.RequestNodeResponse> RequestNodeAsync(
            CefNet.DevTools.Protocol.DOM.RequestNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.RequestNodeRequest, CefNet.DevTools.Protocol.DOM.RequestNodeResponse>(
                    "DOM.requestNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Resolves the JavaScript node object for a given NodeId or BackendNodeId.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.ResolveNodeResponse> ResolveNodeAsync(
            CefNet.DevTools.Protocol.DOM.ResolveNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.ResolveNodeRequest, CefNet.DevTools.Protocol.DOM.ResolveNodeResponse>(
                    "DOM.resolveNode", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Scrolls the specified rect of the given node into view if not already visible.
        /// Note: exactly one between nodeId, backendNodeId and objectId should be passed
        /// to identify the node.
        /// </summary>
        public readonly System.Threading.Tasks.Task ScrollIntoViewIfNeededAsync(
            CefNet.DevTools.Protocol.DOM.ScrollIntoViewIfNeededRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.ScrollIntoViewIfNeededRequest>(
                    "DOM.scrollIntoViewIfNeeded", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets attributes on element with given id. This method is useful when user edits some existing
        /// attribute value and types in several attribute name/value pairs.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAttributesAsTextAsync(
            CefNet.DevTools.Protocol.DOM.SetAttributesAsTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetAttributesAsTextRequest>(
                    "DOM.setAttributesAsText", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets attribute for an element with given id.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAttributeValueAsync(
            CefNet.DevTools.Protocol.DOM.SetAttributeValueRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetAttributeValueRequest>(
                    "DOM.setAttributeValue", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets files for the given file input element.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetFileInputFilesAsync(
            CefNet.DevTools.Protocol.DOM.SetFileInputFilesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetFileInputFilesRequest>(
                    "DOM.setFileInputFiles", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enables console to refer to the node with given id via $x (see Command Line API for more details
        /// $x functions).
        /// </summary>
        public readonly System.Threading.Tasks.Task SetInspectedNodeAsync(
            CefNet.DevTools.Protocol.DOM.SetInspectedNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetInspectedNodeRequest>(
                    "DOM.setInspectedNode", parameters, cancellationToken);
        }

        /// <summary>Sets node name for a node with given id.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOM.SetNodeNameResponse> SetNodeNameAsync(
            CefNet.DevTools.Protocol.DOM.SetNodeNameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetNodeNameRequest, CefNet.DevTools.Protocol.DOM.SetNodeNameResponse>(
                    "DOM.setNodeName", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetNodeStackTracesEnabledAsync(
            CefNet.DevTools.Protocol.DOM.SetNodeStackTracesEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetNodeStackTracesEnabledRequest>(
                    "DOM.setNodeStackTracesEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets node value for a node with given id.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetNodeValueAsync(
            CefNet.DevTools.Protocol.DOM.SetNodeValueRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetNodeValueRequest>(
                    "DOM.setNodeValue", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets node HTML markup, returns new node id.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetOuterHTMLAsync(
            CefNet.DevTools.Protocol.DOM.SetOuterHTMLRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOM.SetOuterHTMLRequest>(
                    "DOM.setOuterHTML", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Undoes the last performed action.
        /// </summary>
        public readonly System.Threading.Tasks.Task UndoAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOM.undo", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Fired when `Element`'s attribute is modified.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.AttributeModifiedEventArgs> AttributeModified 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.AttributeModifiedEventArgs>("DOM.attributeModified", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.AttributeModifiedEventArgs>("DOM.attributeModified", value);
            }
        }

        /// <summary>
        /// Fired when `Element`'s attribute is removed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.AttributeRemovedEventArgs> AttributeRemoved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.AttributeRemovedEventArgs>("DOM.attributeRemoved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.AttributeRemovedEventArgs>("DOM.attributeRemoved", value);
            }
        }

        /// <summary>
        /// Mirrors `DOMCharacterDataModified` event.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.CharacterDataModifiedEventArgs> CharacterDataModified 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.CharacterDataModifiedEventArgs>("DOM.characterDataModified", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.CharacterDataModifiedEventArgs>("DOM.characterDataModified", value);
            }
        }

        /// <summary>
        /// Fired when `Container`'s child node count has changed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeCountUpdatedEventArgs> ChildNodeCountUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeCountUpdatedEventArgs>("DOM.childNodeCountUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeCountUpdatedEventArgs>("DOM.childNodeCountUpdated", value);
            }
        }

        /// <summary>Mirrors `DOMNodeInserted` event.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeInsertedEventArgs> ChildNodeInserted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeInsertedEventArgs>("DOM.childNodeInserted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeInsertedEventArgs>("DOM.childNodeInserted", value);
            }
        }

        /// <summary>Mirrors `DOMNodeRemoved` event.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeRemovedEventArgs> ChildNodeRemoved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeRemovedEventArgs>("DOM.childNodeRemoved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.ChildNodeRemovedEventArgs>("DOM.childNodeRemoved", value);
            }
        }

        /// <summary>
        /// [Experimental] Called when distribution is changed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.DistributedNodesUpdatedEventArgs> DistributedNodesUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.DistributedNodesUpdatedEventArgs>("DOM.distributedNodesUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.DistributedNodesUpdatedEventArgs>("DOM.distributedNodesUpdated", value);
            }
        }

        /// <summary>
        /// Fired when `Document` has been totally updated. Node ids are no longer valid.
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> DocumentUpdated 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("DOM.documentUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("DOM.documentUpdated", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when `Element`'s inline style is modified via a CSS property modification.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.InlineStyleInvalidatedEventArgs> InlineStyleInvalidated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.InlineStyleInvalidatedEventArgs>("DOM.inlineStyleInvalidated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.InlineStyleInvalidatedEventArgs>("DOM.inlineStyleInvalidated", value);
            }
        }

        /// <summary>
        /// [Experimental] Called when a pseudo element is added to an element.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementAddedEventArgs> PseudoElementAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementAddedEventArgs>("DOM.pseudoElementAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementAddedEventArgs>("DOM.pseudoElementAdded", value);
            }
        }

        /// <summary>
        /// [Experimental] Called when a pseudo element is removed from an element.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementRemovedEventArgs> PseudoElementRemoved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementRemovedEventArgs>("DOM.pseudoElementRemoved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.PseudoElementRemovedEventArgs>("DOM.pseudoElementRemoved", value);
            }
        }

        /// <summary>
        /// Fired when backend wants to provide client with the missing DOM structure. This happens upon
        /// most of the calls requesting node ids.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.SetChildNodesEventArgs> SetChildNodes 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.SetChildNodesEventArgs>("DOM.setChildNodes", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.SetChildNodesEventArgs>("DOM.setChildNodes", value);
            }
        }

        /// <summary>
        /// [Experimental] Called when shadow root is popped from the element.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPoppedEventArgs> ShadowRootPopped 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPoppedEventArgs>("DOM.shadowRootPopped", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPoppedEventArgs>("DOM.shadowRootPopped", value);
            }
        }

        /// <summary>
        /// [Experimental] Called when shadow root is pushed into the element.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPushedEventArgs> ShadowRootPushed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPushedEventArgs>("DOM.shadowRootPushed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOM.ShadowRootPushedEventArgs>("DOM.shadowRootPushed", value);
            }
        }
    }
}
