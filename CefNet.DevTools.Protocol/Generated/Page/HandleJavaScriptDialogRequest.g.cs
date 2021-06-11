//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class HandleJavaScriptDialogRequest
    {
        /// <summary>Whether to accept or dismiss the dialog.</summary>
        public bool Accept { get; set; }

        /// <summary>
        /// The text to enter into the dialog prompt before accepting. Used only if this is a prompt
        /// dialog.
        /// </summary>
        public string? PromptText { get; set; }
    }
}
