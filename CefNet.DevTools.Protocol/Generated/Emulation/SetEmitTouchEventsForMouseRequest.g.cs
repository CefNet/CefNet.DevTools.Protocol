//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetEmitTouchEventsForMouseRequest
    {
        /// <summary>
        /// Whether touch emulation based on mouse input should be enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Touch/gesture events configuration. Default: current platform.
        /// </summary>
        public CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration? Configuration { get; set; }
    }
}
