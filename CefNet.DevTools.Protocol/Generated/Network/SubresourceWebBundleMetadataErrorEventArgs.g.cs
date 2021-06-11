//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class SubresourceWebBundleMetadataErrorEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Request identifier. Used to match this information to another event.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>Error message</summary>
        public string ErrorMessage { get; set; }
    }
}
