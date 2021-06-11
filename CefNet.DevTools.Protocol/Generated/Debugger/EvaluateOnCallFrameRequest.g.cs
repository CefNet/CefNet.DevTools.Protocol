//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class EvaluateOnCallFrameRequest
    {
        /// <summary>Call frame identifier to evaluate on.</summary>
        public CefNet.DevTools.Protocol.Debugger.CallFrameId CallFrameId { get; set; }

        /// <summary>Expression to evaluate.</summary>
        public string Expression { get; set; }

        /// <summary>
        /// String object group name to put result into (allows rapid releasing resulting object handles
        /// using `releaseObjectGroup`).
        /// </summary>
        public string? ObjectGroup { get; set; }

        /// <summary>
        /// Specifies whether command line API should be available to the evaluated expression, defaults
        /// to false.
        /// </summary>
        public bool? IncludeCommandLineAPI { get; set; }

        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause
        /// execution. Overrides `setPauseOnException` state.
        /// </summary>
        public bool? Silent { get; set; }

        /// <summary>
        /// Whether the result is expected to be a JSON object that should be sent by value.
        /// </summary>
        public bool? ReturnByValue { get; set; }

        /// <summary>
        /// [Experimental] Whether preview should be generated for the result.
        /// </summary>
        public bool? GeneratePreview { get; set; }

        /// <summary>
        /// Whether to throw an exception if side effect cannot be ruled out during evaluation.
        /// </summary>
        public bool? ThrowOnSideEffect { get; set; }

        /// <summary>
        /// [Experimental] Terminate execution after timing out (number of milliseconds).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.TimeDelta? Timeout { get; set; }
    }
}
