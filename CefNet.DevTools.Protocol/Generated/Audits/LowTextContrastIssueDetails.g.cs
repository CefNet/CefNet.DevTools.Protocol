//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class LowTextContrastIssueDetails
    {
        public CefNet.DevTools.Protocol.DOM.BackendNodeId ViolatingNodeId { get; set; }

        public string ViolatingNodeSelector { get; set; }

        public double ContrastRatio { get; set; }

        public double ThresholdAA { get; set; }

        public double ThresholdAAA { get; set; }

        public string FontSize { get; set; }

        public string FontWeight { get; set; }
    }
}
