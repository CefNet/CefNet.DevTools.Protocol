//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class EvaluateRequest
    {
        /// <summary>Expression to evaluate.</summary>
        public string Expression { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        public string? ObjectGroup { get; set; }

        /// <summary>
        /// Determines whether Command Line API should be available during the evaluation.
        /// </summary>
        public bool? IncludeCommandLineAPI { get; set; }

        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause
        /// execution. Overrides `setPauseOnException` state.
        /// </summary>
        public bool? Silent { get; set; }

        /// <summary>
        /// Specifies in which execution context to perform evaluation. If the parameter is omitted the
        /// evaluation will be performed in the context of the inspected page.
        /// This is mutually exclusive with `uniqueContextId`, which offers an
        /// alternative way to identify the execution context that is more reliable
        /// in a multi-process environment.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ContextId { get; set; }

        /// <summary>
        /// Whether the result is expected to be a JSON object that should be sent by value.
        /// </summary>
        public bool? ReturnByValue { get; set; }

        /// <summary>
        /// [Experimental] Whether preview should be generated for the result.
        /// </summary>
        public bool? GeneratePreview { get; set; }

        /// <summary>
        /// Whether execution should be treated as initiated by user in the UI.
        /// </summary>
        public bool? UserGesture { get; set; }

        /// <summary>
        /// Whether execution should `await` for resulting value and return once awaited promise is
        /// resolved.
        /// </summary>
        public bool? AwaitPromise { get; set; }

        /// <summary>
        /// [Experimental] Whether to throw an exception if side effect cannot be ruled out during evaluation.
        /// This implies `disableBreaks` below.
        /// </summary>
        public bool? ThrowOnSideEffect { get; set; }

        /// <summary>
        /// [Experimental] Terminate execution after timing out (number of milliseconds).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.TimeDelta? Timeout { get; set; }

        /// <summary>
        /// [Experimental] Disable breakpoints during execution.
        /// </summary>
        public bool? DisableBreaks { get; set; }

        /// <summary>
        /// [Experimental] Setting this flag to true enables `let` re-declaration and top-level `await`.
        /// Note that `let` variables can only be re-declared if they originate from
        /// `replMode` themselves.
        /// </summary>
        public bool? ReplMode { get; set; }

        /// <summary>
        /// [Experimental] The Content Security Policy (CSP) for the target might block 'unsafe-eval'
        /// which includes eval(), Function(), setTimeout() and setInterval()
        /// when called with non-callable arguments. This flag bypasses CSP for this
        /// evaluation and allows unsafe-eval. Defaults to true.
        /// </summary>
        public bool? AllowUnsafeEvalBlockedByCSP { get; set; }

        /// <summary>
        /// [Experimental] An alternative way to specify the execution context to evaluate in.
        /// Compared to contextId that may be reused across processes, this is guaranteed to be
        /// system-unique, so it can be used to prevent accidental evaluation of the expression
        /// in context different than intended (e.g. as a result of navigation across process
        /// boundaries).
        /// This is mutually exclusive with `contextId`.
        /// </summary>
        public string? UniqueContextId { get; set; }
    }
}
