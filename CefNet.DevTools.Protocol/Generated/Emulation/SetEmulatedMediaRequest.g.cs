//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetEmulatedMediaRequest
    {
        /// <summary>
        /// Media type to emulate. Empty string disables the override.
        /// </summary>
        public string? Media { get; set; }

        /// <summary>Media features to emulate.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Emulation.MediaFeature>? Features { get; set; }
    }
}