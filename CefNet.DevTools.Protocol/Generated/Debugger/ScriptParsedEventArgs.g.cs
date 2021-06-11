//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class ScriptParsedEventArgs
        : System.EventArgs
    {
        /// <summary>Identifier of the script parsed.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>
        /// URL or name of the script parsed (if any).
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Line offset of the script within the resource with given URL (for script tags).
        /// </summary>
        public int StartLine { get; set; }

        /// <summary>
        /// Column offset of the script within the resource with given URL.
        /// </summary>
        public int StartColumn { get; set; }

        /// <summary>Last line of the script.</summary>
        public int EndLine { get; set; }

        /// <summary>Length of the last line of the script.</summary>
        public int EndColumn { get; set; }

        /// <summary>Specifies script creation context.</summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId ExecutionContextId { get; set; }

        /// <summary>Content hash of the script.</summary>
        public string Hash { get; set; }

        /// <summary>Embedder-specific auxiliary data.</summary>
        public System.Collections.Generic.Dictionary<string, object>? ExecutionContextAuxData { get; set; }

        /// <summary>
        /// [Experimental] True, if this script is generated as a result of the live edit operation.
        /// </summary>
        public bool? IsLiveEdit { get; set; }

        /// <summary>
        /// URL of source map associated with script (if any).
        /// </summary>
        public string? SourceMapURL { get; set; }

        /// <summary>True, if this script has sourceURL.</summary>
        public bool? HasSourceURL { get; set; }

        /// <summary>True, if this script is ES6 module.</summary>
        public bool? IsModule { get; set; }

        /// <summary>This script length.</summary>
        public int? Length { get; set; }

        /// <summary>
        /// [Experimental] JavaScript top stack frame of where the script parsed event was triggered if available.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? StackTrace { get; set; }

        /// <summary>
        /// [Experimental] If the scriptLanguage is WebAssembly, the code section offset in the module.
        /// </summary>
        public int? CodeOffset { get; set; }

        /// <summary>
        /// [Experimental] The language of the script.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.ScriptLanguage? ScriptLanguage { get; set; }

        /// <summary>
        /// [Experimental] If the scriptLanguage is WebASsembly, the source of debug symbols for the module.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.DebugSymbols? DebugSymbols { get; set; }

        /// <summary>
        /// [Experimental] The name the embedder supplied for this script.
        /// </summary>
        public string? EmbedderName { get; set; }
    }
}
