//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Accessibility
{
    /// <summary>[Experimental] </summary>
    public readonly struct AccessibilityApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal AccessibilityApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables the accessibility domain.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Accessibility.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables the accessibility domain which causes `AXNodeId`s to remain consistent between method calls.
        /// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Accessibility.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fetches a particular accessibility node by AXNodeId.
        /// Requires `enable()` to have been called previously.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Accessibility.GetChildAXNodesResponse> GetChildAXNodesAsync(
            CefNet.DevTools.Protocol.Accessibility.GetChildAXNodesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Accessibility.GetChildAXNodesRequest, CefNet.DevTools.Protocol.Accessibility.GetChildAXNodesResponse>(
                    "Accessibility.getChildAXNodes", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fetches the entire accessibility tree for the root Document
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Accessibility.GetFullAXTreeResponse> GetFullAXTreeAsync(
            CefNet.DevTools.Protocol.Accessibility.GetFullAXTreeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Accessibility.GetFullAXTreeRequest, CefNet.DevTools.Protocol.Accessibility.GetFullAXTreeResponse>(
                    "Accessibility.getFullAXTree", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Accessibility.GetPartialAXTreeResponse> GetPartialAXTreeAsync(
            CefNet.DevTools.Protocol.Accessibility.GetPartialAXTreeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Accessibility.GetPartialAXTreeRequest, CefNet.DevTools.Protocol.Accessibility.GetPartialAXTreeResponse>(
                    "Accessibility.getPartialAXTree", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Query a DOM node's accessibility subtree for accessible name and role.
        /// This command computes the name and role for all nodes in the subtree, including those that are
        /// ignored for accessibility, and returns those that mactch the specified name and role. If no DOM
        /// node is specified, or the DOM node does not exist, the command returns an error. If neither
        /// `accessibleName` or `role` is specified, it returns all the accessibility nodes in the subtree.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Accessibility.QueryAXTreeResponse> QueryAXTreeAsync(
            CefNet.DevTools.Protocol.Accessibility.QueryAXTreeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Accessibility.QueryAXTreeRequest, CefNet.DevTools.Protocol.Accessibility.QueryAXTreeResponse>(
                    "Accessibility.queryAXTree", parameters, cancellationToken);
        }
    }
}
