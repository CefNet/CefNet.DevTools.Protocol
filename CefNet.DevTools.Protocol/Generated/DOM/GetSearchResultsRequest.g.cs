//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class GetSearchResultsRequest
    {
        /// <summary>Unique search session identifier.</summary>
        public string SearchId { get; set; }

        /// <summary>
        /// Start index of the search result to be returned.
        /// </summary>
        public int FromIndex { get; set; }

        /// <summary>
        /// End index of the search result to be returned.
        /// </summary>
        public int ToIndex { get; set; }
    }
}
