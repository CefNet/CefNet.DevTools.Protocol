//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class EnableRequest
    {
        /// <summary>
        /// [Experimental] The maximum size in bytes of collected scripts (not referenced by other heap objects)
        /// the debugger can hold. Puts no limit if paramter is omitted.
        /// </summary>
        public double? MaxScriptsCacheSize { get; set; }
    }
}
