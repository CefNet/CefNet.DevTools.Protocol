//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class CallFunctionOnRequest
    {
        /// <summary>Declaration of the function to call.</summary>
        public string FunctionDeclaration { get; set; }

        /// <summary>
        /// Identifier of the object to call function on. Either objectId or executionContextId should
        /// be specified.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? ObjectId { get; set; }

        /// <summary>
        /// Call arguments. All call arguments must belong to the same JavaScript world as the target
        /// object.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.CallArgument>? Arguments { get; set; }

        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause
        /// execution. Overrides `setPauseOnException` state.
        /// </summary>
        public bool? Silent { get; set; }

        /// <summary>
        /// Whether the result is expected to be a JSON object which should be sent by value.
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
        /// Specifies execution context which global object will be used to call function on. Either
        /// executionContextId or objectId should be specified.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release multiple objects. If objectGroup is not
        /// specified and objectId is, objectGroup will be inherited from object.
        /// </summary>
        public string? ObjectGroup { get; set; }

        /// <summary>
        /// [Experimental] Whether to throw an exception if side effect cannot be ruled out during evaluation.
        /// </summary>
        public bool? ThrowOnSideEffect { get; set; }
    }
}
