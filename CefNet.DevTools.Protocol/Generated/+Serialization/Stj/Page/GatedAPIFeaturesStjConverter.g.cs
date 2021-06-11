//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class GatedAPIFeaturesStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.GatedAPIFeatures>
    {
        public override CefNet.DevTools.Protocol.Page.GatedAPIFeatures Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "PerformanceMeasureMemory" => CefNet.DevTools.Protocol.Page.GatedAPIFeatures.PerformanceMeasureMemory,
                "PerformanceProfile" => CefNet.DevTools.Protocol.Page.GatedAPIFeatures.PerformanceProfile,
                "SharedArrayBuffers" => CefNet.DevTools.Protocol.Page.GatedAPIFeatures.SharedArrayBuffers,
                "SharedArrayBuffersTransferAllowed" => CefNet.DevTools.Protocol.Page.GatedAPIFeatures.SharedArrayBuffersTransferAllowed,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.GatedAPIFeatures value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
