//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Performance
{
    internal sealed class EnableRequestTimeDomainStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Performance.EnableRequestTimeDomain>
    {
        public override CefNet.DevTools.Protocol.Performance.EnableRequestTimeDomain Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Performance.EnableRequestTimeDomain value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Performance.EnableRequestTimeDomain.ThreadTicks => "threadTicks",
                CefNet.DevTools.Protocol.Performance.EnableRequestTimeDomain.TimeTicks => "timeTicks",
                _ => throw new NotSupportedException("EnableRequestTimeDomain" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
