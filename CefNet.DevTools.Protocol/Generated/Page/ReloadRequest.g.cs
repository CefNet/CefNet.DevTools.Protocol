//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class ReloadRequest
    {
        /// <summary>
        /// If true, browser cache is ignored (as if the user pressed Shift+refresh).
        /// </summary>
        public bool? IgnoreCache { get; set; }

        /// <summary>
        /// If set, the script will be injected into all frames of the inspected page after reload.
        /// Argument will be ignored if reloading dataURL origin.
        /// </summary>
        public string? ScriptToEvaluateOnLoad { get; set; }
    }
}
