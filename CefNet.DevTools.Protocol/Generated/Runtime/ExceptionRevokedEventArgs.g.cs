//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class ExceptionRevokedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Reason describing why exception was revoked.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The id of revoked exception, as reported in `exceptionThrown`.
        /// </summary>
        public int ExceptionId { get; set; }
    }
}
