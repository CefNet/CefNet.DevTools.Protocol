//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>
    /// [Experimental] This domain provides various functionality related to drawing atop the inspected page.
    /// </summary>
    public readonly struct OverlayApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal OverlayApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables domain notifications.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Overlay.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables domain notifications.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Overlay.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>For Persistent Grid testing.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Overlay.GetGridHighlightObjectsForTestResponse> GetGridHighlightObjectsForTestAsync(
            CefNet.DevTools.Protocol.Overlay.GetGridHighlightObjectsForTestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.GetGridHighlightObjectsForTestRequest, CefNet.DevTools.Protocol.Overlay.GetGridHighlightObjectsForTestResponse>(
                    "Overlay.getGridHighlightObjectsForTest", parameters, cancellationToken);
        }

        /// <summary>For testing.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Overlay.GetHighlightObjectForTestResponse> GetHighlightObjectForTestAsync(
            CefNet.DevTools.Protocol.Overlay.GetHighlightObjectForTestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.GetHighlightObjectForTestRequest, CefNet.DevTools.Protocol.Overlay.GetHighlightObjectForTestResponse>(
                    "Overlay.getHighlightObjectForTest", parameters, cancellationToken);
        }

        /// <summary>For Source Order Viewer testing.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Overlay.GetSourceOrderHighlightObjectForTestResponse> GetSourceOrderHighlightObjectForTestAsync(
            CefNet.DevTools.Protocol.Overlay.GetSourceOrderHighlightObjectForTestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.GetSourceOrderHighlightObjectForTestRequest, CefNet.DevTools.Protocol.Overlay.GetSourceOrderHighlightObjectForTestResponse>(
                    "Overlay.getSourceOrderHighlightObjectForTest", parameters, cancellationToken);
        }

        /// <summary>Hides any highlight.</summary>
        public readonly System.Threading.Tasks.Task HideHighlightAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Overlay.hideHighlight", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Highlights owner element of the frame with given id.
        /// Deprecated: Doesn't work reliablity and cannot be fixed due to process
        /// separatation (the owner node might be in a different process). Determine
        /// the owner node in the client and use highlightNode.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task HighlightFrameAsync(
            CefNet.DevTools.Protocol.Overlay.HighlightFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.HighlightFrameRequest>(
                    "Overlay.highlightFrame", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or
        /// objectId must be specified.
        /// </summary>
        public readonly System.Threading.Tasks.Task HighlightNodeAsync(
            CefNet.DevTools.Protocol.Overlay.HighlightNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.HighlightNodeRequest>(
                    "Overlay.highlightNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public readonly System.Threading.Tasks.Task HighlightQuadAsync(
            CefNet.DevTools.Protocol.Overlay.HighlightQuadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.HighlightQuadRequest>(
                    "Overlay.highlightQuad", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
        /// </summary>
        public readonly System.Threading.Tasks.Task HighlightRectAsync(
            CefNet.DevTools.Protocol.Overlay.HighlightRectRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.HighlightRectRequest>(
                    "Overlay.highlightRect", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlights the source order of the children of the DOM node with given id or with the given
        /// JavaScript object wrapper. Either nodeId or objectId must be specified.
        /// </summary>
        public readonly System.Threading.Tasks.Task HighlightSourceOrderAsync(
            CefNet.DevTools.Protocol.Overlay.HighlightSourceOrderRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.HighlightSourceOrderRequest>(
                    "Overlay.highlightSourceOrder", parameters, cancellationToken);
        }

        /// <summary>
        /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
        /// Backend then generates 'inspectNodeRequested' event upon element selection.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetInspectModeAsync(
            CefNet.DevTools.Protocol.Overlay.SetInspectModeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetInspectModeRequest>(
                    "Overlay.setInspectMode", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetPausedInDebuggerMessageAsync(
            CefNet.DevTools.Protocol.Overlay.SetPausedInDebuggerMessageRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetPausedInDebuggerMessageRequest>(
                    "Overlay.setPausedInDebuggerMessage", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlights owner element of all frames detected to be ads.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowAdHighlightsAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowAdHighlightsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowAdHighlightsRequest>(
                    "Overlay.setShowAdHighlights", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetShowContainerQueryOverlaysAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowContainerQueryOverlaysRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowContainerQueryOverlaysRequest>(
                    "Overlay.setShowContainerQueryOverlays", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows debug borders on layers
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowDebugBordersAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowDebugBordersRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowDebugBordersRequest>(
                    "Overlay.setShowDebugBorders", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetShowFlexOverlaysAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowFlexOverlaysRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowFlexOverlaysRequest>(
                    "Overlay.setShowFlexOverlays", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows the FPS counter
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowFPSCounterAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowFPSCounterRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowFPSCounterRequest>(
                    "Overlay.setShowFPSCounter", parameters, cancellationToken);
        }

        /// <summary>
        /// Highlight multiple elements with the CSS Grid overlay.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowGridOverlaysAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowGridOverlaysRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowGridOverlaysRequest>(
                    "Overlay.setShowGridOverlays", parameters, cancellationToken);
        }

        /// <summary>Add a dual screen device hinge</summary>
        public readonly System.Threading.Tasks.Task SetShowHingeAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowHingeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowHingeRequest>(
                    "Overlay.setShowHinge", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows hit-test borders on layers
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowHitTestBordersAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowHitTestBordersRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowHitTestBordersRequest>(
                    "Overlay.setShowHitTestBorders", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows layout shift regions
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowLayoutShiftRegionsAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowLayoutShiftRegionsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowLayoutShiftRegionsRequest>(
                    "Overlay.setShowLayoutShiftRegions", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows paint rectangles
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowPaintRectsAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowPaintRectsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowPaintRectsRequest>(
                    "Overlay.setShowPaintRects", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests that backend shows scroll bottleneck rects
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowScrollBottleneckRectsAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowScrollBottleneckRectsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowScrollBottleneckRectsRequest>(
                    "Overlay.setShowScrollBottleneckRects", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetShowScrollSnapOverlaysAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowScrollSnapOverlaysRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowScrollSnapOverlaysRequest>(
                    "Overlay.setShowScrollSnapOverlays", parameters, cancellationToken);
        }

        /// <summary>
        /// Paints viewport size upon main frame resize.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowViewportSizeOnResizeAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowViewportSizeOnResizeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowViewportSizeOnResizeRequest>(
                    "Overlay.setShowViewportSizeOnResize", parameters, cancellationToken);
        }

        /// <summary>
        /// Request that backend shows an overlay with web vital metrics.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetShowWebVitalsAsync(
            CefNet.DevTools.Protocol.Overlay.SetShowWebVitalsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Overlay.SetShowWebVitalsRequest>(
                    "Overlay.setShowWebVitals", parameters, cancellationToken);
        }

        /// <summary>
        /// Fired when user cancels the inspect mode.
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> InspectModeCanceled 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Overlay.inspectModeCanceled", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Overlay.inspectModeCanceled", value);
            }
        }

        /// <summary>
        /// Fired when the node should be inspected. This happens after call to `setInspectMode` or when
        /// user manually inspects an element.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Overlay.InspectNodeRequestedEventArgs> InspectNodeRequested 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Overlay.InspectNodeRequestedEventArgs>("Overlay.inspectNodeRequested", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Overlay.InspectNodeRequestedEventArgs>("Overlay.inspectNodeRequested", value);
            }
        }

        /// <summary>
        /// Fired when the node should be highlighted. This happens after call to `setInspectMode`.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Overlay.NodeHighlightRequestedEventArgs> NodeHighlightRequested 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Overlay.NodeHighlightRequestedEventArgs>("Overlay.nodeHighlightRequested", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Overlay.NodeHighlightRequestedEventArgs>("Overlay.nodeHighlightRequested", value);
            }
        }

        /// <summary>
        /// Fired when user asks to capture screenshot of some area on the page.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Overlay.ScreenshotRequestedEventArgs> ScreenshotRequested 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Overlay.ScreenshotRequestedEventArgs>("Overlay.screenshotRequested", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Overlay.ScreenshotRequestedEventArgs>("Overlay.screenshotRequested", value);
            }
        }
    }
}
