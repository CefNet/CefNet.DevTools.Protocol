//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Animation
{
    /// <summary>Animation instance.</summary>
    public sealed class Animation
    {
        /// <summary>`Animation`'s id.</summary>
        public string Id { get; set; }

        /// <summary>`Animation`'s name.</summary>
        public string Name { get; set; }

        /// <summary>`Animation`'s internal paused state.</summary>
        public bool PausedState { get; set; }

        /// <summary>`Animation`'s play state.</summary>
        public string PlayState { get; set; }

        /// <summary>`Animation`'s playback rate.</summary>
        public double PlaybackRate { get; set; }

        /// <summary>`Animation`'s start time.</summary>
        public double StartTime { get; set; }

        /// <summary>`Animation`'s current time.</summary>
        public double CurrentTime { get; set; }

        /// <summary>Animation type of `Animation`.</summary>
        public CefNet.DevTools.Protocol.Animation.AnimationType Type { get; set; }

        /// <summary>`Animation`'s source animation node.</summary>
        public CefNet.DevTools.Protocol.Animation.AnimationEffect? Source { get; set; }

        /// <summary>
        /// A unique ID for `Animation` representing the sources that triggered this CSS
        /// animation/transition.
        /// </summary>
        public string? CssId { get; set; }
    }
}
