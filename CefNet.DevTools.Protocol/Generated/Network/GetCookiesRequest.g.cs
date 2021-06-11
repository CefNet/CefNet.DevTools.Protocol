//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class GetCookiesRequest
    {
        /// <summary>
        /// The list of URLs for which applicable cookies will be fetched.
        /// If not specified, it's assumed to be set to the list containing
        /// the URLs of the page and all of its subframes.
        /// </summary>
        public System.Collections.Generic.List<string>? Urls { get; set; }
    }
}
