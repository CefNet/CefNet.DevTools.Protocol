//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class QueryObjectsRequest
    {
        /// <summary>
        /// Identifier of the prototype to return objects for.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId PrototypeObjectId { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release the results.
        /// </summary>
        public string? ObjectGroup { get; set; }
    }
}
