//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class SignedExchangeErrorFieldStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.SignedExchangeErrorField>
    {
        public override CefNet.DevTools.Protocol.Network.SignedExchangeErrorField Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "signatureCertSha256" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureCertSha256,
                "signatureCertUrl" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureCertUrl,
                "signatureIntegrity" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureIntegrity,
                "signatureSig" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureSig,
                "signatureTimestamps" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureTimestamps,
                "signatureValidityUrl" => CefNet.DevTools.Protocol.Network.SignedExchangeErrorField.SignatureValidityUrl,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.SignedExchangeErrorField value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
