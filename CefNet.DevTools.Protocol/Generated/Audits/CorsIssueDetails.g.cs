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
    /// Details for a CORS related issue, e.g. a warning or error related to
    /// CORS RFC1918 enforcement.
    /// </summary>
    public sealed class CorsIssueDetails
    {
        public CefNet.DevTools.Protocol.Network.CorsErrorStatus CorsErrorStatus { get; set; }

        public bool IsWarning { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedRequest Request { get; set; }

        public CefNet.DevTools.Protocol.Audits.SourceCodeLocation? Location { get; set; }

        public string? InitiatorOrigin { get; set; }

        public CefNet.DevTools.Protocol.Network.IPAddressSpace? ResourceIPAddressSpace { get; set; }

        public CefNet.DevTools.Protocol.Network.ClientSecurityState? ClientSecurityState { get; set; }
    }
}
