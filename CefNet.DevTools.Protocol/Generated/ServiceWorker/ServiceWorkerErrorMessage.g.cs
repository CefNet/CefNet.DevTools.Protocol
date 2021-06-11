//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    /// <summary>ServiceWorker error message.</summary>
    public sealed class ServiceWorkerErrorMessage
    {
        public string ErrorMessage { get; set; }

        public CefNet.DevTools.Protocol.ServiceWorker.RegistrationID RegistrationId { get; set; }

        public string VersionId { get; set; }

        public string SourceURL { get; set; }

        public int LineNumber { get; set; }

        public int ColumnNumber { get; set; }
    }
}
