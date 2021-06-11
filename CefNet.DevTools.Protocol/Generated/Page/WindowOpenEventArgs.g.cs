//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class WindowOpenEventArgs
        : System.EventArgs
    {
        /// <summary>The URL for the new window.</summary>
        public string Url { get; set; }

        /// <summary>Window name.</summary>
        public string WindowName { get; set; }

        /// <summary>An array of enabled window features.</summary>
        public System.Collections.Generic.List<string> WindowFeatures { get; set; }

        /// <summary>
        /// Whether or not it was triggered by user gesture.
        /// </summary>
        public bool UserGesture { get; set; }
    }
}
