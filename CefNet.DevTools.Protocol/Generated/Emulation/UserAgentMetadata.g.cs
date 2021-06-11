//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    /// <summary>
    /// [Experimental] Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
    /// Missing optional values will be filled in by the target with what it would normally use.
    /// </summary>
    public sealed class UserAgentMetadata
    {
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Emulation.UserAgentBrandVersion>? Brands { get; set; }

        public string? FullVersion { get; set; }

        public string Platform { get; set; }

        public string PlatformVersion { get; set; }

        public string Architecture { get; set; }

        public string Model { get; set; }

        public bool Mobile { get; set; }
    }
}
