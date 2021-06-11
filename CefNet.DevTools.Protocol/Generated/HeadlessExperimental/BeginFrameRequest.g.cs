//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeadlessExperimental
{
    public sealed class BeginFrameRequest
    {
        /// <summary>
        /// Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set,
        /// the current time will be used.
        /// </summary>
        public double? FrameTimeTicks { get; set; }

        /// <summary>
        /// The interval between BeginFrames that is reported to the compositor, in milliseconds.
        /// Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
        /// </summary>
        public double? Interval { get; set; }

        /// <summary>
        /// Whether updates should not be committed and drawn onto the display. False by default. If
        /// true, only side effects of the BeginFrame will be run, such as layout and animations, but
        /// any visual updates may not be visible on the display or in screenshots.
        /// </summary>
        public bool? NoDisplayUpdates { get; set; }

        /// <summary>
        /// If set, a screenshot of the frame will be captured and returned in the response. Otherwise,
        /// no screenshot will be captured. Note that capturing a screenshot can fail, for example,
        /// during renderer initialization. In such a case, no screenshot data will be returned.
        /// </summary>
        public CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParams? Screenshot { get; set; }
    }
}
