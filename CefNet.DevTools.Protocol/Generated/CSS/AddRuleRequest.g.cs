//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class AddRuleRequest
    {
        /// <summary>
        /// The css style sheet identifier where a new rule should be inserted.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId StyleSheetId { get; set; }

        /// <summary>The text of a new rule.</summary>
        public string RuleText { get; set; }

        /// <summary>
        /// Text position of a new rule in the target style sheet.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange Location { get; set; }
    }
}
