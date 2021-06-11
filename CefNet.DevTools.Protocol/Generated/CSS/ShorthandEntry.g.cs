//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class ShorthandEntry
    {
        /// <summary>Shorthand name.</summary>
        public string Name { get; set; }

        /// <summary>Shorthand value.</summary>
        public string Value { get; set; }

        /// <summary>
        /// Whether the property has "!important" annotation (implies `false` if absent).
        /// </summary>
        public bool? Important { get; set; }
    }
}
