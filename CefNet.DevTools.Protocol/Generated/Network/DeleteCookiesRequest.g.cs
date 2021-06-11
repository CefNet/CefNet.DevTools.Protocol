//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class DeleteCookiesRequest
    {
        /// <summary>Name of the cookies to remove.</summary>
        public string Name { get; set; }

        /// <summary>
        /// If specified, deletes all the cookies with the given name where domain and path match
        /// provided URL.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// If specified, deletes only cookies with the exact domain.
        /// </summary>
        public string? Domain { get; set; }

        /// <summary>
        /// If specified, deletes only cookies with the exact path.
        /// </summary>
        public string? Path { get; set; }
    }
}
