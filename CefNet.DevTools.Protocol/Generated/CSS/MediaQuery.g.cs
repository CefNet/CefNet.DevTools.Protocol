//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>Media query descriptor.</summary>
    public sealed class MediaQuery
    {
        /// <summary>Array of media query expressions.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.MediaQueryExpression> Expressions { get; set; }

        /// <summary>
        /// Whether the media query condition is satisfied.
        /// </summary>
        public bool Active { get; set; }
    }
}
