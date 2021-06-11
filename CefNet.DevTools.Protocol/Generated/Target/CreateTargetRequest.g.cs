//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class CreateTargetRequest
    {
        /// <summary>
        /// The initial URL the page will be navigated to. An empty string indicates about:blank.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Frame width in DIP (headless chrome only).
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Frame height in DIP (headless chrome only).
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// The browser context to create the page in.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }

        /// <summary>
        /// [Experimental] Whether BeginFrames for this target will be controlled via DevTools (headless chrome only,
        /// not supported on MacOS yet, false by default).
        /// </summary>
        public bool? EnableBeginFrameControl { get; set; }

        /// <summary>
        /// Whether to create a new Window or Tab (chrome-only, false by default).
        /// </summary>
        public bool? NewWindow { get; set; }

        /// <summary>
        /// Whether to create the target in background or foreground (chrome-only,
        /// false by default).
        /// </summary>
        public bool? Background { get; set; }
    }
}
