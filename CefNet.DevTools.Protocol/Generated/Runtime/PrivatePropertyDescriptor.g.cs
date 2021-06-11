//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// [Experimental] Object private field descriptor.
    /// </summary>
    public sealed class PrivatePropertyDescriptor
    {
        /// <summary>Private property name.</summary>
        public string Name { get; set; }

        /// <summary>
        /// The value associated with the private property.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Value { get; set; }

        /// <summary>
        /// A function which serves as a getter for the private property,
        /// or `undefined` if there is no getter (accessor descriptors only).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Get { get; set; }

        /// <summary>
        /// A function which serves as a setter for the private property,
        /// or `undefined` if there is no setter (accessor descriptors only).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Set { get; set; }
    }
}
