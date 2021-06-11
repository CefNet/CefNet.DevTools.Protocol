//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class CrossOriginIsolatedContextTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType>
    {
        public override CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Isolated" => CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType.Isolated,
                "NotIsolated" => CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType.NotIsolated,
                "NotIsolatedFeatureDisabled" => CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType.NotIsolatedFeatureDisabled,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
