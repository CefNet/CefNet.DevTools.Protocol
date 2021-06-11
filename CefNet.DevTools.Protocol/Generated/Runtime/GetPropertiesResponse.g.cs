//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class GetPropertiesResponse
    {
        /// <summary>Object properties.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.PropertyDescriptor> Result { get; set; }

        /// <summary>
        /// Internal object properties (only of the element itself).
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.InternalPropertyDescriptor>? InternalProperties { get; set; }

        /// <summary>
        /// [Experimental] Object private properties.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.PrivatePropertyDescriptor>? PrivateProperties { get; set; }

        /// <summary>Exception details.</summary>
        public CefNet.DevTools.Protocol.Runtime.ExceptionDetails? ExceptionDetails { get; set; }
    }
}
