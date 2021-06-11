//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>
    /// [Experimental] Source offset and types for a parameter or return value.
    /// </summary>
    public sealed class TypeProfileEntry
    {
        /// <summary>
        /// Source offset of the parameter or end of function for return values.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// The types for this parameter or return value.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.TypeObject> Types { get; set; }
    }
}
