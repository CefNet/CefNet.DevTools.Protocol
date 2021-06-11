//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Animation
{
    public sealed class SetTimingRequest
    {
        /// <summary>Animation id.</summary>
        public string AnimationId { get; set; }

        /// <summary>Duration of the animation.</summary>
        public double Duration { get; set; }

        /// <summary>Delay of the animation.</summary>
        public double Delay { get; set; }
    }
}
