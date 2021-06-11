//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>[Experimental] </summary>
    public sealed class OriginTrial
    {
        public string TrialName { get; set; }

        public CefNet.DevTools.Protocol.Page.OriginTrialStatus Status { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.OriginTrialTokenWithStatus> TokensWithStatus { get; set; }
    }
}
