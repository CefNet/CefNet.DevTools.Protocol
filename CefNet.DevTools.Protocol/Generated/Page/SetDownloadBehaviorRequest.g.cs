//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class SetDownloadBehaviorRequest
    {
        /// <summary>
        /// Whether to allow all or deny all download requests, or use default Chrome behavior if
        /// available (otherwise deny).
        /// </summary>
        public CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior Behavior { get; set; }

        /// <summary>
        /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
        /// </summary>
        public string? DownloadPath { get; set; }
    }
}
