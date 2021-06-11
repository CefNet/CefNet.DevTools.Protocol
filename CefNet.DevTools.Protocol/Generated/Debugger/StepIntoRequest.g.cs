//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class StepIntoRequest
    {
        /// <summary>
        /// [Experimental] Debugger will pause on the execution of the first async task which was scheduled
        /// before next pause.
        /// </summary>
        public bool? BreakOnAsyncCall { get; set; }

        /// <summary>
        /// [Experimental] The skipList specifies location ranges that should be skipped on step into.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Debugger.LocationRange>? SkipList { get; set; }
    }
}
