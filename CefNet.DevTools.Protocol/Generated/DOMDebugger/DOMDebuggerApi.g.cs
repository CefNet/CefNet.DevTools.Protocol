//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    /// <summary>
    /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
    /// execution will stop on these operations as if there was a regular breakpoint set.
    /// </summary>
    public readonly struct DOMDebuggerApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DOMDebuggerApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Returns event listeners of the given object.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOMDebugger.GetEventListenersResponse> GetEventListenersAsync(
            CefNet.DevTools.Protocol.DOMDebugger.GetEventListenersRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.GetEventListenersRequest, CefNet.DevTools.Protocol.DOMDebugger.GetEventListenersResponse>(
                    "DOMDebugger.getEventListeners", parameters, cancellationToken);
        }

        /// <summary>
        /// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveDOMBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.RemoveDOMBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.RemoveDOMBreakpointRequest>(
                    "DOMDebugger.removeDOMBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// Removes breakpoint on particular DOM event.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveEventListenerBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.RemoveEventListenerBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.RemoveEventListenerBreakpointRequest>(
                    "DOMDebugger.removeEventListenerBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Removes breakpoint on particular native event.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveInstrumentationBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.RemoveInstrumentationBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.RemoveInstrumentationBreakpointRequest>(
                    "DOMDebugger.removeInstrumentationBreakpoint", parameters, cancellationToken);
        }

        /// <summary>Removes breakpoint from XMLHttpRequest.</summary>
        public readonly System.Threading.Tasks.Task RemoveXHRBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.RemoveXHRBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.RemoveXHRBreakpointRequest>(
                    "DOMDebugger.removeXHRBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets breakpoint on particular CSP violations.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBreakOnCSPViolationAsync(
            CefNet.DevTools.Protocol.DOMDebugger.SetBreakOnCSPViolationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.SetBreakOnCSPViolationRequest>(
                    "DOMDebugger.setBreakOnCSPViolation", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets breakpoint on particular operation with DOM.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDOMBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.SetDOMBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.SetDOMBreakpointRequest>(
                    "DOMDebugger.setDOMBreakpoint", parameters, cancellationToken);
        }

        /// <summary>Sets breakpoint on particular DOM event.</summary>
        public readonly System.Threading.Tasks.Task SetEventListenerBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.SetEventListenerBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.SetEventListenerBreakpointRequest>(
                    "DOMDebugger.setEventListenerBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets breakpoint on particular native event.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetInstrumentationBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.SetInstrumentationBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.SetInstrumentationBreakpointRequest>(
                    "DOMDebugger.setInstrumentationBreakpoint", parameters, cancellationToken);
        }

        /// <summary>Sets breakpoint on XMLHttpRequest.</summary>
        public readonly System.Threading.Tasks.Task SetXHRBreakpointAsync(
            CefNet.DevTools.Protocol.DOMDebugger.SetXHRBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMDebugger.SetXHRBreakpointRequest>(
                    "DOMDebugger.setXHRBreakpoint", parameters, cancellationToken);
        }
    }
}
