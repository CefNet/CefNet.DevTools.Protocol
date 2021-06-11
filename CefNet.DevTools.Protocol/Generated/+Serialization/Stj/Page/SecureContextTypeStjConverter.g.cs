//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class SecureContextTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.SecureContextType>
    {
        public override CefNet.DevTools.Protocol.Page.SecureContextType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "InsecureAncestor" => CefNet.DevTools.Protocol.Page.SecureContextType.InsecureAncestor,
                "InsecureScheme" => CefNet.DevTools.Protocol.Page.SecureContextType.InsecureScheme,
                "Secure" => CefNet.DevTools.Protocol.Page.SecureContextType.Secure,
                "SecureLocalhost" => CefNet.DevTools.Protocol.Page.SecureContextType.SecureLocalhost,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.SecureContextType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
