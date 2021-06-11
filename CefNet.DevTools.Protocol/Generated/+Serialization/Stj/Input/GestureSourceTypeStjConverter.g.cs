//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class GestureSourceTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.GestureSourceType>
    {
        public override CefNet.DevTools.Protocol.Input.GestureSourceType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.GestureSourceType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.GestureSourceType.Default => "default",
                CefNet.DevTools.Protocol.Input.GestureSourceType.Mouse => "mouse",
                CefNet.DevTools.Protocol.Input.GestureSourceType.Touch => "touch",
                _ => throw new NotSupportedException("GestureSourceType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
