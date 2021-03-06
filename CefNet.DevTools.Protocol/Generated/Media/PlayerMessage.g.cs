//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Media
{
    /// <summary>
    /// Have one type per entry in MediaLogRecord::Type
    /// Corresponds to kMessage
    /// </summary>
    public sealed class PlayerMessage
    {
        /// <summary>
        /// Keep in sync with MediaLogMessageLevel
        /// We are currently keeping the message level 'error' separate from the
        /// PlayerError type because right now they represent different things,
        /// this one being a DVLOG(ERROR) style log message that gets printed
        /// based on what log level is selected in the UI, and the other is a
        /// representation of a media::PipelineStatus object. Soon however we're
        /// going to be moving away from using PipelineStatus for errors and
        /// introducing a new error type which should hopefully let us integrate
        /// the error log level into the PlayerError type.
        /// </summary>
        public CefNet.DevTools.Protocol.Media.PlayerMessageLevel Level { get; set; }

        public string Message { get; set; }
    }
}
