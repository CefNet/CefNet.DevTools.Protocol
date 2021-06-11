//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class CancelDownloadRequest
    {
        /// <summary>
        /// Global unique identifier of the download.
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// BrowserContext to perform the action in. When omitted, default browser context is used.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }
    }
}
