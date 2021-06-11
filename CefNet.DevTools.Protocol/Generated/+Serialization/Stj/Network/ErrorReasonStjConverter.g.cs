//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ErrorReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ErrorReason>
    {
        public override CefNet.DevTools.Protocol.Network.ErrorReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Aborted" => CefNet.DevTools.Protocol.Network.ErrorReason.Aborted,
                "AccessDenied" => CefNet.DevTools.Protocol.Network.ErrorReason.AccessDenied,
                "AddressUnreachable" => CefNet.DevTools.Protocol.Network.ErrorReason.AddressUnreachable,
                "BlockedByClient" => CefNet.DevTools.Protocol.Network.ErrorReason.BlockedByClient,
                "BlockedByResponse" => CefNet.DevTools.Protocol.Network.ErrorReason.BlockedByResponse,
                "ConnectionAborted" => CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionAborted,
                "ConnectionClosed" => CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionClosed,
                "ConnectionFailed" => CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionFailed,
                "ConnectionRefused" => CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionRefused,
                "ConnectionReset" => CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionReset,
                "Failed" => CefNet.DevTools.Protocol.Network.ErrorReason.Failed,
                "InternetDisconnected" => CefNet.DevTools.Protocol.Network.ErrorReason.InternetDisconnected,
                "NameNotResolved" => CefNet.DevTools.Protocol.Network.ErrorReason.NameNotResolved,
                "TimedOut" => CefNet.DevTools.Protocol.Network.ErrorReason.TimedOut,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ErrorReason value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.ErrorReason.Aborted => "Aborted",
                CefNet.DevTools.Protocol.Network.ErrorReason.AccessDenied => "AccessDenied",
                CefNet.DevTools.Protocol.Network.ErrorReason.AddressUnreachable => "AddressUnreachable",
                CefNet.DevTools.Protocol.Network.ErrorReason.BlockedByClient => "BlockedByClient",
                CefNet.DevTools.Protocol.Network.ErrorReason.BlockedByResponse => "BlockedByResponse",
                CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionAborted => "ConnectionAborted",
                CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionClosed => "ConnectionClosed",
                CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionFailed => "ConnectionFailed",
                CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionRefused => "ConnectionRefused",
                CefNet.DevTools.Protocol.Network.ErrorReason.ConnectionReset => "ConnectionReset",
                CefNet.DevTools.Protocol.Network.ErrorReason.Failed => "Failed",
                CefNet.DevTools.Protocol.Network.ErrorReason.InternetDisconnected => "InternetDisconnected",
                CefNet.DevTools.Protocol.Network.ErrorReason.NameNotResolved => "NameNotResolved",
                CefNet.DevTools.Protocol.Network.ErrorReason.TimedOut => "TimedOut",
                _ => throw new NotSupportedException("ErrorReason" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
