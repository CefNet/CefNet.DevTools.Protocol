//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class DownloadProgressEventArgsStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState>
    {
        public override CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "canceled" => CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState.Canceled,
                "completed" => CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState.Completed,
                "inProgress" => CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState.InProgress,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
