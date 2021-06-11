//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class SetWebLifecycleStateRequestStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequestState>
    {
        public override CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequestState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequestState value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequestState.Active => "active",
                CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequestState.Frozen => "frozen",
                _ => throw new NotSupportedException("SetWebLifecycleStateRequestState" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
