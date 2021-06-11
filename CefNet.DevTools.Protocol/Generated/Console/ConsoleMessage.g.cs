//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Console
{
    /// <summary>Console message.</summary>
    public sealed class ConsoleMessage
    {
        /// <summary>Message source.</summary>
        public CefNet.DevTools.Protocol.Console.ConsoleMessageSource Source { get; set; }

        /// <summary>Message severity.</summary>
        public CefNet.DevTools.Protocol.Console.ConsoleMessageLevel Level { get; set; }

        /// <summary>Message text.</summary>
        public string Text { get; set; }

        /// <summary>URL of the message origin.</summary>
        public string? Url { get; set; }

        /// <summary>
        /// Line number in the resource that generated this message (1-based).
        /// </summary>
        public int? Line { get; set; }

        /// <summary>
        /// Column number in the resource that generated this message (1-based).
        /// </summary>
        public int? Column { get; set; }
    }
}
