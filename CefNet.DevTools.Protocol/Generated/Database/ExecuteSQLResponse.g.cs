//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Database
{
    public sealed class ExecuteSQLResponse
    {
        public System.Collections.Generic.List<string>? ColumnNames { get; set; }

        public System.Collections.Generic.List<object>? Values { get; set; }

        public CefNet.DevTools.Protocol.Database.Error? SqlError { get; set; }
    }
}
