//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class GetHistogramRequest
    {
        /// <summary>Requested histogram name.</summary>
        public string Name { get; set; }

        /// <summary>If true, retrieve delta since last call.</summary>
        public bool? Delta { get; set; }
    }
}
