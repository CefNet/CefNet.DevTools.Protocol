//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Accessibility
{
    internal sealed class AXValueTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Accessibility.AXValueType>
    {
        public override CefNet.DevTools.Protocol.Accessibility.AXValueType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "boolean" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Boolean,
                "booleanOrUndefined" => CefNet.DevTools.Protocol.Accessibility.AXValueType.BooleanOrUndefined,
                "computedString" => CefNet.DevTools.Protocol.Accessibility.AXValueType.ComputedString,
                "domRelation" => CefNet.DevTools.Protocol.Accessibility.AXValueType.DomRelation,
                "idref" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Idref,
                "idrefList" => CefNet.DevTools.Protocol.Accessibility.AXValueType.IdrefList,
                "integer" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Integer,
                "internalRole" => CefNet.DevTools.Protocol.Accessibility.AXValueType.InternalRole,
                "node" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Node,
                "nodeList" => CefNet.DevTools.Protocol.Accessibility.AXValueType.NodeList,
                "number" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Number,
                "role" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Role,
                "string" => CefNet.DevTools.Protocol.Accessibility.AXValueType.String,
                "token" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Token,
                "tokenList" => CefNet.DevTools.Protocol.Accessibility.AXValueType.TokenList,
                "tristate" => CefNet.DevTools.Protocol.Accessibility.AXValueType.Tristate,
                "valueUndefined" => CefNet.DevTools.Protocol.Accessibility.AXValueType.ValueUndefined,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Accessibility.AXValueType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
