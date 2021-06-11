//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class GenerateTestReportRequest
    {
        /// <summary>Message to be displayed in the report.</summary>
        public string Message { get; set; }

        /// <summary>
        /// Specifies the endpoint group to deliver the report to.
        /// </summary>
        public string? Group { get; set; }
    }
}
