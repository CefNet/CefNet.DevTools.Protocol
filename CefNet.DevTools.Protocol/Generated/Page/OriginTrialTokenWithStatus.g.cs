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
    public sealed class OriginTrialTokenWithStatus
    {
        public string RawTokenText { get; set; }

        /// <summary>
        /// `parsedToken` is present only when the token is extractable and
        /// parsable.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.OriginTrialToken? ParsedToken { get; set; }

        public CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus Status { get; set; }
    }
}
