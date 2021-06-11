//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class GetNavigationHistoryResponse
    {
        /// <summary>
        /// Index of the current navigation history entry.
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>Array of navigation history entries.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.NavigationEntry> Entries { get; set; }
    }
}
