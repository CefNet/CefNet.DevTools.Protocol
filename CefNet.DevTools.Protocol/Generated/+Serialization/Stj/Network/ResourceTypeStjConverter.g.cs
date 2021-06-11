//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ResourceTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ResourceType>
    {
        public override CefNet.DevTools.Protocol.Network.ResourceType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CSPViolationReport" => CefNet.DevTools.Protocol.Network.ResourceType.CSPViolationReport,
                "Document" => CefNet.DevTools.Protocol.Network.ResourceType.Document,
                "EventSource" => CefNet.DevTools.Protocol.Network.ResourceType.EventSource,
                "Fetch" => CefNet.DevTools.Protocol.Network.ResourceType.Fetch,
                "Font" => CefNet.DevTools.Protocol.Network.ResourceType.Font,
                "Image" => CefNet.DevTools.Protocol.Network.ResourceType.Image,
                "Manifest" => CefNet.DevTools.Protocol.Network.ResourceType.Manifest,
                "Media" => CefNet.DevTools.Protocol.Network.ResourceType.Media,
                "Other" => CefNet.DevTools.Protocol.Network.ResourceType.Other,
                "Ping" => CefNet.DevTools.Protocol.Network.ResourceType.Ping,
                "Preflight" => CefNet.DevTools.Protocol.Network.ResourceType.Preflight,
                "Script" => CefNet.DevTools.Protocol.Network.ResourceType.Script,
                "SignedExchange" => CefNet.DevTools.Protocol.Network.ResourceType.SignedExchange,
                "Stylesheet" => CefNet.DevTools.Protocol.Network.ResourceType.Stylesheet,
                "TextTrack" => CefNet.DevTools.Protocol.Network.ResourceType.TextTrack,
                "WebSocket" => CefNet.DevTools.Protocol.Network.ResourceType.WebSocket,
                "XHR" => CefNet.DevTools.Protocol.Network.ResourceType.XHR,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ResourceType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.ResourceType.CSPViolationReport => "CSPViolationReport",
                CefNet.DevTools.Protocol.Network.ResourceType.Document => "Document",
                CefNet.DevTools.Protocol.Network.ResourceType.EventSource => "EventSource",
                CefNet.DevTools.Protocol.Network.ResourceType.Fetch => "Fetch",
                CefNet.DevTools.Protocol.Network.ResourceType.Font => "Font",
                CefNet.DevTools.Protocol.Network.ResourceType.Image => "Image",
                CefNet.DevTools.Protocol.Network.ResourceType.Manifest => "Manifest",
                CefNet.DevTools.Protocol.Network.ResourceType.Media => "Media",
                CefNet.DevTools.Protocol.Network.ResourceType.Other => "Other",
                CefNet.DevTools.Protocol.Network.ResourceType.Ping => "Ping",
                CefNet.DevTools.Protocol.Network.ResourceType.Preflight => "Preflight",
                CefNet.DevTools.Protocol.Network.ResourceType.Script => "Script",
                CefNet.DevTools.Protocol.Network.ResourceType.SignedExchange => "SignedExchange",
                CefNet.DevTools.Protocol.Network.ResourceType.Stylesheet => "Stylesheet",
                CefNet.DevTools.Protocol.Network.ResourceType.TextTrack => "TextTrack",
                CefNet.DevTools.Protocol.Network.ResourceType.WebSocket => "WebSocket",
                CefNet.DevTools.Protocol.Network.ResourceType.XHR => "XHR",
                _ => throw new NotSupportedException("ResourceType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
