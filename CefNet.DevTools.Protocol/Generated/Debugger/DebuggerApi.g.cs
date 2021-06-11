//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Debugger
{
    /// <summary>
    /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
    /// breakpoints, stepping through execution, exploring stack traces, etc.
    /// </summary>
    public readonly struct DebuggerApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DebuggerApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Continues execution until specific location is reached.
        /// </summary>
        public readonly System.Threading.Tasks.Task ContinueToLocationAsync(
            CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequest>(
                    "Debugger.continueToLocation", parameters, cancellationToken);
        }

        /// <summary>Disables debugger for given page.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Debugger.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables debugger for the given page. Clients should not assume that the debugging has been
        /// enabled until the result for this command is received.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.EnableResponse> EnableAsync(
            CefNet.DevTools.Protocol.Debugger.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.EnableRequest, CefNet.DevTools.Protocol.Debugger.EnableResponse>(
                    "Debugger.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Evaluates expression on a given call frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.EvaluateOnCallFrameResponse> EvaluateOnCallFrameAsync(
            CefNet.DevTools.Protocol.Debugger.EvaluateOnCallFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.EvaluateOnCallFrameRequest, CefNet.DevTools.Protocol.Debugger.EvaluateOnCallFrameResponse>(
                    "Debugger.evaluateOnCallFrame", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns possible locations for breakpoint. scriptId in start and end range locations should be
        /// the same.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.GetPossibleBreakpointsResponse> GetPossibleBreakpointsAsync(
            CefNet.DevTools.Protocol.Debugger.GetPossibleBreakpointsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.GetPossibleBreakpointsRequest, CefNet.DevTools.Protocol.Debugger.GetPossibleBreakpointsResponse>(
                    "Debugger.getPossibleBreakpoints", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns source for the script with given id.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.GetScriptSourceResponse> GetScriptSourceAsync(
            CefNet.DevTools.Protocol.Debugger.GetScriptSourceRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.GetScriptSourceRequest, CefNet.DevTools.Protocol.Debugger.GetScriptSourceResponse>(
                    "Debugger.getScriptSource", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns stack trace with given `stackTraceId`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.GetStackTraceResponse> GetStackTraceAsync(
            CefNet.DevTools.Protocol.Debugger.GetStackTraceRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.GetStackTraceRequest, CefNet.DevTools.Protocol.Debugger.GetStackTraceResponse>(
                    "Debugger.getStackTrace", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] This command is deprecated. Use getScriptSource instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.GetWasmBytecodeResponse> GetWasmBytecodeAsync(
            CefNet.DevTools.Protocol.Debugger.GetWasmBytecodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.GetWasmBytecodeRequest, CefNet.DevTools.Protocol.Debugger.GetWasmBytecodeResponse>(
                    "Debugger.getWasmBytecode", parameters, cancellationToken);
        }

        /// <summary>Stops on the next JavaScript statement.</summary>
        public readonly System.Threading.Tasks.Task PauseAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Debugger.pause", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Deprecated] [Experimental] </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task PauseOnAsyncCallAsync(
            CefNet.DevTools.Protocol.Debugger.PauseOnAsyncCallRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.PauseOnAsyncCallRequest>(
                    "Debugger.pauseOnAsyncCall", parameters, cancellationToken);
        }

        /// <summary>Removes JavaScript breakpoint.</summary>
        public readonly System.Threading.Tasks.Task RemoveBreakpointAsync(
            CefNet.DevTools.Protocol.Debugger.RemoveBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.RemoveBreakpointRequest>(
                    "Debugger.removeBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// Restarts particular call frame from the beginning.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.RestartFrameResponse> RestartFrameAsync(
            CefNet.DevTools.Protocol.Debugger.RestartFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.RestartFrameRequest, CefNet.DevTools.Protocol.Debugger.RestartFrameResponse>(
                    "Debugger.restartFrame", parameters, cancellationToken);
        }

        /// <summary>Resumes JavaScript execution.</summary>
        public readonly System.Threading.Tasks.Task ResumeAsync(
            CefNet.DevTools.Protocol.Debugger.ResumeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.ResumeRequest>(
                    "Debugger.resume", parameters, cancellationToken);
        }

        /// <summary>
        /// Searches for given string in script content.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SearchInContentResponse> SearchInContentAsync(
            CefNet.DevTools.Protocol.Debugger.SearchInContentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SearchInContentRequest, CefNet.DevTools.Protocol.Debugger.SearchInContentResponse>(
                    "Debugger.searchInContent", parameters, cancellationToken);
        }

        /// <summary>
        /// Enables or disables async call stacks tracking.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAsyncCallStackDepthAsync(
            CefNet.DevTools.Protocol.Debugger.SetAsyncCallStackDepthRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetAsyncCallStackDepthRequest>(
                    "Debugger.setAsyncCallStackDepth", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted
        /// scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
        /// Positions array contains positions where blackbox state is changed. First interval isn't
        /// blackboxed. Array should be sorted.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBlackboxedRangesAsync(
            CefNet.DevTools.Protocol.Debugger.SetBlackboxedRangesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBlackboxedRangesRequest>(
                    "Debugger.setBlackboxedRanges", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in
        /// scripts with url matching one of the patterns. VM will try to leave blackboxed script by
        /// performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBlackboxPatternsAsync(
            CefNet.DevTools.Protocol.Debugger.SetBlackboxPatternsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBlackboxPatternsRequest>(
                    "Debugger.setBlackboxPatterns", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets JavaScript breakpoint at a given location.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SetBreakpointResponse> SetBreakpointAsync(
            CefNet.DevTools.Protocol.Debugger.SetBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBreakpointRequest, CefNet.DevTools.Protocol.Debugger.SetBreakpointResponse>(
                    "Debugger.setBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this
        /// command is issued, all existing parsed scripts will have breakpoints resolved and returned in
        /// `locations` property. Further matching script parsing will result in subsequent
        /// `breakpointResolved` events issued. This logical breakpoint will survive page reloads.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SetBreakpointByUrlResponse> SetBreakpointByUrlAsync(
            CefNet.DevTools.Protocol.Debugger.SetBreakpointByUrlRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBreakpointByUrlRequest, CefNet.DevTools.Protocol.Debugger.SetBreakpointByUrlResponse>(
                    "Debugger.setBreakpointByUrl", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets JavaScript breakpoint before each call to the given function.
        /// If another function was created from the same source as a given one,
        /// calling it will also trigger the breakpoint.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SetBreakpointOnFunctionCallResponse> SetBreakpointOnFunctionCallAsync(
            CefNet.DevTools.Protocol.Debugger.SetBreakpointOnFunctionCallRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBreakpointOnFunctionCallRequest, CefNet.DevTools.Protocol.Debugger.SetBreakpointOnFunctionCallResponse>(
                    "Debugger.setBreakpointOnFunctionCall", parameters, cancellationToken);
        }

        /// <summary>
        /// Activates / deactivates all breakpoints on the page.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBreakpointsActiveAsync(
            CefNet.DevTools.Protocol.Debugger.SetBreakpointsActiveRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetBreakpointsActiveRequest>(
                    "Debugger.setBreakpointsActive", parameters, cancellationToken);
        }

        /// <summary>Sets instrumentation breakpoint.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointResponse> SetInstrumentationBreakpointAsync(
            CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequest, CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointResponse>(
                    "Debugger.setInstrumentationBreakpoint", parameters, cancellationToken);
        }

        /// <summary>
        /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or
        /// no exceptions. Initial pause on exceptions state is `none`.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPauseOnExceptionsAsync(
            CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequest>(
                    "Debugger.setPauseOnExceptions", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Changes return value in top frame. Available only at return break position.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetReturnValueAsync(
            CefNet.DevTools.Protocol.Debugger.SetReturnValueRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetReturnValueRequest>(
                    "Debugger.setReturnValue", parameters, cancellationToken);
        }

        /// <summary>Edits JavaScript source live.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Debugger.SetScriptSourceResponse> SetScriptSourceAsync(
            CefNet.DevTools.Protocol.Debugger.SetScriptSourceRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetScriptSourceRequest, CefNet.DevTools.Protocol.Debugger.SetScriptSourceResponse>(
                    "Debugger.setScriptSource", parameters, cancellationToken);
        }

        /// <summary>
        /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
        /// </summary>
        public readonly System.Threading.Tasks.Task SetSkipAllPausesAsync(
            CefNet.DevTools.Protocol.Debugger.SetSkipAllPausesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetSkipAllPausesRequest>(
                    "Debugger.setSkipAllPauses", parameters, cancellationToken);
        }

        /// <summary>
        /// Changes value of variable in a callframe. Object-based scopes are not supported and must be
        /// mutated manually.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetVariableValueAsync(
            CefNet.DevTools.Protocol.Debugger.SetVariableValueRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.SetVariableValueRequest>(
                    "Debugger.setVariableValue", parameters, cancellationToken);
        }

        /// <summary>Steps into the function call.</summary>
        public readonly System.Threading.Tasks.Task StepIntoAsync(
            CefNet.DevTools.Protocol.Debugger.StepIntoRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.StepIntoRequest>(
                    "Debugger.stepInto", parameters, cancellationToken);
        }

        /// <summary>Steps out of the function call.</summary>
        public readonly System.Threading.Tasks.Task StepOutAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Debugger.stepOut", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Steps over the statement.</summary>
        public readonly System.Threading.Tasks.Task StepOverAsync(
            CefNet.DevTools.Protocol.Debugger.StepOverRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Debugger.StepOverRequest>(
                    "Debugger.stepOver", parameters, cancellationToken);
        }

        /// <summary>
        /// Fired when breakpoint is resolved to an actual script and location.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Debugger.BreakpointResolvedEventArgs> BreakpointResolved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Debugger.BreakpointResolvedEventArgs>("Debugger.breakpointResolved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Debugger.BreakpointResolvedEventArgs>("Debugger.breakpointResolved", value);
            }
        }

        /// <summary>
        /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Debugger.PausedEventArgs> Paused 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Debugger.PausedEventArgs>("Debugger.paused", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Debugger.PausedEventArgs>("Debugger.paused", value);
            }
        }

        /// <summary>
        /// Fired when the virtual machine resumed execution.
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> Resumed 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Debugger.resumed", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Debugger.resumed", value);
            }
        }

        /// <summary>
        /// Fired when virtual machine fails to parse the script.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Debugger.ScriptFailedToParseEventArgs> ScriptFailedToParse 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Debugger.ScriptFailedToParseEventArgs>("Debugger.scriptFailedToParse", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Debugger.ScriptFailedToParseEventArgs>("Debugger.scriptFailedToParse", value);
            }
        }

        /// <summary>
        /// Fired when virtual machine parses script. This event is also fired for all known and uncollected
        /// scripts upon enabling debugger.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Debugger.ScriptParsedEventArgs> ScriptParsed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Debugger.ScriptParsedEventArgs>("Debugger.scriptParsed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Debugger.ScriptParsedEventArgs>("Debugger.scriptParsed", value);
            }
        }
    }
}
