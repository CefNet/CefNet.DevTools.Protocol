//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SearchInContentRequest
    {
        /// <summary>Id of the script to search in.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>String to search for.</summary>
        public string Query { get; set; }

        /// <summary>If true, search is case sensitive.</summary>
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// If true, treats string parameter as regex.
        /// </summary>
        public bool? IsRegex { get; set; }
    }
}
