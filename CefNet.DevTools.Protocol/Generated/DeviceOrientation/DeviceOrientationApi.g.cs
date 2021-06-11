//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DeviceOrientation
{
    /// <summary>[Experimental] </summary>
    public readonly struct DeviceOrientationApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DeviceOrientationApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Clears the overridden Device Orientation.
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearDeviceOrientationOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DeviceOrientation.clearDeviceOrientationOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Overrides the Device Orientation.</summary>
        public readonly System.Threading.Tasks.Task SetDeviceOrientationOverrideAsync(
            CefNet.DevTools.Protocol.DeviceOrientation.SetDeviceOrientationOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DeviceOrientation.SetDeviceOrientationOverrideRequest>(
                    "DeviceOrientation.setDeviceOrientationOverride", parameters, cancellationToken);
        }
    }
}
