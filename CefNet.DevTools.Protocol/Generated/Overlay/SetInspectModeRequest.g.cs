//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class SetInspectModeRequest
    {
        /// <summary>Set an inspection mode.</summary>
        public CefNet.DevTools.Protocol.Overlay.InspectMode Mode { get; set; }

        /// <summary>
        /// A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled
        /// == false`.
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.HighlightConfig? HighlightConfig { get; set; }
    }
}
