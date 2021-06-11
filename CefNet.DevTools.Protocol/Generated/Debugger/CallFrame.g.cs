//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    /// <summary>
    /// JavaScript call frame. Array of call frames form the call stack.
    /// </summary>
    public sealed class CallFrame
    {
        /// <summary>
        /// Call frame identifier. This identifier is only valid while the virtual machine is paused.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.CallFrameId CallFrameId { get; set; }

        /// <summary>
        /// Name of the JavaScript function called on this call frame.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>Location in the source code.</summary>
        public CefNet.DevTools.Protocol.Debugger.Location? FunctionLocation { get; set; }

        /// <summary>Location in the source code.</summary>
        public CefNet.DevTools.Protocol.Debugger.Location Location { get; set; }

        /// <summary>JavaScript script name or url.</summary>
        public string Url { get; set; }

        /// <summary>Scope chain for this call frame.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Debugger.Scope> ScopeChain { get; set; }

        /// <summary>`this` object for this call frame.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject This { get; set; }

        /// <summary>
        /// The value being returned, if the function is at return point.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? ReturnValue { get; set; }
    }
}
