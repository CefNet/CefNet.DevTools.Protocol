//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// Information about a cookie that is affected by an inspector issue.
    /// </summary>
    public sealed class AffectedCookie
    {
        /// <summary>
        /// The following three properties uniquely identify a cookie
        /// </summary>
        public string Name { get; set; }

        public string Path { get; set; }

        public string Domain { get; set; }
    }
}
