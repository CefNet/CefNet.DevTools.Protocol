//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class AddScriptToEvaluateOnNewDocumentRequest
    {
        public string Source { get; set; }

        /// <summary>
        /// [Experimental] If specified, creates an isolated world with the given name and evaluates given script in it.
        /// This world name will be used as the ExecutionContextDescription::name when the corresponding
        /// event is emitted.
        /// </summary>
        public string? WorldName { get; set; }

        /// <summary>
        /// [Experimental] Specifies whether command line API should be available to the script, defaults
        /// to false.
        /// </summary>
        public bool? IncludeCommandLineAPI { get; set; }
    }
}
