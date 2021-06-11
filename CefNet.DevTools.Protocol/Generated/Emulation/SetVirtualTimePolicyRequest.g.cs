//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetVirtualTimePolicyRequest
    {
        public CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy Policy { get; set; }

        /// <summary>
        /// If set, after this many virtual milliseconds have elapsed virtual time will be paused and a
        /// virtualTimeBudgetExpired event is sent.
        /// </summary>
        public double? Budget { get; set; }

        /// <summary>
        /// If set this specifies the maximum number of tasks that can be run before virtual is forced
        /// forwards to prevent deadlock.
        /// </summary>
        public int? MaxVirtualTimeTaskStarvationCount { get; set; }

        /// <summary>
        /// If set the virtual time policy change should be deferred until any frame starts navigating.
        /// Note any previous deferred policy change is superseded.
        /// </summary>
        public bool? WaitForNavigation { get; set; }

        /// <summary>
        /// If set, base::Time::Now will be overridden to initially return this value.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch? InitialVirtualTime { get; set; }
    }
}
