//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Error while paring app manifest.</summary>
    public sealed class AppManifestError
    {
        /// <summary>Error message.</summary>
        public string Message { get; set; }

        /// <summary>
        /// If criticial, this is a non-recoverable parse error.
        /// </summary>
        public int Critical { get; set; }

        /// <summary>Error line.</summary>
        public int Line { get; set; }

        /// <summary>Error column.</summary>
        public int Column { get; set; }
    }
}
