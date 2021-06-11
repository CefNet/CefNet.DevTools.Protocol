//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Media
{
    /// <summary>Corresponds to kMediaError</summary>
    public sealed class PlayerError
    {
        public CefNet.DevTools.Protocol.Media.PlayerErrorType Type { get; set; }

        /// <summary>
        /// When this switches to using media::Status instead of PipelineStatus
        /// we can remove "errorCode" and replace it with the fields from
        /// a Status instance. This also seems like a duplicate of the error
        /// level enum - there is a todo bug to have that level removed and
        /// use this instead. (crbug.com/1068454)
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
