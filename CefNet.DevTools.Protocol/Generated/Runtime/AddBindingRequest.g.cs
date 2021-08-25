//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class AddBindingRequest
    {
        public string Name { get; set; }

        /// <summary>
        /// [Deprecated] If specified, the binding would only be exposed to the specified
        /// execution context. If omitted and `executionContextName` is not set,
        /// the binding is exposed to all execution contexts of the target.
        /// This parameter is mutually exclusive with `executionContextName`.
        /// Deprecated in favor of `executionContextName` due to an unclear use case
        /// and bugs in implementation (crbug.com/1169639). `executionContextId` will be
        /// removed in the future.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }

        /// <summary>
        /// [Experimental] If specified, the binding is exposed to the executionContext with
        /// matching name, even for contexts created after the binding is added.
        /// See also `ExecutionContext.name` and `worldName` parameter to
        /// `Page.addScriptToEvaluateOnNewDocument`.
        /// This parameter is mutually exclusive with `executionContextId`.
        /// </summary>
        public string? ExecutionContextName { get; set; }
    }
}
