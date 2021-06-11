//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol
{
    public readonly struct ProtocolApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        public ProtocolApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
            _session.UseSerializerOptions(CefNet.DevTools.Protocol.ProtocolStjSerializerOptions.Instance);
        }

        public readonly CefNet.DevTools.CrdtpSession GetCrdtpSession(
            ) => _session;

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Accessibility.AccessibilityApi Accessibility => new CefNet.DevTools.Protocol.Accessibility.AccessibilityApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Animation.AnimationApi Animation => new CefNet.DevTools.Protocol.Animation.AnimationApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheApi ApplicationCache => new CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheApi(_session);

        /// <summary>
        /// [Experimental] Audits domain allows investigation of page violations and possible improvements.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.AuditsApi Audits => new CefNet.DevTools.Protocol.Audits.AuditsApi(_session);

        /// <summary>
        /// [Experimental] Defines events for background web platform features.
        /// </summary>
        public CefNet.DevTools.Protocol.BackgroundService.BackgroundServiceApi BackgroundService => new CefNet.DevTools.Protocol.BackgroundService.BackgroundServiceApi(_session);

        /// <summary>
        /// The Browser domain defines methods and events for browser managing.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserApi Browser => new CefNet.DevTools.Protocol.Browser.BrowserApi(_session);

        /// <summary>
        /// [Experimental] This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
        /// have an associated `id` used in subsequent operations on the related object. Each object type has
        /// a specific `id` structure, and those are not interchangeable between objects of different kinds.
        /// CSS objects can be loaded using the `get*ForNode()` calls (which accept a DOM node id). A client
        /// can also keep track of stylesheets via the `styleSheetAdded`/`styleSheetRemoved` events and
        /// subsequently load the required stylesheet contents using the `getStyleSheet[Text]()` methods.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.CSSApi CSS => new CefNet.DevTools.Protocol.CSS.CSSApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.CacheStorage.CacheStorageApi CacheStorage => new CefNet.DevTools.Protocol.CacheStorage.CacheStorageApi(_session);

        /// <summary>
        /// [Experimental] A domain for interacting with Cast, Presentation API, and Remote Playback API
        /// functionalities.
        /// </summary>
        public CefNet.DevTools.Protocol.Cast.CastApi Cast => new CefNet.DevTools.Protocol.Cast.CastApi(_session);

        /// <summary>
        /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
        /// that has an `id`. This `id` can be used to get additional information on the Node, resolve it into
        /// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
        /// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
        /// and never sends the same node twice. It is client's responsibility to collect information about
        /// the nodes that were sent to the client.<p>Note that `iframe` owner elements will return
        /// corresponding document elements as their child nodes.</p>
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.DOMApi DOM => new CefNet.DevTools.Protocol.DOM.DOMApi(_session);

        /// <summary>
        /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
        /// execution will stop on these operations as if there was a regular breakpoint set.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMDebugger.DOMDebuggerApi DOMDebugger => new CefNet.DevTools.Protocol.DOMDebugger.DOMDebuggerApi(_session);

        /// <summary>
        /// [Experimental] This domain facilitates obtaining document snapshots with DOM, layout, and style information.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.DOMSnapshotApi DOMSnapshot => new CefNet.DevTools.Protocol.DOMSnapshot.DOMSnapshotApi(_session);

        /// <summary>
        /// [Experimental] Query and modify DOM storage.
        /// </summary>
        public CefNet.DevTools.Protocol.DOMStorage.DOMStorageApi DOMStorage => new CefNet.DevTools.Protocol.DOMStorage.DOMStorageApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Database.DatabaseApi Database => new CefNet.DevTools.Protocol.Database.DatabaseApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.DeviceOrientation.DeviceOrientationApi DeviceOrientation => new CefNet.DevTools.Protocol.DeviceOrientation.DeviceOrientationApi(_session);

        /// <summary>
        /// This domain emulates different environments for the page.
        /// </summary>
        public CefNet.DevTools.Protocol.Emulation.EmulationApi Emulation => new CefNet.DevTools.Protocol.Emulation.EmulationApi(_session);

        /// <summary>
        /// [Experimental] This domain provides experimental commands only supported in headless mode.
        /// </summary>
        public CefNet.DevTools.Protocol.HeadlessExperimental.HeadlessExperimentalApi HeadlessExperimental => new CefNet.DevTools.Protocol.HeadlessExperimental.HeadlessExperimentalApi(_session);

        /// <summary>
        /// Input/Output operations for streams produced by DevTools.
        /// </summary>
        public CefNet.DevTools.Protocol.IO.IOApi IO => new CefNet.DevTools.Protocol.IO.IOApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.IndexedDB.IndexedDBApi IndexedDB => new CefNet.DevTools.Protocol.IndexedDB.IndexedDBApi(_session);

        public CefNet.DevTools.Protocol.Input.InputApi Input => new CefNet.DevTools.Protocol.Input.InputApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Inspector.InspectorApi Inspector => new CefNet.DevTools.Protocol.Inspector.InspectorApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerTreeApi LayerTree => new CefNet.DevTools.Protocol.LayerTree.LayerTreeApi(_session);

        /// <summary>Provides access to log entries.</summary>
        public CefNet.DevTools.Protocol.Log.LogApi Log => new CefNet.DevTools.Protocol.Log.LogApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Memory.MemoryApi Memory => new CefNet.DevTools.Protocol.Memory.MemoryApi(_session);

        /// <summary>
        /// Network domain allows tracking network activities of the page. It exposes information about http,
        /// file, data and other requests and responses, their headers, bodies, timing, etc.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.NetworkApi Network => new CefNet.DevTools.Protocol.Network.NetworkApi(_session);

        /// <summary>
        /// [Experimental] This domain provides various functionality related to drawing atop the inspected page.
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.OverlayApi Overlay => new CefNet.DevTools.Protocol.Overlay.OverlayApi(_session);

        /// <summary>
        /// Actions and events related to the inspected page belong to the page domain.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.PageApi Page => new CefNet.DevTools.Protocol.Page.PageApi(_session);

        public CefNet.DevTools.Protocol.Performance.PerformanceApi Performance => new CefNet.DevTools.Protocol.Performance.PerformanceApi(_session);

        /// <summary>
        /// [Experimental] Reporting of performance timeline events, as specified in
        /// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
        /// </summary>
        public CefNet.DevTools.Protocol.PerformanceTimeline.PerformanceTimelineApi PerformanceTimeline => new CefNet.DevTools.Protocol.PerformanceTimeline.PerformanceTimelineApi(_session);

        /// <summary>Security</summary>
        public CefNet.DevTools.Protocol.Security.SecurityApi Security => new CefNet.DevTools.Protocol.Security.SecurityApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerApi ServiceWorker => new CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Storage.StorageApi Storage => new CefNet.DevTools.Protocol.Storage.StorageApi(_session);

        /// <summary>
        /// [Experimental] The SystemInfo domain defines methods and events for querying low-level system information.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.SystemInfoApi SystemInfo => new CefNet.DevTools.Protocol.SystemInfo.SystemInfoApi(_session);

        /// <summary>
        /// Supports additional targets discovery and allows to attach to them.
        /// </summary>
        public CefNet.DevTools.Protocol.Target.TargetApi Target => new CefNet.DevTools.Protocol.Target.TargetApi(_session);

        /// <summary>
        /// [Experimental] The Tethering domain defines methods and events for browser port binding.
        /// </summary>
        public CefNet.DevTools.Protocol.Tethering.TetheringApi Tethering => new CefNet.DevTools.Protocol.Tethering.TetheringApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Tracing.TracingApi Tracing => new CefNet.DevTools.Protocol.Tracing.TracingApi(_session);

        /// <summary>
        /// A domain for letting clients substitute browser's network layer with client code.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.FetchApi Fetch => new CefNet.DevTools.Protocol.Fetch.FetchApi(_session);

        /// <summary>
        /// [Experimental] This domain allows inspection of Web Audio API.
        /// https://webaudio.github.io/web-audio-api/
        /// </summary>
        public CefNet.DevTools.Protocol.WebAudio.WebAudioApi WebAudio => new CefNet.DevTools.Protocol.WebAudio.WebAudioApi(_session);

        /// <summary>
        /// [Experimental] This domain allows configuring virtual authenticators to test the WebAuthn
        /// API.
        /// </summary>
        public CefNet.DevTools.Protocol.WebAuthn.WebAuthnApi WebAuthn => new CefNet.DevTools.Protocol.WebAuthn.WebAuthnApi(_session);

        /// <summary>
        /// [Experimental] This domain allows detailed inspection of media elements
        /// </summary>
        public CefNet.DevTools.Protocol.Media.MediaApi Media => new CefNet.DevTools.Protocol.Media.MediaApi(_session);

        /// <summary>
        /// [Deprecated] This domain is deprecated - use Runtime or Log instead.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Console.ConsoleApi Console => new CefNet.DevTools.Protocol.Console.ConsoleApi(_session);

        /// <summary>
        /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
        /// breakpoints, stepping through execution, exploring stack traces, etc.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.DebuggerApi Debugger => new CefNet.DevTools.Protocol.Debugger.DebuggerApi(_session);

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.HeapProfiler.HeapProfilerApi HeapProfiler => new CefNet.DevTools.Protocol.HeapProfiler.HeapProfilerApi(_session);

        public CefNet.DevTools.Protocol.Profiler.ProfilerApi Profiler => new CefNet.DevTools.Protocol.Profiler.ProfilerApi(_session);

        /// <summary>
        /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
        /// Evaluation results are returned as mirror object that expose object type, string representation
        /// and unique identifier that can be used for further object reference. Original objects are
        /// maintained in memory unless they are either explicitly released or are released along with the
        /// other objects in their object group.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RuntimeApi Runtime => new CefNet.DevTools.Protocol.Runtime.RuntimeApi(_session);

        /// <summary>[Deprecated] This domain is deprecated.</summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Schema.SchemaApi Schema => new CefNet.DevTools.Protocol.Schema.SchemaApi(_session);
    }
}
