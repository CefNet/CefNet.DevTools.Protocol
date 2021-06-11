//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Schema
{
    /// <summary>[Deprecated] This domain is deprecated.</summary>
    [Obsolete]
    public readonly struct SchemaApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal SchemaApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Returns supported domains.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Schema.GetDomainsResponse> GetDomainsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Schema.GetDomainsResponse>(
                    "Schema.getDomains", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }
    }
}
