//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class AwaitPromiseRequest
    {
        /// <summary>Identifier of the promise.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId PromiseObjectId { get; set; }

        /// <summary>
        /// Whether the result is expected to be a JSON object that should be sent by value.
        /// </summary>
        public bool? ReturnByValue { get; set; }

        /// <summary>
        /// Whether preview should be generated for the result.
        /// </summary>
        public bool? GeneratePreview { get; set; }
    }
}
