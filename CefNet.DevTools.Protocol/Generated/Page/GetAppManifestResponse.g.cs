//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class GetAppManifestResponse
    {
        /// <summary>Manifest location.</summary>
        public string Url { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.AppManifestError> Errors { get; set; }

        /// <summary>Manifest content.</summary>
        public string? Data { get; set; }

        /// <summary>
        /// [Experimental] Parsed manifest properties
        /// </summary>
        public CefNet.DevTools.Protocol.Page.AppManifestParsedProperties? Parsed { get; set; }
    }
}
