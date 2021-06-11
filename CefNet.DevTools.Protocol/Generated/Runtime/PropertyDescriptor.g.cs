//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>Object property descriptor.</summary>
    public sealed class PropertyDescriptor
    {
        /// <summary>Property name or symbol description.</summary>
        public string Name { get; set; }

        /// <summary>The value associated with the property.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Value { get; set; }

        /// <summary>
        /// True if the value associated with the property may be changed (data descriptors only).
        /// </summary>
        public bool? Writable { get; set; }

        /// <summary>
        /// A function which serves as a getter for the property, or `undefined` if there is no getter
        /// (accessor descriptors only).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Get { get; set; }

        /// <summary>
        /// A function which serves as a setter for the property, or `undefined` if there is no setter
        /// (accessor descriptors only).
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Set { get; set; }

        /// <summary>
        /// True if the type of this property descriptor may be changed and if the property may be
        /// deleted from the corresponding object.
        /// </summary>
        public bool Configurable { get; set; }

        /// <summary>
        /// True if this property shows up during enumeration of the properties on the corresponding
        /// object.
        /// </summary>
        public bool Enumerable { get; set; }

        /// <summary>
        /// True if the result was thrown during the evaluation.
        /// </summary>
        public bool? WasThrown { get; set; }

        /// <summary>
        /// True if the property is owned for the object.
        /// </summary>
        public bool? IsOwn { get; set; }

        /// <summary>
        /// Property symbol object, if the property is of the `symbol` type.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Symbol { get; set; }
    }
}
