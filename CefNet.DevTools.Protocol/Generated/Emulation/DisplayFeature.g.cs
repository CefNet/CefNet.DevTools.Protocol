//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class DisplayFeature
    {
        /// <summary>
        /// Orientation of a display feature in relation to screen
        /// </summary>
        public CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation Orientation { get; set; }

        /// <summary>
        /// The offset from the screen origin in either the x (for vertical
        /// orientation) or y (for horizontal orientation) direction.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// A display feature may mask content such that it is not physically
        /// displayed - this length along with the offset describes this area.
        /// A display feature that only splits content will have a 0 mask_length.
        /// </summary>
        public int MaskLength { get; set; }
    }
}
