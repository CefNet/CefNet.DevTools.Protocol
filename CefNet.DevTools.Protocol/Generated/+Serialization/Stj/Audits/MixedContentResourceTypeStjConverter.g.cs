//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class MixedContentResourceTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.MixedContentResourceType>
    {
        public override CefNet.DevTools.Protocol.Audits.MixedContentResourceType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Audio" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Audio,
                "Beacon" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Beacon,
                "CSPReport" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.CSPReport,
                "Download" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Download,
                "EventSource" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.EventSource,
                "Favicon" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Favicon,
                "Font" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Font,
                "Form" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Form,
                "Frame" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Frame,
                "Image" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Image,
                "Import" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Import,
                "Manifest" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Manifest,
                "Ping" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Ping,
                "PluginData" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.PluginData,
                "PluginResource" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.PluginResource,
                "Prefetch" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Prefetch,
                "Resource" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Resource,
                "Script" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Script,
                "ServiceWorker" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.ServiceWorker,
                "SharedWorker" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.SharedWorker,
                "Stylesheet" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Stylesheet,
                "Track" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Track,
                "Video" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Video,
                "Worker" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.Worker,
                "XMLHttpRequest" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.XMLHttpRequest,
                "XSLT" => CefNet.DevTools.Protocol.Audits.MixedContentResourceType.XSLT,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.MixedContentResourceType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
