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
    public sealed class OriginTrialToken
    {
        public string Origin { get; set; }

        public bool MatchSubDomains { get; set; }

        public string TrialName { get; set; }

        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch ExpiryTime { get; set; }

        public bool IsThirdParty { get; set; }

        public CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction UsageRestriction { get; set; }
    }
}
