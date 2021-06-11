//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>Protocol object for BaseAudioContext</summary>
    public sealed class BaseAudioContext
    {
        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId ContextId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ContextType ContextType { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ContextState ContextState { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ContextRealtimeData? RealtimeData { get; set; }

        /// <summary>Platform-dependent callback buffer size.</summary>
        public double CallbackBufferSize { get; set; }

        /// <summary>
        /// Number of output channels supported by audio hardware in use.
        /// </summary>
        public double MaxOutputChannelCount { get; set; }

        /// <summary>Context sample rate.</summary>
        public double SampleRate { get; set; }
    }
}
