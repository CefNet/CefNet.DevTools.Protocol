//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>[Experimental] </summary>
    public sealed class CustomPreview
    {
        /// <summary>
        /// The JSON-stringified result of formatter.header(object, config) call.
        /// It contains json ML array that represents RemoteObject.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// If formatter returns true as a result of formatter.hasBody call then bodyGetterId will
        /// contain RemoteObjectId for the function that returns result of formatter.body(object, config) call.
        /// The result value is json ML array.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? BodyGetterId { get; set; }
    }
}
