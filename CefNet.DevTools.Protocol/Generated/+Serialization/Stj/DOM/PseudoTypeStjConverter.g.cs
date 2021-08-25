//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOM
{
    internal sealed class PseudoTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOM.PseudoType>
    {
        public override CefNet.DevTools.Protocol.DOM.PseudoType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "after" => CefNet.DevTools.Protocol.DOM.PseudoType.After,
                "backdrop" => CefNet.DevTools.Protocol.DOM.PseudoType.Backdrop,
                "before" => CefNet.DevTools.Protocol.DOM.PseudoType.Before,
                "first-letter" => CefNet.DevTools.Protocol.DOM.PseudoType.FirstLetter,
                "first-line" => CefNet.DevTools.Protocol.DOM.PseudoType.FirstLine,
                "first-line-inherited" => CefNet.DevTools.Protocol.DOM.PseudoType.FirstLineInherited,
                "grammar-error" => CefNet.DevTools.Protocol.DOM.PseudoType.GrammarError,
                "highlight" => CefNet.DevTools.Protocol.DOM.PseudoType.Highlight,
                "input-list-button" => CefNet.DevTools.Protocol.DOM.PseudoType.InputListButton,
                "marker" => CefNet.DevTools.Protocol.DOM.PseudoType.Marker,
                "resizer" => CefNet.DevTools.Protocol.DOM.PseudoType.Resizer,
                "scrollbar" => CefNet.DevTools.Protocol.DOM.PseudoType.Scrollbar,
                "scrollbar-button" => CefNet.DevTools.Protocol.DOM.PseudoType.ScrollbarButton,
                "scrollbar-corner" => CefNet.DevTools.Protocol.DOM.PseudoType.ScrollbarCorner,
                "scrollbar-thumb" => CefNet.DevTools.Protocol.DOM.PseudoType.ScrollbarThumb,
                "scrollbar-track" => CefNet.DevTools.Protocol.DOM.PseudoType.ScrollbarTrack,
                "scrollbar-track-piece" => CefNet.DevTools.Protocol.DOM.PseudoType.ScrollbarTrackPiece,
                "selection" => CefNet.DevTools.Protocol.DOM.PseudoType.Selection,
                "spelling-error" => CefNet.DevTools.Protocol.DOM.PseudoType.SpellingError,
                "target-text" => CefNet.DevTools.Protocol.DOM.PseudoType.TargetText,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOM.PseudoType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
