//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class SetDownloadBehaviorRequestBehaviorStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior>
    {
        public override CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior.Allow => "allow",
                CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior.AllowAndName => "allowAndName",
                CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior.Default => "default",
                CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequestBehavior.Deny => "deny",
                _ => throw new NotSupportedException("SetDownloadBehaviorRequestBehavior" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
