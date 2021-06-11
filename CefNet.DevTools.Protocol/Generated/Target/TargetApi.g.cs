//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Target
{
    /// <summary>
    /// Supports additional targets discovery and allows to attach to them.
    /// </summary>
    public readonly struct TargetApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal TargetApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Activates (focuses) the target.</summary>
        public readonly System.Threading.Tasks.Task ActivateTargetAsync(
            CefNet.DevTools.Protocol.Target.ActivateTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.ActivateTargetRequest>(
                    "Target.activateTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Attaches to the browser target, only uses flat sessionId mode.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.AttachToBrowserTargetResponse> AttachToBrowserTargetAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Target.AttachToBrowserTargetResponse>(
                    "Target.attachToBrowserTarget", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Attaches to the target with given id.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.AttachToTargetResponse> AttachToTargetAsync(
            CefNet.DevTools.Protocol.Target.AttachToTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.AttachToTargetRequest, CefNet.DevTools.Protocol.Target.AttachToTargetResponse>(
                    "Target.attachToTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// Closes the target. If the target is a page that gets closed too.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.CloseTargetResponse> CloseTargetAsync(
            CefNet.DevTools.Protocol.Target.CloseTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.CloseTargetRequest, CefNet.DevTools.Protocol.Target.CloseTargetResponse>(
                    "Target.closeTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
        /// one.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.CreateBrowserContextResponse> CreateBrowserContextAsync(
            CefNet.DevTools.Protocol.Target.CreateBrowserContextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.CreateBrowserContextRequest, CefNet.DevTools.Protocol.Target.CreateBrowserContextResponse>(
                    "Target.createBrowserContext", parameters, cancellationToken);
        }

        /// <summary>Creates a new page.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.CreateTargetResponse> CreateTargetAsync(
            CefNet.DevTools.Protocol.Target.CreateTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.CreateTargetRequest, CefNet.DevTools.Protocol.Target.CreateTargetResponse>(
                    "Target.createTarget", parameters, cancellationToken);
        }

        /// <summary>Detaches session with given id.</summary>
        public readonly System.Threading.Tasks.Task DetachFromTargetAsync(
            CefNet.DevTools.Protocol.Target.DetachFromTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.DetachFromTargetRequest>(
                    "Target.detachFromTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Deletes a BrowserContext. All the belonging pages will be closed without calling their
        /// beforeunload hooks.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisposeBrowserContextAsync(
            CefNet.DevTools.Protocol.Target.DisposeBrowserContextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.DisposeBrowserContextRequest>(
                    "Target.disposeBrowserContext", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Inject object to the target's main frame that provides a communication
        /// channel with browser target.
        /// 
        /// Injected object will be available as `window[bindingName]`.
        /// 
        /// The object has the follwing API:
        /// - `binding.send(json)` - a method to send messages over the remote debugging protocol
        /// - `binding.onmessage = json => handleMessage(json)` - a callback that will be called for the protocol notifications and command responses.
        /// </summary>
        public readonly System.Threading.Tasks.Task ExposeDevToolsProtocolAsync(
            CefNet.DevTools.Protocol.Target.ExposeDevToolsProtocolRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.ExposeDevToolsProtocolRequest>(
                    "Target.exposeDevToolsProtocol", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns all browser contexts created with `Target.createBrowserContext` method.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.GetBrowserContextsResponse> GetBrowserContextsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Target.GetBrowserContextsResponse>(
                    "Target.getBrowserContexts", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns information about a target.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.GetTargetInfoResponse> GetTargetInfoAsync(
            CefNet.DevTools.Protocol.Target.GetTargetInfoRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.GetTargetInfoRequest, CefNet.DevTools.Protocol.Target.GetTargetInfoResponse>(
                    "Target.getTargetInfo", parameters, cancellationToken);
        }

        /// <summary>Retrieves a list of available targets.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Target.GetTargetsResponse> GetTargetsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Target.GetTargetsResponse>(
                    "Target.getTargets", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Sends protocol message over session with given id.
        /// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
        /// and crbug.com/991325.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SendMessageToTargetAsync(
            CefNet.DevTools.Protocol.Target.SendMessageToTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.SendMessageToTargetRequest>(
                    "Target.sendMessageToTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Controls whether to automatically attach to new targets which are considered to be related to
        /// this one. When turned on, attaches to all existing related targets as well. When turned off,
        /// automatically detaches from all currently attached targets.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAutoAttachAsync(
            CefNet.DevTools.Protocol.Target.SetAutoAttachRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.SetAutoAttachRequest>(
                    "Target.setAutoAttach", parameters, cancellationToken);
        }

        /// <summary>
        /// Controls whether to discover available targets and notify via
        /// `targetCreated/targetInfoChanged/targetDestroyed` events.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDiscoverTargetsAsync(
            CefNet.DevTools.Protocol.Target.SetDiscoverTargetsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.SetDiscoverTargetsRequest>(
                    "Target.setDiscoverTargets", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enables target discovery for the specified locations, when `setDiscoverTargets` was set to
        /// `true`.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetRemoteLocationsAsync(
            CefNet.DevTools.Protocol.Target.SetRemoteLocationsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Target.SetRemoteLocationsRequest>(
                    "Target.setRemoteLocations", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Issued when attached to target because of auto-attach or `attachToTarget` command.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.AttachedToTargetEventArgs> AttachedToTarget 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.AttachedToTargetEventArgs>("Target.attachedToTarget", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.AttachedToTargetEventArgs>("Target.attachedToTarget", value);
            }
        }

        /// <summary>
        /// [Experimental] Issued when detached from target for any reason (including `detachFromTarget` command). Can be
        /// issued multiple times per target if multiple sessions have been attached to it.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.DetachedFromTargetEventArgs> DetachedFromTarget 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.DetachedFromTargetEventArgs>("Target.detachedFromTarget", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.DetachedFromTargetEventArgs>("Target.detachedFromTarget", value);
            }
        }

        /// <summary>
        /// Notifies about a new protocol message received from the session (as reported in
        /// `attachedToTarget` event).
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.ReceivedMessageFromTargetEventArgs> ReceivedMessageFromTarget 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.ReceivedMessageFromTargetEventArgs>("Target.receivedMessageFromTarget", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.ReceivedMessageFromTargetEventArgs>("Target.receivedMessageFromTarget", value);
            }
        }

        /// <summary>Issued when a target has crashed.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.TargetCrashedEventArgs> TargetCrashed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.TargetCrashedEventArgs>("Target.targetCrashed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.TargetCrashedEventArgs>("Target.targetCrashed", value);
            }
        }

        /// <summary>
        /// Issued when a possible inspection target is created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.TargetCreatedEventArgs> TargetCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.TargetCreatedEventArgs>("Target.targetCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.TargetCreatedEventArgs>("Target.targetCreated", value);
            }
        }

        /// <summary>Issued when a target is destroyed.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.TargetDestroyedEventArgs> TargetDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.TargetDestroyedEventArgs>("Target.targetDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.TargetDestroyedEventArgs>("Target.targetDestroyed", value);
            }
        }

        /// <summary>
        /// Issued when some information about a target has changed. This only happens between
        /// `targetCreated` and `targetDestroyed`.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Target.TargetInfoChangedEventArgs> TargetInfoChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Target.TargetInfoChangedEventArgs>("Target.targetInfoChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Target.TargetInfoChangedEventArgs>("Target.targetInfoChanged", value);
            }
        }
    }
}
