//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    /// <summary>
    /// Serialized fragment of layer picture along with its offset within the layer.
    /// </summary>
    public sealed class PictureTile
    {
        /// <summary>Offset from owning layer left boundary</summary>
        public double X { get; set; }

        /// <summary>Offset from owning layer top boundary</summary>
        public double Y { get; set; }

        /// <summary>Base64-encoded snapshot data.</summary>
        public byte[] Picture { get; set; }
    }
}
