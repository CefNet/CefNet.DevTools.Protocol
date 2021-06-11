//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Animation
{
    /// <summary>AnimationEffect instance</summary>
    public sealed class AnimationEffect
    {
        /// <summary>`AnimationEffect`'s delay.</summary>
        public double Delay { get; set; }

        /// <summary>`AnimationEffect`'s end delay.</summary>
        public double EndDelay { get; set; }

        /// <summary>`AnimationEffect`'s iteration start.</summary>
        public double IterationStart { get; set; }

        /// <summary>`AnimationEffect`'s iterations.</summary>
        public double Iterations { get; set; }

        /// <summary>`AnimationEffect`'s iteration duration.</summary>
        public double Duration { get; set; }

        /// <summary>`AnimationEffect`'s playback direction.</summary>
        public string Direction { get; set; }

        /// <summary>`AnimationEffect`'s fill mode.</summary>
        public string Fill { get; set; }

        /// <summary>`AnimationEffect`'s target node.</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }

        /// <summary>`AnimationEffect`'s keyframes.</summary>
        public CefNet.DevTools.Protocol.Animation.KeyframesRule? KeyframesRule { get; set; }

        /// <summary>`AnimationEffect`'s timing function.</summary>
        public string Easing { get; set; }
    }
}
