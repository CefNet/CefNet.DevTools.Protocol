//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>
    /// Fields in AudioContext that change in real-time.
    /// </summary>
    public sealed class ContextRealtimeData
    {
        /// <summary>
        /// The current context time in second in BaseAudioContext.
        /// </summary>
        public double CurrentTime { get; set; }

        /// <summary>
        /// The time spent on rendering graph divided by render quantum duration,
        /// and multiplied by 100. 100 means the audio renderer reached the full
        /// capacity and glitch may occur.
        /// </summary>
        public double RenderCapacity { get; set; }

        /// <summary>A running mean of callback interval.</summary>
        public double CallbackIntervalMean { get; set; }

        /// <summary>A running variance of callback interval.</summary>
        public double CallbackIntervalVariance { get; set; }
    }
}
