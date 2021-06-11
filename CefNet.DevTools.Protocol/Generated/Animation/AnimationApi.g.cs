//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Animation
{
    /// <summary>[Experimental] </summary>
    public readonly struct AnimationApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal AnimationApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables animation domain notifications.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Animation.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables animation domain notifications.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Animation.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns the current time of the an animation.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Animation.GetCurrentTimeResponse> GetCurrentTimeAsync(
            CefNet.DevTools.Protocol.Animation.GetCurrentTimeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.GetCurrentTimeRequest, CefNet.DevTools.Protocol.Animation.GetCurrentTimeResponse>(
                    "Animation.getCurrentTime", parameters, cancellationToken);
        }

        /// <summary>
        /// Gets the playback rate of the document timeline.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Animation.GetPlaybackRateResponse> GetPlaybackRateAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Animation.GetPlaybackRateResponse>(
                    "Animation.getPlaybackRate", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Releases a set of animations to no longer be manipulated.
        /// </summary>
        public readonly System.Threading.Tasks.Task ReleaseAnimationsAsync(
            CefNet.DevTools.Protocol.Animation.ReleaseAnimationsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.ReleaseAnimationsRequest>(
                    "Animation.releaseAnimations", parameters, cancellationToken);
        }

        /// <summary>Gets the remote object of the Animation.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Animation.ResolveAnimationResponse> ResolveAnimationAsync(
            CefNet.DevTools.Protocol.Animation.ResolveAnimationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.ResolveAnimationRequest, CefNet.DevTools.Protocol.Animation.ResolveAnimationResponse>(
                    "Animation.resolveAnimation", parameters, cancellationToken);
        }

        /// <summary>
        /// Seek a set of animations to a particular time within each animation.
        /// </summary>
        public readonly System.Threading.Tasks.Task SeekAnimationsAsync(
            CefNet.DevTools.Protocol.Animation.SeekAnimationsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.SeekAnimationsRequest>(
                    "Animation.seekAnimations", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets the paused state of a set of animations.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPausedAsync(
            CefNet.DevTools.Protocol.Animation.SetPausedRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.SetPausedRequest>(
                    "Animation.setPaused", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets the playback rate of the document timeline.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPlaybackRateAsync(
            CefNet.DevTools.Protocol.Animation.SetPlaybackRateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.SetPlaybackRateRequest>(
                    "Animation.setPlaybackRate", parameters, cancellationToken);
        }

        /// <summary>Sets the timing of an animation node.</summary>
        public readonly System.Threading.Tasks.Task SetTimingAsync(
            CefNet.DevTools.Protocol.Animation.SetTimingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Animation.SetTimingRequest>(
                    "Animation.setTiming", parameters, cancellationToken);
        }

        /// <summary>
        /// Event for when an animation has been cancelled.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Animation.AnimationCanceledEventArgs> AnimationCanceled 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Animation.AnimationCanceledEventArgs>("Animation.animationCanceled", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Animation.AnimationCanceledEventArgs>("Animation.animationCanceled", value);
            }
        }

        /// <summary>
        /// Event for each animation that has been created.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Animation.AnimationCreatedEventArgs> AnimationCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Animation.AnimationCreatedEventArgs>("Animation.animationCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Animation.AnimationCreatedEventArgs>("Animation.animationCreated", value);
            }
        }

        /// <summary>
        /// Event for animation that has been started.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Animation.AnimationStartedEventArgs> AnimationStarted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Animation.AnimationStartedEventArgs>("Animation.animationStarted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Animation.AnimationStartedEventArgs>("Animation.animationStarted", value);
            }
        }
    }
}
