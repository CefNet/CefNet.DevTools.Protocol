//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class ExceptionThrownEventArgs
        : System.EventArgs
    {
        /// <summary>Timestamp of the exception.</summary>
        public CefNet.DevTools.Protocol.Runtime.Timestamp Timestamp { get; set; }

        public CefNet.DevTools.Protocol.Runtime.ExceptionDetails ExceptionDetails { get; set; }
    }
}