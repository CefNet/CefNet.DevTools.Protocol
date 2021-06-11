//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    public sealed class CompileScriptRequest
    {
        /// <summary>Expression to compile.</summary>
        public string Expression { get; set; }

        /// <summary>Source url to be set for the script.</summary>
        public string SourceURL { get; set; }

        /// <summary>
        /// Specifies whether the compiled script should be persisted.
        /// </summary>
        public bool PersistScript { get; set; }

        /// <summary>
        /// Specifies in which execution context to perform script run. If the parameter is omitted the
        /// evaluation will be performed in the context of the inspected page.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }
    }
}
