//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class SourceCodeLocation
    {
        public CefNet.DevTools.Protocol.Runtime.ScriptId? ScriptId { get; set; }

        public string Url { get; set; }

        public int LineNumber { get; set; }

        public int ColumnNumber { get; set; }
    }
}
