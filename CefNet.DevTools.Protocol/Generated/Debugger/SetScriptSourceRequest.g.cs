//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetScriptSourceRequest
    {
        /// <summary>Id of the script to edit.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>New content of the script.</summary>
        public string ScriptSource { get; set; }

        /// <summary>
        /// If true the change will not actually be applied. Dry run may be used to get result
        /// description without actually modifying the code.
        /// </summary>
        public bool? DryRun { get; set; }
    }
}
