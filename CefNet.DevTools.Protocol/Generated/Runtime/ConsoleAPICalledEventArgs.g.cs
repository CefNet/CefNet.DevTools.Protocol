//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class ConsoleAPICalledEventArgs
        : System.EventArgs
    {
        /// <summary>Type of the call.</summary>
        public CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType Type { get; set; }

        /// <summary>Call arguments.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.RemoteObject> Args { get; set; }

        /// <summary>
        /// Identifier of the context where the call was made.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId ExecutionContextId { get; set; }

        /// <summary>Call timestamp.</summary>
        public CefNet.DevTools.Protocol.Runtime.Timestamp Timestamp { get; set; }

        /// <summary>
        /// Stack trace captured when the call was made. The async stack chain is automatically reported for
        /// the following call types: `assert`, `error`, `trace`, `warning`. For other types the async call
        /// chain can be retrieved using `Debugger.getStackTrace` and `stackTrace.parentId` field.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? StackTrace { get; set; }

        /// <summary>
        /// [Experimental] Console context descriptor for calls on non-default console context (not console.*):
        /// 'anonymous#unique-logger-id' for call on unnamed context, 'name#unique-logger-id' for call
        /// on named context.
        /// </summary>
        public string? Context { get; set; }
    }
}
