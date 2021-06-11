//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class SetDownloadBehaviorRequest
    {
        /// <summary>
        /// Whether to allow all or deny all download requests, or use default Chrome behavior if
        /// available (otherwise deny). |allowAndName| allows download and names files according to
        /// their dowmload guids.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior Behavior { get; set; }

        /// <summary>
        /// BrowserContext to set download behavior. When omitted, default browser context is used.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }

        /// <summary>
        /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
        /// or 'allowAndName'.
        /// </summary>
        public string? DownloadPath { get; set; }

        /// <summary>
        /// Whether to emit download events (defaults to false).
        /// </summary>
        public bool? EventsEnabled { get; set; }
    }
}
