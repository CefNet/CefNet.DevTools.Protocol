//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class DownloadWillBeginEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Id of the frame that caused download to begin.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// Global unique identifier of the download.
        /// </summary>
        public string Guid { get; set; }

        /// <summary>URL of the resource being downloaded.</summary>
        public string Url { get; set; }

        /// <summary>
        /// Suggested file name of the resource (the actual name of the file saved on disk may differ).
        /// </summary>
        public string SuggestedFilename { get; set; }
    }
}
