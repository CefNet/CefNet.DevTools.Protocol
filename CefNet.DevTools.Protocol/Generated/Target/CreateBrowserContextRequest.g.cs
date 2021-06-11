//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class CreateBrowserContextRequest
    {
        /// <summary>
        /// If specified, disposes this context when debugging session disconnects.
        /// </summary>
        public bool? DisposeOnDetach { get; set; }

        /// <summary>
        /// Proxy server, similar to the one passed to --proxy-server
        /// </summary>
        public string? ProxyServer { get; set; }

        /// <summary>
        /// Proxy bypass list, similar to the one passed to --proxy-bypass-list
        /// </summary>
        public string? ProxyBypassList { get; set; }
    }
}
