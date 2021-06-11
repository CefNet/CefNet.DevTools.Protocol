//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Security
{
    public sealed class CertificateErrorEventArgs
        : System.EventArgs
    {
        /// <summary>The ID of the event.</summary>
        public int EventId { get; set; }

        /// <summary>The type of the error.</summary>
        public string ErrorType { get; set; }

        /// <summary>The url that was requested.</summary>
        public string RequestURL { get; set; }
    }
}
