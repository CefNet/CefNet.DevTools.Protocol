//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tethering
{
    public sealed class AcceptedEventArgs
        : System.EventArgs
    {
        /// <summary>Port number that was successfully bound.</summary>
        public int Port { get; set; }

        /// <summary>Connection id to be used.</summary>
        public string ConnectionId { get; set; }
    }
}
