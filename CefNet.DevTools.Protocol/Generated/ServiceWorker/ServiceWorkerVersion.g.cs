//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    /// <summary>ServiceWorker version.</summary>
    public sealed class ServiceWorkerVersion
    {
        public string VersionId { get; set; }

        public CefNet.DevTools.Protocol.ServiceWorker.RegistrationID RegistrationId { get; set; }

        public string ScriptURL { get; set; }

        public CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus RunningStatus { get; set; }

        public CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus Status { get; set; }

        /// <summary>
        /// The Last-Modified header value of the main script.
        /// </summary>
        public double? ScriptLastModified { get; set; }

        /// <summary>
        /// The time at which the response headers of the main script were received from the server.
        /// For cached script it is the last time the cache entry was validated.
        /// </summary>
        public double? ScriptResponseTime { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Target.TargetID>? ControlledClients { get; set; }

        public CefNet.DevTools.Protocol.Target.TargetID? TargetId { get; set; }
    }
}
