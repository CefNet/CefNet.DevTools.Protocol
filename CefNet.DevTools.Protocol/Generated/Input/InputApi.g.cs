//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Input
{
    public readonly struct InputApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal InputApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Experimental] Dispatches a drag event into the page.
        /// </summary>
        public readonly System.Threading.Tasks.Task DispatchDragEventAsync(
            CefNet.DevTools.Protocol.Input.DispatchDragEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.DispatchDragEventRequest>(
                    "Input.dispatchDragEvent", parameters, cancellationToken);
        }

        /// <summary>Dispatches a key event to the page.</summary>
        public readonly System.Threading.Tasks.Task DispatchKeyEventAsync(
            CefNet.DevTools.Protocol.Input.DispatchKeyEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.DispatchKeyEventRequest>(
                    "Input.dispatchKeyEvent", parameters, cancellationToken);
        }

        /// <summary>Dispatches a mouse event to the page.</summary>
        public readonly System.Threading.Tasks.Task DispatchMouseEventAsync(
            CefNet.DevTools.Protocol.Input.DispatchMouseEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.DispatchMouseEventRequest>(
                    "Input.dispatchMouseEvent", parameters, cancellationToken);
        }

        /// <summary>Dispatches a touch event to the page.</summary>
        public readonly System.Threading.Tasks.Task DispatchTouchEventAsync(
            CefNet.DevTools.Protocol.Input.DispatchTouchEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.DispatchTouchEventRequest>(
                    "Input.dispatchTouchEvent", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Emulates touch event from the mouse event parameters.
        /// </summary>
        public readonly System.Threading.Tasks.Task EmulateTouchFromMouseEventAsync(
            CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequest>(
                    "Input.emulateTouchFromMouseEvent", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] This method emulates inserting text that doesn't come from a key press,
        /// for example an emoji keyboard or an IME.
        /// </summary>
        public readonly System.Threading.Tasks.Task InsertTextAsync(
            CefNet.DevTools.Protocol.Input.InsertTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.InsertTextRequest>(
                    "Input.insertText", parameters, cancellationToken);
        }

        /// <summary>
        /// Ignores input events (useful while auditing page).
        /// </summary>
        public readonly System.Threading.Tasks.Task SetIgnoreInputEventsAsync(
            CefNet.DevTools.Protocol.Input.SetIgnoreInputEventsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.SetIgnoreInputEventsRequest>(
                    "Input.setIgnoreInputEvents", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Prevents default drag and drop behavior and instead emits `Input.dragIntercepted` events.
        /// Drag and drop behavior can be directly controlled via `Input.dispatchDragEvent`.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetInterceptDragsAsync(
            CefNet.DevTools.Protocol.Input.SetInterceptDragsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.SetInterceptDragsRequest>(
                    "Input.setInterceptDrags", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public readonly System.Threading.Tasks.Task SynthesizePinchGestureAsync(
            CefNet.DevTools.Protocol.Input.SynthesizePinchGestureRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.SynthesizePinchGestureRequest>(
                    "Input.synthesizePinchGesture", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public readonly System.Threading.Tasks.Task SynthesizeScrollGestureAsync(
            CefNet.DevTools.Protocol.Input.SynthesizeScrollGestureRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.SynthesizeScrollGestureRequest>(
                    "Input.synthesizeScrollGesture", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Synthesizes a tap gesture over a time period by issuing appropriate touch events.
        /// </summary>
        public readonly System.Threading.Tasks.Task SynthesizeTapGestureAsync(
            CefNet.DevTools.Protocol.Input.SynthesizeTapGestureRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Input.SynthesizeTapGestureRequest>(
                    "Input.synthesizeTapGesture", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Emitted only when `Input.setInterceptDrags` is enabled. Use this data with `Input.dispatchDragEvent` to
        /// restore normal drag and drop behavior.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Input.DragInterceptedEventArgs> DragIntercepted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Input.DragInterceptedEventArgs>("Input.dragIntercepted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Input.DragInterceptedEventArgs>("Input.dragIntercepted", value);
            }
        }
    }
}
