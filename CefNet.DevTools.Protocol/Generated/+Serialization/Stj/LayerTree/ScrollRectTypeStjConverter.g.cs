//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.LayerTree
{
    internal sealed class ScrollRectTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.LayerTree.ScrollRectType>
    {
        public override CefNet.DevTools.Protocol.LayerTree.ScrollRectType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "RepaintsOnScroll" => CefNet.DevTools.Protocol.LayerTree.ScrollRectType.RepaintsOnScroll,
                "TouchEventHandler" => CefNet.DevTools.Protocol.LayerTree.ScrollRectType.TouchEventHandler,
                "WheelEventHandler" => CefNet.DevTools.Protocol.LayerTree.ScrollRectType.WheelEventHandler,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.LayerTree.ScrollRectType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
