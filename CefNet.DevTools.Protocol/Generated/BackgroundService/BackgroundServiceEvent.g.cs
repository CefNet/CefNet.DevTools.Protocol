//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.BackgroundService
{
    public sealed class BackgroundServiceEvent
    {
        /// <summary>Timestamp of the event (in seconds).</summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch Timestamp { get; set; }

        /// <summary>The origin this event belongs to.</summary>
        public string Origin { get; set; }

        /// <summary>
        /// The Service Worker ID that initiated the event.
        /// </summary>
        public CefNet.DevTools.Protocol.ServiceWorker.RegistrationID ServiceWorkerRegistrationId { get; set; }

        /// <summary>
        /// The Background Service this event belongs to.
        /// </summary>
        public CefNet.DevTools.Protocol.BackgroundService.ServiceName Service { get; set; }

        /// <summary>A description of the event.</summary>
        public string EventName { get; set; }

        /// <summary>
        /// An identifier that groups related events together.
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>A list of event-specific information.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.BackgroundService.EventMetadata> EventMetadata { get; set; }
    }
}
