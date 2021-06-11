//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    /// <summary>[Experimental] </summary>
    public sealed class DragDataItem
    {
        /// <summary>Mime type of the dragged data.</summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Depending of the value of `mimeType`, it contains the dragged link,
        /// text, HTML markup or any other data.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Title associated with a link. Only valid when `mimeType` == "text/uri-list".
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Stores the base URL for the contained markup. Only valid when `mimeType`
        /// == "text/html".
        /// </summary>
        public string? BaseURL { get; set; }
    }
}
