//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class TargetCrashedEventArgs
        : System.EventArgs
    {
        public CefNet.DevTools.Protocol.Target.TargetID TargetId { get; set; }

        /// <summary>Termination status type.</summary>
        public string Status { get; set; }

        /// <summary>Termination error code.</summary>
        public int ErrorCode { get; set; }
    }
}
