//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>Protocol object for AudioParam</summary>
    public sealed class AudioParam
    {
        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId ParamId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId NodeId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId ContextId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ParamType ParamType { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.AutomationRate Rate { get; set; }

        public double DefaultValue { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }
    }
}
