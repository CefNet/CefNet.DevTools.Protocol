//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAudio
{
    public sealed class NodeParamConnectedEventArgs
        : System.EventArgs
    {
        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId ContextId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId SourceId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId DestinationId { get; set; }

        public double? SourceOutputIndex { get; set; }
    }
}
