//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Accessibility
{
    internal sealed class AXPropertyNameStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Accessibility.AXPropertyName>
    {
        public override CefNet.DevTools.Protocol.Accessibility.AXPropertyName Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "activedescendant" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Activedescendant,
                "atomic" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Atomic,
                "autocomplete" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Autocomplete,
                "busy" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Busy,
                "checked" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Checked,
                "controls" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Controls,
                "describedby" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Describedby,
                "details" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Details,
                "disabled" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Disabled,
                "editable" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Editable,
                "errormessage" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Errormessage,
                "expanded" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Expanded,
                "flowto" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Flowto,
                "focusable" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Focusable,
                "focused" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Focused,
                "hasPopup" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.HasPopup,
                "hidden" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Hidden,
                "hiddenRoot" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.HiddenRoot,
                "invalid" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Invalid,
                "keyshortcuts" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Keyshortcuts,
                "labelledby" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Labelledby,
                "level" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Level,
                "live" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Live,
                "modal" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Modal,
                "multiline" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Multiline,
                "multiselectable" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Multiselectable,
                "orientation" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Orientation,
                "owns" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Owns,
                "pressed" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Pressed,
                "readonly" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Readonly,
                "relevant" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Relevant,
                "required" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Required,
                "roledescription" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Roledescription,
                "root" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Root,
                "selected" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Selected,
                "settable" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Settable,
                "valuemax" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Valuemax,
                "valuemin" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Valuemin,
                "valuetext" => CefNet.DevTools.Protocol.Accessibility.AXPropertyName.Valuetext,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Accessibility.AXPropertyName value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
