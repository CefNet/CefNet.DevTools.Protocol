//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Emulation
{
    /// <summary>
    /// This domain emulates different environments for the page.
    /// </summary>
    public readonly struct EmulationApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal EmulationApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Tells whether emulation is supported.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Emulation.CanEmulateResponse> CanEmulateAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Emulation.CanEmulateResponse>(
                    "Emulation.canEmulate", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Clears the overridden device metrics.</summary>
        public readonly System.Threading.Tasks.Task ClearDeviceMetricsOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Emulation.clearDeviceMetricsOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Clears the overridden Geolocation Position and Error.
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearGeolocationOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Emulation.clearGeolocationOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Clears Idle state overrides.
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearIdleOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Emulation.clearIdleOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Requests that page scale factor is reset to initial values.
        /// </summary>
        public readonly System.Threading.Tasks.Task ResetPageScaleFactorAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Emulation.resetPageScaleFactor", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enables CPU throttling to emulate slow CPUs.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetCPUThrottlingRateAsync(
            CefNet.DevTools.Protocol.Emulation.SetCPUThrottlingRateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetCPUThrottlingRateRequest>(
                    "Emulation.setCPUThrottlingRate", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets or clears an override of the default background color of the frame. This override is used
        /// if the content does not specify one.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDefaultBackgroundColorOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetDefaultBackgroundColorOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetDefaultBackgroundColorOverrideRequest>(
                    "Emulation.setDefaultBackgroundColorOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
        /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
        /// query results).
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDeviceMetricsOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetDeviceMetricsOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetDeviceMetricsOverrideRequest>(
                    "Emulation.setDeviceMetricsOverride", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetDisabledImageTypesAsync(
            CefNet.DevTools.Protocol.Emulation.SetDisabledImageTypesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetDisabledImageTypesRequest>(
                    "Emulation.setDisabledImageTypes", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetDocumentCookieDisabledAsync(
            CefNet.DevTools.Protocol.Emulation.SetDocumentCookieDisabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetDocumentCookieDisabledRequest>(
                    "Emulation.setDocumentCookieDisabled", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetEmitTouchEventsForMouseAsync(
            CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequest>(
                    "Emulation.setEmitTouchEventsForMouse", parameters, cancellationToken);
        }

        /// <summary>
        /// Emulates the given media type or media feature for CSS media queries.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetEmulatedMediaAsync(
            CefNet.DevTools.Protocol.Emulation.SetEmulatedMediaRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetEmulatedMediaRequest>(
                    "Emulation.setEmulatedMedia", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Emulates the given vision deficiency.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetEmulatedVisionDeficiencyAsync(
            CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequest>(
                    "Emulation.setEmulatedVisionDeficiency", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enables or disables simulating a focused and active page.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetFocusEmulationEnabledAsync(
            CefNet.DevTools.Protocol.Emulation.SetFocusEmulationEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetFocusEmulationEnabledRequest>(
                    "Emulation.setFocusEmulationEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
        /// unavailable.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetGeolocationOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetGeolocationOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetGeolocationOverrideRequest>(
                    "Emulation.setGeolocationOverride", parameters, cancellationToken);
        }

        /// <summary>[Experimental] Overrides the Idle state.</summary>
        public readonly System.Threading.Tasks.Task SetIdleOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetIdleOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetIdleOverrideRequest>(
                    "Emulation.setIdleOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Overrides default host system locale with the specified one.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetLocaleOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetLocaleOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetLocaleOverrideRequest>(
                    "Emulation.setLocaleOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Overrides value returned by the javascript navigator object.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetNavigatorOverridesAsync(
            CefNet.DevTools.Protocol.Emulation.SetNavigatorOverridesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetNavigatorOverridesRequest>(
                    "Emulation.setNavigatorOverrides", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets a specified page scale factor.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPageScaleFactorAsync(
            CefNet.DevTools.Protocol.Emulation.SetPageScaleFactorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetPageScaleFactorRequest>(
                    "Emulation.setPageScaleFactor", parameters, cancellationToken);
        }

        /// <summary>Switches script execution in the page.</summary>
        public readonly System.Threading.Tasks.Task SetScriptExecutionDisabledAsync(
            CefNet.DevTools.Protocol.Emulation.SetScriptExecutionDisabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetScriptExecutionDisabledRequest>(
                    "Emulation.setScriptExecutionDisabled", parameters, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task SetScrollbarsHiddenAsync(
            CefNet.DevTools.Protocol.Emulation.SetScrollbarsHiddenRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetScrollbarsHiddenRequest>(
                    "Emulation.setScrollbarsHidden", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Overrides default host system timezone with the specified one.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetTimezoneOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetTimezoneOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetTimezoneOverrideRequest>(
                    "Emulation.setTimezoneOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// Enables touch on platforms which do not support them.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetTouchEmulationEnabledAsync(
            CefNet.DevTools.Protocol.Emulation.SetTouchEmulationEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetTouchEmulationEnabledRequest>(
                    "Emulation.setTouchEmulationEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetUserAgentOverrideAsync(
            CefNet.DevTools.Protocol.Emulation.SetUserAgentOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetUserAgentOverrideRequest>(
                    "Emulation.setUserAgentOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
        /// the current virtual time policy.  Note this supersedes any previous time budget.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Emulation.SetVirtualTimePolicyResponse> SetVirtualTimePolicyAsync(
            CefNet.DevTools.Protocol.Emulation.SetVirtualTimePolicyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetVirtualTimePolicyRequest, CefNet.DevTools.Protocol.Emulation.SetVirtualTimePolicyResponse>(
                    "Emulation.setVirtualTimePolicy", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Resizes the frame/viewport of the page. Note that this does not affect the frame's container
        /// (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported
        /// on Android.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetVisibleSizeAsync(
            CefNet.DevTools.Protocol.Emulation.SetVisibleSizeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Emulation.SetVisibleSizeRequest>(
                    "Emulation.setVisibleSize", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> VirtualTimeBudgetExpired 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Emulation.virtualTimeBudgetExpired", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Emulation.virtualTimeBudgetExpired", value);
            }
        }
    }
}
