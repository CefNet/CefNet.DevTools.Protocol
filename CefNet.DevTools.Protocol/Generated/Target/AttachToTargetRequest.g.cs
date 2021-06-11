//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class AttachToTargetRequest
    {
        public CefNet.DevTools.Protocol.Target.TargetID TargetId { get; set; }

        /// <summary>
        /// Enables "flat" access to the session via specifying sessionId attribute in the commands.
        /// We plan to make this the default, deprecate non-flattened mode,
        /// and eventually retire it. See crbug.com/991325.
        /// </summary>
        public bool? Flatten { get; set; }
    }
}
