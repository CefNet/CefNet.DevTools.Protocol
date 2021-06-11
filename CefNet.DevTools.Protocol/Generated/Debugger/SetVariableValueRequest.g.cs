//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetVariableValueRequest
    {
        /// <summary>
        /// 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch'
        /// scope types are allowed. Other scopes could be manipulated manually.
        /// </summary>
        public int ScopeNumber { get; set; }

        /// <summary>Variable name.</summary>
        public string VariableName { get; set; }

        /// <summary>New variable value.</summary>
        public CefNet.DevTools.Protocol.Runtime.CallArgument NewValue { get; set; }

        /// <summary>Id of callframe that holds variable.</summary>
        public CefNet.DevTools.Protocol.Debugger.CallFrameId CallFrameId { get; set; }
    }
}
