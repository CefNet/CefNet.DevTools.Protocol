//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class JavascriptDialogOpeningEventArgs
        : System.EventArgs
    {
        /// <summary>Frame url.</summary>
        public string Url { get; set; }

        /// <summary>
        /// Message that will be displayed by the dialog.
        /// </summary>
        public string Message { get; set; }

        /// <summary>Dialog type.</summary>
        public CefNet.DevTools.Protocol.Page.DialogType Type { get; set; }

        /// <summary>
        /// True iff browser is capable showing or acting on the given dialog. When browser has no
        /// dialog handler for given target, calling alert while Page domain is engaged will stall
        /// the page execution. Execution can be resumed via calling Page.handleJavaScriptDialog.
        /// </summary>
        public bool HasBrowserHandler { get; set; }

        /// <summary>Default dialog prompt.</summary>
        public string? DefaultPrompt { get; set; }
    }
}
