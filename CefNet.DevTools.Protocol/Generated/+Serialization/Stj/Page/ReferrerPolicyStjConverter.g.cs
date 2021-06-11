//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class ReferrerPolicyStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.ReferrerPolicy>
    {
        public override CefNet.DevTools.Protocol.Page.ReferrerPolicy Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.ReferrerPolicy value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.NoReferrer => "noReferrer",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.NoReferrerWhenDowngrade => "noReferrerWhenDowngrade",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.Origin => "origin",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.OriginWhenCrossOrigin => "originWhenCrossOrigin",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.SameOrigin => "sameOrigin",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.StrictOrigin => "strictOrigin",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.StrictOriginWhenCrossOrigin => "strictOriginWhenCrossOrigin",
                CefNet.DevTools.Protocol.Page.ReferrerPolicy.UnsafeUrl => "unsafeUrl",
                _ => throw new NotSupportedException("ReferrerPolicy" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
