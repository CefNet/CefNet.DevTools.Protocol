//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class BackForwardCacheNotRestoredReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason>
    {
        public override CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "AppBanner" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.AppBanner,
                "BackForwardCacheDisabled" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BackForwardCacheDisabled,
                "BackForwardCacheDisabledByCommandLine" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BackForwardCacheDisabledByCommandLine,
                "BackForwardCacheDisabledByLowMemory" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BackForwardCacheDisabledByLowMemory,
                "BackForwardCacheDisabledForDelegate" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BackForwardCacheDisabledForDelegate,
                "BackForwardCacheDisabledForPrerender" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BackForwardCacheDisabledForPrerender,
                "BroadcastChannel" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BroadcastChannel,
                "BrowsingInstanceNotSwapped" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.BrowsingInstanceNotSwapped,
                "CacheControlNoStore" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.CacheControlNoStore,
                "CacheControlNoStoreCookieModified" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.CacheControlNoStoreCookieModified,
                "CacheControlNoStoreHTTPOnlyCookieModified" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.CacheControlNoStoreHTTPOnlyCookieModified,
                "CacheFlushed" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.CacheFlushed,
                "CacheLimit" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.CacheLimit,
                "ConflictingBrowsingInstance" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ConflictingBrowsingInstance,
                "ContainsPlugins" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ContainsPlugins,
                "DedicatedWorkerOrWorklet" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.DedicatedWorkerOrWorklet,
                "DisableForRenderFrameHostCalled" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.DisableForRenderFrameHostCalled,
                "DocumentLoaded" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.DocumentLoaded,
                "DomainNotAllowed" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.DomainNotAllowed,
                "EnteredBackForwardCacheBeforeServiceWorkerHostAdded" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.EnteredBackForwardCacheBeforeServiceWorkerHostAdded,
                "ForegroundCacheLimit" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ForegroundCacheLimit,
                "GrantedMediaStreamAccess" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.GrantedMediaStreamAccess,
                "HaveInnerContents" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.HaveInnerContents,
                "HTTPMethodNotGET" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.HTTPMethodNotGET,
                "HTTPStatusNotOK" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.HTTPStatusNotOK,
                "IdleManager" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.IdleManager,
                "IgnoreEventAndEvict" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.IgnoreEventAndEvict,
                "IndexedDBConnection" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.IndexedDBConnection,
                "InjectedStyleSheet" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.InjectedStyleSheet,
                "IsolatedWorldScript" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.IsolatedWorldScript,
                "JavaScriptExecution" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.JavaScriptExecution,
                "KeyboardLock" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.KeyboardLock,
                "Loading" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.Loading,
                "MainResourceHasCacheControlNoCache" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.MainResourceHasCacheControlNoCache,
                "MainResourceHasCacheControlNoStore" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.MainResourceHasCacheControlNoStore,
                "MediaSessionImplOnServiceCreated" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.MediaSessionImplOnServiceCreated,
                "NavigationCancelledWhileRestoring" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NavigationCancelledWhileRestoring,
                "NetworkExceedsBufferLimit" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NetworkExceedsBufferLimit,
                "NetworkRequestDatapipeDrainedAsBytesConsumer" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NetworkRequestDatapipeDrainedAsBytesConsumer,
                "NetworkRequestRedirected" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NetworkRequestRedirected,
                "NetworkRequestTimeout" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NetworkRequestTimeout,
                "NotMainFrame" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NotMainFrame,
                "NotMostRecentNavigationEntry" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.NotMostRecentNavigationEntry,
                "OptInUnloadHeaderNotPresent" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OptInUnloadHeaderNotPresent,
                "OutstandingIndexedDBTransaction" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OutstandingIndexedDBTransaction,
                "OutstandingNetworkRequestDirectSocket" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OutstandingNetworkRequestDirectSocket,
                "OutstandingNetworkRequestFetch" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OutstandingNetworkRequestFetch,
                "OutstandingNetworkRequestOthers" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OutstandingNetworkRequestOthers,
                "OutstandingNetworkRequestXHR" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.OutstandingNetworkRequestXHR,
                "PaymentManager" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.PaymentManager,
                "PictureInPicture" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.PictureInPicture,
                "Portal" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.Portal,
                "Printing" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.Printing,
                "RelatedActiveContentsExist" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RelatedActiveContentsExist,
                "RendererProcessCrashed" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RendererProcessCrashed,
                "RendererProcessKilled" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RendererProcessKilled,
                "RenderFrameHostReused_CrossSite" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RenderFrameHostReused_CrossSite,
                "RenderFrameHostReused_SameSite" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RenderFrameHostReused_SameSite,
                "RequestedAudioCapturePermission" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedAudioCapturePermission,
                "RequestedBackForwardCacheBlockedSensors" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedBackForwardCacheBlockedSensors,
                "RequestedBackgroundWorkPermission" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedBackgroundWorkPermission,
                "RequestedMIDIPermission" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedMIDIPermission,
                "RequestedNotificationsPermission" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedNotificationsPermission,
                "RequestedStorageAccessGrant" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedStorageAccessGrant,
                "RequestedVideoCapturePermission" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.RequestedVideoCapturePermission,
                "SchedulerTrackedFeatureUsed" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SchedulerTrackedFeatureUsed,
                "SchemeNotHTTPOrHTTPS" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SchemeNotHTTPOrHTTPS,
                "ServiceWorkerClaim" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ServiceWorkerClaim,
                "ServiceWorkerPostMessage" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ServiceWorkerPostMessage,
                "ServiceWorkerUnregistration" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ServiceWorkerUnregistration,
                "ServiceWorkerVersionActivation" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.ServiceWorkerVersionActivation,
                "SessionRestored" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SessionRestored,
                "SharedWorker" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SharedWorker,
                "SpeechRecognizer" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SpeechRecognizer,
                "SpeechSynthesis" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SpeechSynthesis,
                "SubframeIsNavigating" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SubframeIsNavigating,
                "SubresourceHasCacheControlNoCache" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SubresourceHasCacheControlNoCache,
                "SubresourceHasCacheControlNoStore" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.SubresourceHasCacheControlNoStore,
                "Timeout" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.Timeout,
                "TimeoutPuttingInCache" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.TimeoutPuttingInCache,
                "Unknown" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.Unknown,
                "UnloadHandlerExistsInSubFrame" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.UnloadHandlerExistsInSubFrame,
                "UserAgentOverrideDiffers" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.UserAgentOverrideDiffers,
                "WasGrantedMediaAccess" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WasGrantedMediaAccess,
                "WebDatabase" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebDatabase,
                "WebFileSystem" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebFileSystem,
                "WebHID" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebHID,
                "WebLocks" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebLocks,
                "WebNfc" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebNfc,
                "WebOTPService" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebOTPService,
                "WebRTC" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebRTC,
                "WebShare" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebShare,
                "WebSocket" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebSocket,
                "WebXR" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason.WebXR,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
