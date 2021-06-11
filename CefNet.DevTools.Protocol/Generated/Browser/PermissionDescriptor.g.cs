//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>
    /// [Experimental] Definition of PermissionDescriptor defined in the Permissions API:
    /// https://w3c.github.io/permissions/#dictdef-permissiondescriptor.
    /// </summary>
    public sealed class PermissionDescriptor
    {
        /// <summary>
        /// Name of permission.
        /// See https://cs.chromium.org/chromium/src/third_party/blink/renderer/modules/permissions/permission_descriptor.idl for valid permission names.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// For "midi" permission, may also specify sysex control.
        /// </summary>
        public bool? Sysex { get; set; }

        /// <summary>
        /// For "push" permission, may specify userVisibleOnly.
        /// Note that userVisibleOnly = true is the only currently supported type.
        /// </summary>
        public bool? UserVisibleOnly { get; set; }

        /// <summary>
        /// For "clipboard" permission, may specify allowWithoutSanitization.
        /// </summary>
        public bool? AllowWithoutSanitization { get; set; }

        /// <summary>
        /// For "camera" permission, may specify panTiltZoom.
        /// </summary>
        public bool? PanTiltZoom { get; set; }
    }
}
