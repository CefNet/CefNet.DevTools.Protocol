//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>[Experimental] The installability error</summary>
    public sealed class InstallabilityError
    {
        /// <summary>
        /// The error id (e.g. 'manifest-missing-suitable-icon').
        /// </summary>
        public string ErrorId { get; set; }

        /// <summary>
        /// The list of error arguments (e.g. {name:'minimum-icon-size-in-pixels', value:'64'}).
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.InstallabilityErrorArgument> ErrorArguments { get; set; }
    }
}
