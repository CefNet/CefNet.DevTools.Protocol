//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>
    /// [Experimental] This domain allows inspection of Web Audio API.
    /// https://webaudio.github.io/web-audio-api/
    /// </summary>
    public readonly struct WebAudioApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal WebAudioApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables the WebAudio domain.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "WebAudio.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables the WebAudio domain and starts sending context lifetime events.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "WebAudio.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Fetch the realtime data from the registered contexts.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.WebAudio.GetRealtimeDataResponse> GetRealtimeDataAsync(
            CefNet.DevTools.Protocol.WebAudio.GetRealtimeDataRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAudio.GetRealtimeDataRequest, CefNet.DevTools.Protocol.WebAudio.GetRealtimeDataResponse>(
                    "WebAudio.getRealtimeData", parameters, cancellationToken);
        }

        /// <summary>
        /// Notifies that the construction of an AudioListener has finished.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerCreatedEventArgs> AudioListenerCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerCreatedEventArgs>("WebAudio.audioListenerCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerCreatedEventArgs>("WebAudio.audioListenerCreated", value);
            }
        }

        /// <summary>
        /// Notifies that a new AudioListener has been created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerWillBeDestroyedEventArgs> AudioListenerWillBeDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerWillBeDestroyedEventArgs>("WebAudio.audioListenerWillBeDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioListenerWillBeDestroyedEventArgs>("WebAudio.audioListenerWillBeDestroyed", value);
            }
        }

        /// <summary>
        /// Notifies that a new AudioNode has been created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeCreatedEventArgs> AudioNodeCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeCreatedEventArgs>("WebAudio.audioNodeCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeCreatedEventArgs>("WebAudio.audioNodeCreated", value);
            }
        }

        /// <summary>
        /// Notifies that an existing AudioNode has been destroyed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeWillBeDestroyedEventArgs> AudioNodeWillBeDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeWillBeDestroyedEventArgs>("WebAudio.audioNodeWillBeDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioNodeWillBeDestroyedEventArgs>("WebAudio.audioNodeWillBeDestroyed", value);
            }
        }

        /// <summary>
        /// Notifies that a new AudioParam has been created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamCreatedEventArgs> AudioParamCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamCreatedEventArgs>("WebAudio.audioParamCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamCreatedEventArgs>("WebAudio.audioParamCreated", value);
            }
        }

        /// <summary>
        /// Notifies that an existing AudioParam has been destroyed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamWillBeDestroyedEventArgs> AudioParamWillBeDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamWillBeDestroyedEventArgs>("WebAudio.audioParamWillBeDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.AudioParamWillBeDestroyedEventArgs>("WebAudio.audioParamWillBeDestroyed", value);
            }
        }

        /// <summary>
        /// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.ContextChangedEventArgs> ContextChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextChangedEventArgs>("WebAudio.contextChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextChangedEventArgs>("WebAudio.contextChanged", value);
            }
        }

        /// <summary>
        /// Notifies that a new BaseAudioContext has been created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.ContextCreatedEventArgs> ContextCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextCreatedEventArgs>("WebAudio.contextCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextCreatedEventArgs>("WebAudio.contextCreated", value);
            }
        }

        /// <summary>
        /// Notifies that an existing BaseAudioContext will be destroyed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.ContextWillBeDestroyedEventArgs> ContextWillBeDestroyed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextWillBeDestroyedEventArgs>("WebAudio.contextWillBeDestroyed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.ContextWillBeDestroyedEventArgs>("WebAudio.contextWillBeDestroyed", value);
            }
        }

        /// <summary>
        /// Notifies that an AudioNode is connected to an AudioParam.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamConnectedEventArgs> NodeParamConnected 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamConnectedEventArgs>("WebAudio.nodeParamConnected", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamConnectedEventArgs>("WebAudio.nodeParamConnected", value);
            }
        }

        /// <summary>
        /// Notifies that an AudioNode is disconnected to an AudioParam.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamDisconnectedEventArgs> NodeParamDisconnected 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamDisconnectedEventArgs>("WebAudio.nodeParamDisconnected", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.NodeParamDisconnectedEventArgs>("WebAudio.nodeParamDisconnected", value);
            }
        }

        /// <summary>
        /// Notifies that two AudioNodes are connected.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.NodesConnectedEventArgs> NodesConnected 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.NodesConnectedEventArgs>("WebAudio.nodesConnected", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.NodesConnectedEventArgs>("WebAudio.nodesConnected", value);
            }
        }

        /// <summary>
        /// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.WebAudio.NodesDisconnectedEventArgs> NodesDisconnected 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.WebAudio.NodesDisconnectedEventArgs>("WebAudio.nodesDisconnected", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.WebAudio.NodesDisconnectedEventArgs>("WebAudio.nodesDisconnected", value);
            }
        }
    }
}
