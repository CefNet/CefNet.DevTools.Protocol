//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class AwaitPromiseResponse
    {
        /// <summary>
        /// Promise result. Will contain rejected value if promise was rejected.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject Result { get; set; }

        /// <summary>
        /// Exception details if stack strace is available.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExceptionDetails? ExceptionDetails { get; set; }
    }
}
