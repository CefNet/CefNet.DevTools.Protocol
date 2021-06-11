//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class PermissionTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.PermissionType>
    {
        public override CefNet.DevTools.Protocol.Browser.PermissionType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.PermissionType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Browser.PermissionType.AccessibilityEvents => "accessibilityEvents",
                CefNet.DevTools.Protocol.Browser.PermissionType.AudioCapture => "audioCapture",
                CefNet.DevTools.Protocol.Browser.PermissionType.BackgroundFetch => "backgroundFetch",
                CefNet.DevTools.Protocol.Browser.PermissionType.BackgroundSync => "backgroundSync",
                CefNet.DevTools.Protocol.Browser.PermissionType.ClipboardReadWrite => "clipboardReadWrite",
                CefNet.DevTools.Protocol.Browser.PermissionType.ClipboardSanitizedWrite => "clipboardSanitizedWrite",
                CefNet.DevTools.Protocol.Browser.PermissionType.DisplayCapture => "displayCapture",
                CefNet.DevTools.Protocol.Browser.PermissionType.DurableStorage => "durableStorage",
                CefNet.DevTools.Protocol.Browser.PermissionType.Flash => "flash",
                CefNet.DevTools.Protocol.Browser.PermissionType.Geolocation => "geolocation",
                CefNet.DevTools.Protocol.Browser.PermissionType.IdleDetection => "idleDetection",
                CefNet.DevTools.Protocol.Browser.PermissionType.Midi => "midi",
                CefNet.DevTools.Protocol.Browser.PermissionType.MidiSysex => "midiSysex",
                CefNet.DevTools.Protocol.Browser.PermissionType.Nfc => "nfc",
                CefNet.DevTools.Protocol.Browser.PermissionType.Notifications => "notifications",
                CefNet.DevTools.Protocol.Browser.PermissionType.PaymentHandler => "paymentHandler",
                CefNet.DevTools.Protocol.Browser.PermissionType.PeriodicBackgroundSync => "periodicBackgroundSync",
                CefNet.DevTools.Protocol.Browser.PermissionType.ProtectedMediaIdentifier => "protectedMediaIdentifier",
                CefNet.DevTools.Protocol.Browser.PermissionType.Sensors => "sensors",
                CefNet.DevTools.Protocol.Browser.PermissionType.VideoCapture => "videoCapture",
                CefNet.DevTools.Protocol.Browser.PermissionType.VideoCapturePanTiltZoom => "videoCapturePanTiltZoom",
                CefNet.DevTools.Protocol.Browser.PermissionType.WakeLockScreen => "wakeLockScreen",
                CefNet.DevTools.Protocol.Browser.PermissionType.WakeLockSystem => "wakeLockSystem",
                _ => throw new NotSupportedException("PermissionType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
