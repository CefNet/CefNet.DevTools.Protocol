//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class SubresourceWebBundleInnerResponseParsedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Request identifier of the subresource request
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId InnerRequestId { get; set; }

        /// <summary>URL of the subresource resource.</summary>
        public string InnerRequestURL { get; set; }

        /// <summary>
        /// Bundle request identifier. Used to match this information to another event.
        /// This made be absent in case when the instrumentation was enabled only
        /// after webbundle was parsed.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId? BundleRequestId { get; set; }
    }
}
