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
    /// Details for issues about documents in Quirks Mode
    /// or Limited Quirks Mode that affects page layouting.
    /// </summary>
    public sealed class QuirksModeIssueDetails
    {
        /// <summary>
        /// If false, it means the document's mode is "quirks"
        /// instead of "limited-quirks".
        /// </summary>
        public bool IsLimitedQuirksMode { get; set; }

        public CefNet.DevTools.Protocol.DOM.BackendNodeId DocumentNodeId { get; set; }

        public string Url { get; set; }

        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        public CefNet.DevTools.Protocol.Network.LoaderId LoaderId { get; set; }
    }
}
