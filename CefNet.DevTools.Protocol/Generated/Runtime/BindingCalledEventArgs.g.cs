//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class BindingCalledEventArgs
        : System.EventArgs
    {
        public string Name { get; set; }

        public string Payload { get; set; }

        /// <summary>
        /// Identifier of the context where the call was made.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId ExecutionContextId { get; set; }
    }
}
