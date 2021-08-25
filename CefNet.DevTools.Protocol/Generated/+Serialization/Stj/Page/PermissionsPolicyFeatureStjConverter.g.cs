//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class PermissionsPolicyFeatureStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature>
    {
        public override CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "accelerometer" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Accelerometer,
                "ambient-light-sensor" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.AmbientLightSensor,
                "attribution-reporting" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.AttributionReporting,
                "autoplay" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Autoplay,
                "camera" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Camera,
                "ch-device-memory" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChDeviceMemory,
                "ch-downlink" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChDownlink,
                "ch-dpr" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChDpr,
                "ch-ect" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChEct,
                "ch-lang" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChLang,
                "ch-prefers-color-scheme" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChPrefersColorScheme,
                "ch-rtt" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChRtt,
                "ch-ua" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUa,
                "ch-ua-arch" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaArch,
                "ch-ua-bitness" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaBitness,
                "ch-ua-full-version" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaFullVersion,
                "ch-ua-mobile" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaMobile,
                "ch-ua-model" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaModel,
                "ch-ua-platform" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaPlatform,
                "ch-ua-platform-version" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChUaPlatformVersion,
                "ch-viewport-width" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChViewportWidth,
                "ch-width" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ChWidth,
                "clipboard-read" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ClipboardRead,
                "clipboard-write" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ClipboardWrite,
                "cross-origin-isolated" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.CrossOriginIsolated,
                "direct-sockets" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.DirectSockets,
                "display-capture" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.DisplayCapture,
                "document-domain" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.DocumentDomain,
                "encrypted-media" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.EncryptedMedia,
                "execution-while-not-rendered" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ExecutionWhileNotRendered,
                "execution-while-out-of-viewport" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ExecutionWhileOutOfViewport,
                "focus-without-user-activation" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.FocusWithoutUserActivation,
                "frobulate" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Frobulate,
                "fullscreen" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Fullscreen,
                "gamepad" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Gamepad,
                "geolocation" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Geolocation,
                "gyroscope" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Gyroscope,
                "hid" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Hid,
                "idle-detection" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.IdleDetection,
                "interest-cohort" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.InterestCohort,
                "magnetometer" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Magnetometer,
                "microphone" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Microphone,
                "midi" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Midi,
                "otp-credentials" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.OtpCredentials,
                "payment" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Payment,
                "picture-in-picture" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.PictureInPicture,
                "publickey-credentials-get" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.PublickeyCredentialsGet,
                "screen-wake-lock" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.ScreenWakeLock,
                "serial" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Serial,
                "shared-autofill" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.SharedAutofill,
                "storage-access-api" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.StorageAccessApi,
                "sync-xhr" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.SyncXhr,
                "trust-token-redemption" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.TrustTokenRedemption,
                "usb" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.Usb,
                "vertical-scroll" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.VerticalScroll,
                "web-share" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.WebShare,
                "window-placement" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.WindowPlacement,
                "xr-spatial-tracking" => CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature.XrSpatialTracking,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.PermissionsPolicyFeature value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
