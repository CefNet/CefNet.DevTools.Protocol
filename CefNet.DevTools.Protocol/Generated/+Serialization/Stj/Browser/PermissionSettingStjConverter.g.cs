//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class PermissionSettingStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.PermissionSetting>
    {
        public override CefNet.DevTools.Protocol.Browser.PermissionSetting Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.PermissionSetting value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Browser.PermissionSetting.Denied => "denied",
                CefNet.DevTools.Protocol.Browser.PermissionSetting.Granted => "granted",
                CefNet.DevTools.Protocol.Browser.PermissionSetting.Prompt => "prompt",
                _ => throw new NotSupportedException("PermissionSetting" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
