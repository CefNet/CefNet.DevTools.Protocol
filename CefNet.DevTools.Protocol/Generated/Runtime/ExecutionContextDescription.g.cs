//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>Description of an isolated world.</summary>
    public sealed class ExecutionContextDescription
    {
        /// <summary>
        /// Unique id of the execution context. It can be used to specify in which execution context
        /// script evaluation should be performed.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId Id { get; set; }

        /// <summary>Execution context origin.</summary>
        public string Origin { get; set; }

        /// <summary>
        /// Human readable name describing given context.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [Experimental] A system-unique execution context identifier. Unlike the id, this is unique accross
        /// multiple processes, so can be reliably used to identify specific context while backend
        /// performs a cross-process navigation.
        /// </summary>
        public string UniqueId { get; set; }

        /// <summary>Embedder-specific auxiliary data.</summary>
        public System.Collections.Generic.Dictionary<string, object>? AuxData { get; set; }
    }
}
