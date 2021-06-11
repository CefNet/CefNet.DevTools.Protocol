//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.IO
{
    /// <summary>
    /// Input/Output operations for streams produced by DevTools.
    /// </summary>
    public readonly struct IOApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal IOApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Close the stream, discard any temporary backing storage.
        /// </summary>
        public readonly System.Threading.Tasks.Task CloseAsync(
            CefNet.DevTools.Protocol.IO.CloseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IO.CloseRequest>(
                    "IO.close", parameters, cancellationToken);
        }

        /// <summary>Read a chunk of the stream</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IO.ReadResponse> ReadAsync(
            CefNet.DevTools.Protocol.IO.ReadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IO.ReadRequest, CefNet.DevTools.Protocol.IO.ReadResponse>(
                    "IO.read", parameters, cancellationToken);
        }

        /// <summary>
        /// Return UUID of Blob object specified by a remote object id.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IO.ResolveBlobResponse> ResolveBlobAsync(
            CefNet.DevTools.Protocol.IO.ResolveBlobRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IO.ResolveBlobRequest, CefNet.DevTools.Protocol.IO.ResolveBlobResponse>(
                    "IO.resolveBlob", parameters, cancellationToken);
        }
    }
}
