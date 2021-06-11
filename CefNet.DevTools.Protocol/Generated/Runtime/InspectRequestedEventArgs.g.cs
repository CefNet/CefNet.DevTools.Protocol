//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class InspectRequestedEventArgs
        : System.EventArgs
    {
        public CefNet.DevTools.Protocol.Runtime.RemoteObject Object { get; set; }

        public System.Collections.Generic.Dictionary<string, object> Hints { get; set; }
    }
}
