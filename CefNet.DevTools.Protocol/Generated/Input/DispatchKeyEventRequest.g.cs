//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class DispatchKeyEventRequest
    {
        /// <summary>Type of the key event.</summary>
        public CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType Type { get; set; }

        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        public int? Modifiers { get; set; }

        /// <summary>Time at which the event occurred.</summary>
        public CefNet.DevTools.Protocol.Input.TimeSinceEpoch? Timestamp { get; set; }

        /// <summary>
        /// Text as generated by processing a virtual key code with a keyboard layout. Not needed for
        /// for `keyUp` and `rawKeyDown` events (default: "")
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Text that would have been generated by the keyboard if no modifiers were pressed (except for
        /// shift). Useful for shortcut (accelerator) key handling (default: "").
        /// </summary>
        public string? UnmodifiedText { get; set; }

        /// <summary>
        /// Unique key identifier (e.g., 'U+0041') (default: "").
        /// </summary>
        public string? KeyIdentifier { get; set; }

        /// <summary>
        /// Unique DOM defined string value for each physical key (e.g., 'KeyA') (default: "").
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Unique DOM defined string value describing the meaning of the key in the context of active
        /// modifiers, keyboard layout, etc (e.g., 'AltGr') (default: "").
        /// </summary>
        public string? Key { get; set; }

        /// <summary>Windows virtual key code (default: 0).</summary>
        public int? WindowsVirtualKeyCode { get; set; }

        /// <summary>Native virtual key code (default: 0).</summary>
        public int? NativeVirtualKeyCode { get; set; }

        /// <summary>
        /// Whether the event was generated from auto repeat (default: false).
        /// </summary>
        public bool? AutoRepeat { get; set; }

        /// <summary>
        /// Whether the event was generated from the keypad (default: false).
        /// </summary>
        public bool? IsKeypad { get; set; }

        /// <summary>
        /// Whether the event was a system key event (default: false).
        /// </summary>
        public bool? IsSystemKey { get; set; }

        /// <summary>
        /// Whether the event was from the left or right side of the keyboard. 1=Left, 2=Right (default:
        /// 0).
        /// </summary>
        public int? Location { get; set; }

        /// <summary>
        /// [Experimental] Editing commands to send with the key event (e.g., 'selectAll') (default: []).
        /// These are related to but not equal the command names used in `document.execCommand` and NSStandardKeyBindingResponding.
        /// See https://source.chromium.org/chromium/chromium/src/+/master:third_party/blink/renderer/core/editing/commands/editor_command_names.h for valid command names.
        /// </summary>
        public System.Collections.Generic.List<string>? Commands { get; set; }
    }
}
