//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Memory
{
    /// <summary>Executable module information</summary>
    public sealed class Module
    {
        /// <summary>Name of the module.</summary>
        public string Name { get; set; }

        /// <summary>UUID of the module.</summary>
        public string Uuid { get; set; }

        /// <summary>
        /// Base address where the module is loaded into memory. Encoded as a decimal
        /// or hexadecimal (0x prefixed) string.
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>Size of the module in bytes.</summary>
        public double Size { get; set; }
    }
}
