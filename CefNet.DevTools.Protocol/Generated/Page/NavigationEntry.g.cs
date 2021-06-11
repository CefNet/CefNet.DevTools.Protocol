//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Navigation history entry.</summary>
    public sealed class NavigationEntry
    {
        /// <summary>
        /// Unique id of the navigation history entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>URL of the navigation history entry.</summary>
        public string Url { get; set; }

        /// <summary>URL that the user typed in the url bar.</summary>
        public string UserTypedURL { get; set; }

        /// <summary>Title of the navigation history entry.</summary>
        public string Title { get; set; }

        /// <summary>Transition type.</summary>
        public CefNet.DevTools.Protocol.Page.TransitionType TransitionType { get; set; }
    }
}
