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
    /// Details for a issue arising from an SAB being instantiated in, or
    /// transferred to a context that is not cross-origin isolated.
    /// </summary>
    public sealed class SharedArrayBufferIssueDetails
    {
        public CefNet.DevTools.Protocol.Audits.SourceCodeLocation SourceCodeLocation { get; set; }

        public bool IsWarning { get; set; }

        public CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType Type { get; set; }
    }
}
