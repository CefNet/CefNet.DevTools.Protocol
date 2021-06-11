//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class RunScriptRequest
    {
        /// <summary>Id of the script to run.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>
        /// Specifies in which execution context to perform script run. If the parameter is omitted the
        /// evaluation will be performed in the context of the inspected page.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        public string? ObjectGroup { get; set; }

        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause
        /// execution. Overrides `setPauseOnException` state.
        /// </summary>
        public bool? Silent { get; set; }

        /// <summary>
        /// Determines whether Command Line API should be available during the evaluation.
        /// </summary>
        public bool? IncludeCommandLineAPI { get; set; }

        /// <summary>
        /// Whether the result is expected to be a JSON object which should be sent by value.
        /// </summary>
        public bool? ReturnByValue { get; set; }

        /// <summary>
        /// Whether preview should be generated for the result.
        /// </summary>
        public bool? GeneratePreview { get; set; }

        /// <summary>
        /// Whether execution should `await` for resulting value and return once awaited promise is
        /// resolved.
        /// </summary>
        public bool? AwaitPromise { get; set; }
    }
}
