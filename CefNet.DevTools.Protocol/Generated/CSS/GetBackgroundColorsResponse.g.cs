//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class GetBackgroundColorsResponse
    {
        /// <summary>
        /// The range of background colors behind this element, if it contains any visible text. If no
        /// visible text is present, this will be undefined. In the case of a flat background color,
        /// this will consist of simply that color. In the case of a gradient, this will consist of each
        /// of the color stops. For anything more complicated, this will be an empty array. Images will
        /// be ignored (as if the image had failed to load).
        /// </summary>
        public System.Collections.Generic.List<string>? BackgroundColors { get; set; }

        /// <summary>
        /// The computed font size for this node, as a CSS computed value string (e.g. '12px').
        /// </summary>
        public string? ComputedFontSize { get; set; }

        /// <summary>
        /// The computed font weight for this node, as a CSS computed value string (e.g. 'normal' or
        /// '100').
        /// </summary>
        public string? ComputedFontWeight { get; set; }
    }
}
