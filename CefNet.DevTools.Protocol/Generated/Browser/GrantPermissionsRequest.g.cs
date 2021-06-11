//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class GrantPermissionsRequest
    {
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Browser.PermissionType> Permissions { get; set; }

        /// <summary>
        /// Origin the permission applies to, all origins if not specified.
        /// </summary>
        public string? Origin { get; set; }

        /// <summary>
        /// BrowserContext to override permissions. When omitted, default browser context is used.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }
    }
}
