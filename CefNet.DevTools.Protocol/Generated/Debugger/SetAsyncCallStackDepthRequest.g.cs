//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetAsyncCallStackDepthRequest
    {
        /// <summary>
        /// Maximum depth of async call stacks. Setting to `0` will effectively disable collecting async
        /// call stacks (default).
        /// </summary>
        public int MaxDepth { get; set; }
    }
}
