//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Security
{
    /// <summary>[Experimental] </summary>
    public sealed class SafetyTipInfo
    {
        /// <summary>
        /// Describes whether the page triggers any safety tips or reputation warnings. Default is unknown.
        /// </summary>
        public CefNet.DevTools.Protocol.Security.SafetyTipStatus SafetyTipStatus { get; set; }

        /// <summary>
        /// The URL the safety tip suggested ("Did you mean?"). Only filled in for lookalike matches.
        /// </summary>
        public string? SafeUrl { get; set; }
    }
}
