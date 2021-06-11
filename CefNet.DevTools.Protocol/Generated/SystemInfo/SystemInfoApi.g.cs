//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.SystemInfo
{
    /// <summary>
    /// [Experimental] The SystemInfo domain defines methods and events for querying low-level system information.
    /// </summary>
    public readonly struct SystemInfoApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal SystemInfoApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Returns information about the system.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.SystemInfo.GetInfoResponse> GetInfoAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.SystemInfo.GetInfoResponse>(
                    "SystemInfo.getInfo", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns information about all running processes.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.SystemInfo.GetProcessInfoResponse> GetProcessInfoAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.SystemInfo.GetProcessInfoResponse>(
                    "SystemInfo.getProcessInfo", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }
    }
}
