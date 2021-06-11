//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Performance
{
    internal sealed class SetTimeDomainRequestTimeDomainStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Performance.SetTimeDomainRequestTimeDomain>
    {
        public override CefNet.DevTools.Protocol.Performance.SetTimeDomainRequestTimeDomain Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Performance.SetTimeDomainRequestTimeDomain value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Performance.SetTimeDomainRequestTimeDomain.ThreadTicks => "threadTicks",
                CefNet.DevTools.Protocol.Performance.SetTimeDomainRequestTimeDomain.TimeTicks => "timeTicks",
                _ => throw new NotSupportedException("SetTimeDomainRequestTimeDomain" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
