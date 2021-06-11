//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class AttachedToTargetEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Identifier assigned to the session used to send/receive messages.
        /// </summary>
        public CefNet.DevTools.Protocol.Target.SessionID SessionId { get; set; }

        public CefNet.DevTools.Protocol.Target.TargetInfo TargetInfo { get; set; }

        public bool WaitingForDebugger { get; set; }
    }
}
