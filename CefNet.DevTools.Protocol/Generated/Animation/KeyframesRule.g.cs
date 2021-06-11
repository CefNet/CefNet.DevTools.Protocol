//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Animation
{
    /// <summary>Keyframes Rule</summary>
    public sealed class KeyframesRule
    {
        /// <summary>CSS keyframed animation's name.</summary>
        public string? Name { get; set; }

        /// <summary>List of animation keyframes.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Animation.KeyframeStyle> Keyframes { get; set; }
    }
}
