//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Animation
{
    public sealed class SeekAnimationsRequest
    {
        /// <summary>List of animation ids to seek.</summary>
        public System.Collections.Generic.List<string> Animations { get; set; }

        /// <summary>Set the current time of each animation.</summary>
        public double CurrentTime { get; set; }
    }
}