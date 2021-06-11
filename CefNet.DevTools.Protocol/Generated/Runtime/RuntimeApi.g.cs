//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
    /// Evaluation results are returned as mirror object that expose object type, string representation
    /// and unique identifier that can be used for further object reference. Original objects are
    /// maintained in memory unless they are either explicitly released or are released along with the
    /// other objects in their object group.
    /// </summary>
    public readonly struct RuntimeApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal RuntimeApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Experimental] If executionContextId is empty, adds binding with the given name on the
        /// global objects of all inspected contexts, including those created later,
        /// bindings survive reloads.
        /// Binding function takes exactly one argument, this argument should be string,
        /// in case of any other input, function throws an exception.
        /// Each binding function call produces Runtime.bindingCalled notification.
        /// </summary>
        public readonly System.Threading.Tasks.Task AddBindingAsync(
            CefNet.DevTools.Protocol.Runtime.AddBindingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.AddBindingRequest>(
                    "Runtime.addBinding", parameters, cancellationToken);
        }

        /// <summary>
        /// Add handler to promise with given promise object id.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.AwaitPromiseResponse> AwaitPromiseAsync(
            CefNet.DevTools.Protocol.Runtime.AwaitPromiseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.AwaitPromiseRequest, CefNet.DevTools.Protocol.Runtime.AwaitPromiseResponse>(
                    "Runtime.awaitPromise", parameters, cancellationToken);
        }

        /// <summary>
        /// Calls function with given declaration on the given object. Object group of the result is
        /// inherited from the target object.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.CallFunctionOnResponse> CallFunctionOnAsync(
            CefNet.DevTools.Protocol.Runtime.CallFunctionOnRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.CallFunctionOnRequest, CefNet.DevTools.Protocol.Runtime.CallFunctionOnResponse>(
                    "Runtime.callFunctionOn", parameters, cancellationToken);
        }

        /// <summary>Compiles expression.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.CompileScriptResponse> CompileScriptAsync(
            CefNet.DevTools.Protocol.Runtime.CompileScriptRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.CompileScriptRequest, CefNet.DevTools.Protocol.Runtime.CompileScriptResponse>(
                    "Runtime.compileScript", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables reporting of execution contexts creation.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Runtime.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Discards collected exceptions and console API calls.
        /// </summary>
        public readonly System.Threading.Tasks.Task DiscardConsoleEntriesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Runtime.discardConsoleEntries", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables reporting of execution contexts creation by means of `executionContextCreated` event.
        /// When the reporting gets enabled the event will be sent immediately for each existing execution
        /// context.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Runtime.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Evaluates expression on global object.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.EvaluateResponse> EvaluateAsync(
            CefNet.DevTools.Protocol.Runtime.EvaluateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.EvaluateRequest, CefNet.DevTools.Protocol.Runtime.EvaluateResponse>(
                    "Runtime.evaluate", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the JavaScript heap usage.
        /// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.GetHeapUsageResponse> GetHeapUsageAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Runtime.GetHeapUsageResponse>(
                    "Runtime.getHeapUsage", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] Returns the isolate id.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.GetIsolateIdResponse> GetIsolateIdAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Runtime.GetIsolateIdResponse>(
                    "Runtime.getIsolateId", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns properties of a given object. Object group of the result is inherited from the target
        /// object.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.GetPropertiesResponse> GetPropertiesAsync(
            CefNet.DevTools.Protocol.Runtime.GetPropertiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.GetPropertiesRequest, CefNet.DevTools.Protocol.Runtime.GetPropertiesResponse>(
                    "Runtime.getProperties", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all let, const and class variables from global scope.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.GlobalLexicalScopeNamesResponse> GlobalLexicalScopeNamesAsync(
            CefNet.DevTools.Protocol.Runtime.GlobalLexicalScopeNamesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.GlobalLexicalScopeNamesRequest, CefNet.DevTools.Protocol.Runtime.GlobalLexicalScopeNamesResponse>(
                    "Runtime.globalLexicalScopeNames", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.QueryObjectsResponse> QueryObjectsAsync(
            CefNet.DevTools.Protocol.Runtime.QueryObjectsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.QueryObjectsRequest, CefNet.DevTools.Protocol.Runtime.QueryObjectsResponse>(
                    "Runtime.queryObjects", parameters, cancellationToken);
        }

        /// <summary>Releases remote object with given id.</summary>
        public readonly System.Threading.Tasks.Task ReleaseObjectAsync(
            CefNet.DevTools.Protocol.Runtime.ReleaseObjectRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.ReleaseObjectRequest>(
                    "Runtime.releaseObject", parameters, cancellationToken);
        }

        /// <summary>
        /// Releases all remote objects that belong to a given group.
        /// </summary>
        public readonly System.Threading.Tasks.Task ReleaseObjectGroupAsync(
            CefNet.DevTools.Protocol.Runtime.ReleaseObjectGroupRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.ReleaseObjectGroupRequest>(
                    "Runtime.releaseObjectGroup", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] This method does not remove binding function from global object but
        /// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveBindingAsync(
            CefNet.DevTools.Protocol.Runtime.RemoveBindingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.RemoveBindingRequest>(
                    "Runtime.removeBinding", parameters, cancellationToken);
        }

        /// <summary>
        /// Tells inspected instance to run if it was waiting for debugger to attach.
        /// </summary>
        public readonly System.Threading.Tasks.Task RunIfWaitingForDebuggerAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Runtime.runIfWaitingForDebugger", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Runs script with given id in a given context.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Runtime.RunScriptResponse> RunScriptAsync(
            CefNet.DevTools.Protocol.Runtime.RunScriptRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.RunScriptRequest, CefNet.DevTools.Protocol.Runtime.RunScriptResponse>(
                    "Runtime.runScript", parameters, cancellationToken);
        }

        /// <summary>
        /// Enables or disables async call stacks tracking.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAsyncCallStackDepthAsync(
            CefNet.DevTools.Protocol.Runtime.SetAsyncCallStackDepthRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.SetAsyncCallStackDepthRequest>(
                    "Runtime.setAsyncCallStackDepth", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetCustomObjectFormatterEnabledAsync(
            CefNet.DevTools.Protocol.Runtime.SetCustomObjectFormatterEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.SetCustomObjectFormatterEnabledRequest>(
                    "Runtime.setCustomObjectFormatterEnabled", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetMaxCallStackSizeToCaptureAsync(
            CefNet.DevTools.Protocol.Runtime.SetMaxCallStackSizeToCaptureRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Runtime.SetMaxCallStackSizeToCaptureRequest>(
                    "Runtime.setMaxCallStackSizeToCapture", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Terminate current or next JavaScript execution.
        /// Will cancel the termination when the outer-most script execution ends.
        /// </summary>
        public readonly System.Threading.Tasks.Task TerminateExecutionAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Runtime.terminateExecution", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Notification is issued every time when binding is called.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.BindingCalledEventArgs> BindingCalled 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.BindingCalledEventArgs>("Runtime.bindingCalled", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.BindingCalledEventArgs>("Runtime.bindingCalled", value);
            }
        }

        /// <summary>Issued when console API was called.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgs> ConsoleAPICalled 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgs>("Runtime.consoleAPICalled", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgs>("Runtime.consoleAPICalled", value);
            }
        }

        /// <summary>
        /// Issued when unhandled exception was revoked.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionRevokedEventArgs> ExceptionRevoked 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionRevokedEventArgs>("Runtime.exceptionRevoked", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionRevokedEventArgs>("Runtime.exceptionRevoked", value);
            }
        }

        /// <summary>
        /// Issued when exception was thrown and unhandled.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionThrownEventArgs> ExceptionThrown 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionThrownEventArgs>("Runtime.exceptionThrown", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.ExceptionThrownEventArgs>("Runtime.exceptionThrown", value);
            }
        }

        /// <summary>
        /// Issued when new execution context is created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextCreatedEventArgs> ExecutionContextCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextCreatedEventArgs>("Runtime.executionContextCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextCreatedEventArgs>("Runtime.executionContextCreated", value);
            }
        }

        /// <summary>
        /// Issued when execution context is destroyed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextDestroyedEventArgs> ExecutionContextDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextDestroyedEventArgs>("Runtime.executionContextDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.ExecutionContextDestroyedEventArgs>("Runtime.executionContextDestroyed", value);
            }
        }

        /// <summary>
        /// Issued when all executionContexts were cleared in browser
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> ExecutionContextsCleared 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Runtime.executionContextsCleared", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Runtime.executionContextsCleared", value);
            }
        }

        /// <summary>
        /// Issued when object should be inspected (for example, as a result of inspect() command line API
        /// call).
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Runtime.InspectRequestedEventArgs> InspectRequested 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Runtime.InspectRequestedEventArgs>("Runtime.inspectRequested", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Runtime.InspectRequestedEventArgs>("Runtime.inspectRequested", value);
            }
        }
    }
}
