//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Media
{
    public sealed class PlayerPropertiesChangedEventArgs
        : System.EventArgs
    {
        public CefNet.DevTools.Protocol.Media.PlayerId PlayerId { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Media.PlayerProperty> Properties { get; set; }
    }
}
