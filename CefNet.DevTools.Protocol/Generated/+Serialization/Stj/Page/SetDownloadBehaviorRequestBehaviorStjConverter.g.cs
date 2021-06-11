//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class SetDownloadBehaviorRequestBehaviorStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior>
    {
        public override CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior.Allow => "allow",
                CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior.Default => "default",
                CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequestBehavior.Deny => "deny",
                _ => throw new NotSupportedException("SetDownloadBehaviorRequestBehavior" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
