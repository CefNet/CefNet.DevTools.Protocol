//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetDefaultBackgroundColorOverrideRequest
    {
        /// <summary>
        /// RGBA of the default background color. If not specified, any existing override will be
        /// cleared.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? Color { get; set; }
    }
}
