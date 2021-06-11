//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class ReceivedMessageFromTargetEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Identifier of a session which sends a message.
        /// </summary>
        public CefNet.DevTools.Protocol.Target.SessionID SessionId { get; set; }

        public string Message { get; set; }

        /// <summary>[Deprecated] Deprecated.</summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Target.TargetID? TargetId { get; set; }
    }
}
