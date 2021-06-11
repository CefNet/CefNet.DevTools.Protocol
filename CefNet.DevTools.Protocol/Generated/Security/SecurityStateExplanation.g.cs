//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Security
{
    /// <summary>
    /// An explanation of an factor contributing to the security state.
    /// </summary>
    public sealed class SecurityStateExplanation
    {
        /// <summary>
        /// Security state representing the severity of the factor being explained.
        /// </summary>
        public CefNet.DevTools.Protocol.Security.SecurityState SecurityState { get; set; }

        /// <summary>Title describing the type of factor.</summary>
        public string Title { get; set; }

        /// <summary>
        /// Short phrase describing the type of factor.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>Full text explanation of the factor.</summary>
        public string Description { get; set; }

        /// <summary>
        /// The type of mixed content described by the explanation.
        /// </summary>
        public CefNet.DevTools.Protocol.Security.MixedContentType MixedContentType { get; set; }

        /// <summary>Page certificate.</summary>
        public System.Collections.Generic.List<string> Certificate { get; set; }

        /// <summary>Recommendations to fix any issues.</summary>
        public System.Collections.Generic.List<string>? Recommendations { get; set; }
    }
}
