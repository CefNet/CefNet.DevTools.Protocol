//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    /// <summary>Scope description.</summary>
    public sealed class Scope
    {
        /// <summary>Scope type.</summary>
        public CefNet.DevTools.Protocol.Debugger.ScopeType Type { get; set; }

        /// <summary>
        /// Object representing the scope. For `global` and `with` scopes it represents the actual
        /// object; for the rest of the scopes, it is artificial transient object enumerating scope
        /// variables as its properties.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject Object { get; set; }

        public string? Name { get; set; }

        /// <summary>
        /// Location in the source code where scope starts
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.Location? StartLocation { get; set; }

        /// <summary>
        /// Location in the source code where scope ends
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.Location? EndLocation { get; set; }
    }
}
