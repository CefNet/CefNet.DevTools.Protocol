//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// Information about a request that is affected by an inspector issue.
    /// </summary>
    public sealed class AffectedRequest
    {
        /// <summary>The unique request id.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        public string? Url { get; set; }
    }
}
