//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class StartScreencastRequest
    {
        /// <summary>Image compression format.</summary>
        public CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat? Format { get; set; }

        /// <summary>Compression quality from range [0..100].</summary>
        public int? Quality { get; set; }

        /// <summary>Maximum screenshot width.</summary>
        public int? MaxWidth { get; set; }

        /// <summary>Maximum screenshot height.</summary>
        public int? MaxHeight { get; set; }

        /// <summary>Send every n-th frame.</summary>
        public int? EveryNthFrame { get; set; }
    }
}
