//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class SetTouchEmulationEnabledRequest
    {
        /// <summary>
        /// Whether the touch event emulation should be enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Touch/gesture events configuration. Default: current platform.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration? Configuration { get; set; }
    }
}
