//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Detailed information about exception (or error) that was thrown during script compilation or
    /// execution.
    /// </summary>
    public sealed class ExceptionDetails
    {
        /// <summary>Exception id.</summary>
        public int ExceptionId { get; set; }

        /// <summary>
        /// Exception text, which should be used together with exception object when available.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Line number of the exception location (0-based).
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Column number of the exception location (0-based).
        /// </summary>
        public int ColumnNumber { get; set; }

        /// <summary>Script ID of the exception location.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId? ScriptId { get; set; }

        /// <summary>
        /// URL of the exception location, to be used when the script was not reported.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>JavaScript stack trace if available.</summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? StackTrace { get; set; }

        /// <summary>Exception object if available.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Exception { get; set; }

        /// <summary>
        /// Identifier of the context where exception happened.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }

        /// <summary>
        /// [Experimental] Dictionary with entries of meta data that the client associated
        /// with this exception, such as information about associated network
        /// requests, etc.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object>? ExceptionMetaData { get; set; }
    }
}
