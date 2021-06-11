//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Log
{
    /// <summary>Violation configuration setting.</summary>
    public sealed class ViolationSetting
    {
        /// <summary>Violation type.</summary>
        public CefNet.DevTools.Protocol.Log.ViolationSettingName Name { get; set; }

        /// <summary>Time threshold to trigger upon.</summary>
        public double Threshold { get; set; }
    }
}
