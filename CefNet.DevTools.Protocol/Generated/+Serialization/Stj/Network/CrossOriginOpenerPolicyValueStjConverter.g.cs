//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CrossOriginOpenerPolicyValueStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue>
    {
        public override CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "SameOrigin" => CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue.SameOrigin,
                "SameOriginAllowPopups" => CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue.SameOriginAllowPopups,
                "SameOriginPlusCoep" => CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue.SameOriginPlusCoep,
                "UnsafeNone" => CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue.UnsafeNone,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CrossOriginOpenerPolicyValue value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
