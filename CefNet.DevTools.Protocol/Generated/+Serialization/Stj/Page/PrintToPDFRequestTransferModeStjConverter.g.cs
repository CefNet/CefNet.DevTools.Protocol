//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class PrintToPDFRequestTransferModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode>
    {
        public override CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode.ReturnAsBase64 => "ReturnAsBase64",
                CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode.ReturnAsStream => "ReturnAsStream",
                _ => throw new NotSupportedException("PrintToPDFRequestTransferMode" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
