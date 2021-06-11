//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class PausedEventArgsReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason>
    {
        public override CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "ambiguous" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.Ambiguous,
                "assert" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.Assert,
                "CSPViolation" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.CSPViolation,
                "debugCommand" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.DebugCommand,
                "DOM" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.DOM,
                "EventListener" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.EventListener,
                "exception" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.Exception,
                "instrumentation" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.Instrumentation,
                "OOM" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.OOM,
                "other" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.Other,
                "promiseRejection" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.PromiseRejection,
                "XHR" => CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason.XHR,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
