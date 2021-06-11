//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class ResumeRequest
    {
        /// <summary>
        /// Set to true to terminate execution upon resuming execution. In contrast
        /// to Runtime.terminateExecution, this will allows to execute further
        /// JavaScript (i.e. via evaluation) until execution of the paused code
        /// is actually resumed, at which point termination is triggered.
        /// If execution is currently not paused, this parameter has no effect.
        /// </summary>
        public bool? TerminateOnResume { get; set; }
    }
}
