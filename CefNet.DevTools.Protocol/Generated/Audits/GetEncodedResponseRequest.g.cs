//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class GetEncodedResponseRequest
    {
        /// <summary>
        /// Identifier of the network request to get content for.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>The encoding to use.</summary>
        public CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding Encoding { get; set; }

        /// <summary>
        /// The quality of the encoding (0-1). (defaults to 1)
        /// </summary>
        public double? Quality { get; set; }

        /// <summary>
        /// Whether to only return the size information (defaults to false).
        /// </summary>
        public bool? SizeOnly { get; set; }
    }
}
