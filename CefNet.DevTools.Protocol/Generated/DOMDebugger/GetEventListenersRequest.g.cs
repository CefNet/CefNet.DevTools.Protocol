//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    public sealed class GetEventListenersRequest
    {
        /// <summary>
        /// Identifier of the object to return listeners for.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId ObjectId { get; set; }

        /// <summary>
        /// The maximum depth at which Node children should be retrieved, defaults to 1. Use -1 for the
        /// entire subtree or provide an integer larger than 0.
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the subtree
        /// (default is false). Reports listeners for all contexts if pierce is enabled.
        /// </summary>
        public bool? Pierce { get; set; }
    }
}
