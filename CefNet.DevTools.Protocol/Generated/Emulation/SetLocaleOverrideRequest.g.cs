//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetLocaleOverrideRequest
    {
        /// <summary>
        /// ICU style C locale (e.g. "en_US"). If not specified or empty, disables the override and
        /// restores default host system locale.
        /// </summary>
        public string? Locale { get; set; }
    }
}
