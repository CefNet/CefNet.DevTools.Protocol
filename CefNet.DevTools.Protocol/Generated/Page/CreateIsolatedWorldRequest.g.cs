//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class CreateIsolatedWorldRequest
    {
        /// <summary>
        /// Id of the frame in which the isolated world should be created.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// An optional name which is reported in the Execution Context.
        /// </summary>
        public string? WorldName { get; set; }

        /// <summary>
        /// Whether or not universal access should be granted to the isolated world. This is a powerful
        /// option, use with caution.
        /// </summary>
        public bool? GrantUniveralAccess { get; set; }
    }
}
