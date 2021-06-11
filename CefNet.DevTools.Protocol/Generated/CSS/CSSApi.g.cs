//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>
    /// [Experimental] This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
    /// have an associated `id` used in subsequent operations on the related object. Each object type has
    /// a specific `id` structure, and those are not interchangeable between objects of different kinds.
    /// CSS objects can be loaded using the `get*ForNode()` calls (which accept a DOM node id). A client
    /// can also keep track of stylesheets via the `styleSheetAdded`/`styleSheetRemoved` events and
    /// subsequently load the required stylesheet contents using the `getStyleSheet[Text]()` methods.
    /// </summary>
    public readonly struct CSSApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal CSSApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
        /// position specified by `location`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.AddRuleResponse> AddRuleAsync(
            CefNet.DevTools.Protocol.CSS.AddRuleRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.AddRuleRequest, CefNet.DevTools.Protocol.CSS.AddRuleResponse>(
                    "CSS.addRule", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all class names from specified stylesheet.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.CollectClassNamesResponse> CollectClassNamesAsync(
            CefNet.DevTools.Protocol.CSS.CollectClassNamesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.CollectClassNamesRequest, CefNet.DevTools.Protocol.CSS.CollectClassNamesResponse>(
                    "CSS.collectClassNames", parameters, cancellationToken);
        }

        /// <summary>
        /// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.CreateStyleSheetResponse> CreateStyleSheetAsync(
            CefNet.DevTools.Protocol.CSS.CreateStyleSheetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.CreateStyleSheetRequest, CefNet.DevTools.Protocol.CSS.CreateStyleSheetResponse>(
                    "CSS.createStyleSheet", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables the CSS agent for the given page.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "CSS.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been
        /// enabled until the result of this command is received.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "CSS.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Ensures that the given node will have specified pseudo-classes whenever its style is computed by
        /// the browser.
        /// </summary>
        public readonly System.Threading.Tasks.Task ForcePseudoStateAsync(
            CefNet.DevTools.Protocol.CSS.ForcePseudoStateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.ForcePseudoStateRequest>(
                    "CSS.forcePseudoState", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetBackgroundColorsResponse> GetBackgroundColorsAsync(
            CefNet.DevTools.Protocol.CSS.GetBackgroundColorsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetBackgroundColorsRequest, CefNet.DevTools.Protocol.CSS.GetBackgroundColorsResponse>(
                    "CSS.getBackgroundColors", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns the computed style for a DOM node identified by `nodeId`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetComputedStyleForNodeResponse> GetComputedStyleForNodeAsync(
            CefNet.DevTools.Protocol.CSS.GetComputedStyleForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetComputedStyleForNodeRequest, CefNet.DevTools.Protocol.CSS.GetComputedStyleForNodeResponse>(
                    "CSS.getComputedStyleForNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
        /// attributes) for a DOM node identified by `nodeId`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetInlineStylesForNodeResponse> GetInlineStylesForNodeAsync(
            CefNet.DevTools.Protocol.CSS.GetInlineStylesForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetInlineStylesForNodeRequest, CefNet.DevTools.Protocol.CSS.GetInlineStylesForNodeResponse>(
                    "CSS.getInlineStylesForNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns requested styles for a DOM node identified by `nodeId`.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetMatchedStylesForNodeResponse> GetMatchedStylesForNodeAsync(
            CefNet.DevTools.Protocol.CSS.GetMatchedStylesForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetMatchedStylesForNodeRequest, CefNet.DevTools.Protocol.CSS.GetMatchedStylesForNodeResponse>(
                    "CSS.getMatchedStylesForNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all media queries parsed by the rendering engine.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetMediaQueriesResponse> GetMediaQueriesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.CSS.GetMediaQueriesResponse>(
                    "CSS.getMediaQueries", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Requests information about platform fonts which we used to render child TextNodes in the given
        /// node.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetPlatformFontsForNodeResponse> GetPlatformFontsForNodeAsync(
            CefNet.DevTools.Protocol.CSS.GetPlatformFontsForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetPlatformFontsForNodeRequest, CefNet.DevTools.Protocol.CSS.GetPlatformFontsForNodeResponse>(
                    "CSS.getPlatformFontsForNode", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns the current textual content for a stylesheet.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.GetStyleSheetTextResponse> GetStyleSheetTextAsync(
            CefNet.DevTools.Protocol.CSS.GetStyleSheetTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.GetStyleSheetTextRequest, CefNet.DevTools.Protocol.CSS.GetStyleSheetTextResponse>(
                    "CSS.getStyleSheetText", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Modifies the expression of a container query.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetContainerQueryTextResponse> SetContainerQueryTextAsync(
            CefNet.DevTools.Protocol.CSS.SetContainerQueryTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetContainerQueryTextRequest, CefNet.DevTools.Protocol.CSS.SetContainerQueryTextResponse>(
                    "CSS.setContainerQueryText", parameters, cancellationToken);
        }

        /// <summary>
        /// Find a rule with the given active property for the given node and set the new value for this
        /// property
        /// </summary>
        public readonly System.Threading.Tasks.Task SetEffectivePropertyValueForNodeAsync(
            CefNet.DevTools.Protocol.CSS.SetEffectivePropertyValueForNodeRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetEffectivePropertyValueForNodeRequest>(
                    "CSS.setEffectivePropertyValueForNode", parameters, cancellationToken);
        }

        /// <summary>Modifies the keyframe rule key text.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetKeyframeKeyResponse> SetKeyframeKeyAsync(
            CefNet.DevTools.Protocol.CSS.SetKeyframeKeyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetKeyframeKeyRequest, CefNet.DevTools.Protocol.CSS.SetKeyframeKeyResponse>(
                    "CSS.setKeyframeKey", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enables/disables rendering of local CSS fonts (enabled by default).
        /// </summary>
        public readonly System.Threading.Tasks.Task SetLocalFontsEnabledAsync(
            CefNet.DevTools.Protocol.CSS.SetLocalFontsEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetLocalFontsEnabledRequest>(
                    "CSS.setLocalFontsEnabled", parameters, cancellationToken);
        }

        /// <summary>Modifies the rule selector.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetMediaTextResponse> SetMediaTextAsync(
            CefNet.DevTools.Protocol.CSS.SetMediaTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetMediaTextRequest, CefNet.DevTools.Protocol.CSS.SetMediaTextResponse>(
                    "CSS.setMediaText", parameters, cancellationToken);
        }

        /// <summary>Modifies the rule selector.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetRuleSelectorResponse> SetRuleSelectorAsync(
            CefNet.DevTools.Protocol.CSS.SetRuleSelectorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetRuleSelectorRequest, CefNet.DevTools.Protocol.CSS.SetRuleSelectorResponse>(
                    "CSS.setRuleSelector", parameters, cancellationToken);
        }

        /// <summary>Sets the new stylesheet text.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetStyleSheetTextResponse> SetStyleSheetTextAsync(
            CefNet.DevTools.Protocol.CSS.SetStyleSheetTextRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetStyleSheetTextRequest, CefNet.DevTools.Protocol.CSS.SetStyleSheetTextResponse>(
                    "CSS.setStyleSheetText", parameters, cancellationToken);
        }

        /// <summary>
        /// Applies specified style edits one after another in the given order.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.SetStyleTextsResponse> SetStyleTextsAsync(
            CefNet.DevTools.Protocol.CSS.SetStyleTextsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.SetStyleTextsRequest, CefNet.DevTools.Protocol.CSS.SetStyleTextsResponse>(
                    "CSS.setStyleTexts", parameters, cancellationToken);
        }

        /// <summary>Enables the selector recording.</summary>
        public readonly System.Threading.Tasks.Task StartRuleUsageTrackingAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "CSS.startRuleUsageTracking", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Stop tracking rule usage and return the list of rules that were used since last call to
        /// `takeCoverageDelta` (or since start of coverage instrumentation)
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.StopRuleUsageTrackingResponse> StopRuleUsageTrackingAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.CSS.StopRuleUsageTrackingResponse>(
                    "CSS.stopRuleUsageTracking", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Polls the next batch of computed style updates.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.TakeComputedStyleUpdatesResponse> TakeComputedStyleUpdatesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.CSS.TakeComputedStyleUpdatesResponse>(
                    "CSS.takeComputedStyleUpdates", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Obtain list of rules that became used since last call to this method (or since start of coverage
        /// instrumentation)
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CSS.TakeCoverageDeltaResponse> TakeCoverageDeltaAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.CSS.TakeCoverageDeltaResponse>(
                    "CSS.takeCoverageDelta", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Starts tracking the given computed styles for updates. The specified array of properties
        /// replaces the one previously specified. Pass empty array to disable tracking.
        /// Use takeComputedStyleUpdates to retrieve the list of nodes that had properties modified.
        /// The changes to computed style properties are only tracked for nodes pushed to the front-end
        /// by the DOM agent. If no changes to the tracked properties occur after the node has been pushed
        /// to the front-end, no updates will be issued for the node.
        /// </summary>
        public readonly System.Threading.Tasks.Task TrackComputedStyleUpdatesAsync(
            CefNet.DevTools.Protocol.CSS.TrackComputedStyleUpdatesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CSS.TrackComputedStyleUpdatesRequest>(
                    "CSS.trackComputedStyleUpdates", parameters, cancellationToken);
        }

        /// <summary>
        /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
        /// web font
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.CSS.FontsUpdatedEventArgs> FontsUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.CSS.FontsUpdatedEventArgs>("CSS.fontsUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.CSS.FontsUpdatedEventArgs>("CSS.fontsUpdated", value);
            }
        }

        /// <summary>
        /// Fires whenever a MediaQuery result changes (for example, after a browser window has been
        /// resized.) The current implementation considers only viewport-dependent media features.
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> MediaQueryResultChanged 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("CSS.mediaQueryResultChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("CSS.mediaQueryResultChanged", value);
            }
        }

        /// <summary>
        /// Fired whenever an active document stylesheet is added.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetAddedEventArgs> StyleSheetAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetAddedEventArgs>("CSS.styleSheetAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetAddedEventArgs>("CSS.styleSheetAdded", value);
            }
        }

        /// <summary>
        /// Fired whenever a stylesheet is changed as a result of the client operation.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetChangedEventArgs> StyleSheetChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetChangedEventArgs>("CSS.styleSheetChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetChangedEventArgs>("CSS.styleSheetChanged", value);
            }
        }

        /// <summary>
        /// Fired whenever an active document stylesheet is removed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetRemovedEventArgs> StyleSheetRemoved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetRemovedEventArgs>("CSS.styleSheetRemoved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.CSS.StyleSheetRemovedEventArgs>("CSS.styleSheetRemoved", value);
            }
        }
    }
}
