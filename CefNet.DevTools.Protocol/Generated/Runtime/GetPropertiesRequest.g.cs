//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class GetPropertiesRequest
    {
        /// <summary>
        /// Identifier of the object to return properties for.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId ObjectId { get; set; }

        /// <summary>
        /// If true, returns properties belonging only to the element itself, not to its prototype
        /// chain.
        /// </summary>
        public bool? OwnProperties { get; set; }

        /// <summary>
        /// [Experimental] If true, returns accessor properties (with getter/setter) only; internal properties are not
        /// returned either.
        /// </summary>
        public bool? AccessorPropertiesOnly { get; set; }

        /// <summary>
        /// [Experimental] Whether preview should be generated for the results.
        /// </summary>
        public bool? GeneratePreview { get; set; }
    }
}
