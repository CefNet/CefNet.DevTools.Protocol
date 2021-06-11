//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    public sealed class LayerPaintedEventArgs
        : System.EventArgs
    {
        /// <summary>The id of the painted layer.</summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerId LayerId { get; set; }

        /// <summary>Clip rectangle.</summary>
        public CefNet.DevTools.Protocol.DOM.Rect Clip { get; set; }
    }
}
