//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class ForcePseudoStateRequest
    {
        /// <summary>
        /// The element id for which to force the pseudo state.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>
        /// Element pseudo classes to force when computing the element's style.
        /// </summary>
        public System.Collections.Generic.List<string> ForcedPseudoClasses { get; set; }
    }
}
