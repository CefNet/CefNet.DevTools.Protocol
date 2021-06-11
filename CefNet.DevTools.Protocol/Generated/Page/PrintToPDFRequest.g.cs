//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class PrintToPDFRequest
    {
        /// <summary>Paper orientation. Defaults to false.</summary>
        public bool? Landscape { get; set; }

        /// <summary>
        /// Display header and footer. Defaults to false.
        /// </summary>
        public bool? DisplayHeaderFooter { get; set; }

        /// <summary>
        /// Print background graphics. Defaults to false.
        /// </summary>
        public bool? PrintBackground { get; set; }

        /// <summary>
        /// Scale of the webpage rendering. Defaults to 1.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// Paper width in inches. Defaults to 8.5 inches.
        /// </summary>
        public double? PaperWidth { get; set; }

        /// <summary>
        /// Paper height in inches. Defaults to 11 inches.
        /// </summary>
        public double? PaperHeight { get; set; }

        /// <summary>
        /// Top margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        public double? MarginTop { get; set; }

        /// <summary>
        /// Bottom margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        public double? MarginBottom { get; set; }

        /// <summary>
        /// Left margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        public double? MarginLeft { get; set; }

        /// <summary>
        /// Right margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Paper ranges to print, e.g., '1-5, 8, 11-13'. Defaults to the empty string, which means
        /// print all pages.
        /// </summary>
        public string? PageRanges { get; set; }

        /// <summary>
        /// Whether to silently ignore invalid but successfully parsed page ranges, such as '3-2'.
        /// Defaults to false.
        /// </summary>
        public bool? IgnoreInvalidPageRanges { get; set; }

        /// <summary>
        /// HTML template for the print header. Should be valid HTML markup with following
        /// classes used to inject printing values into them:
        /// - `date`: formatted print date
        /// - `title`: document title
        /// - `url`: document location
        /// - `pageNumber`: current page number
        /// - `totalPages`: total pages in the document
        /// 
        /// For example, `<span class=title></span>` would generate span containing the title.
        /// </summary>
        public string? HeaderTemplate { get; set; }

        /// <summary>
        /// HTML template for the print footer. Should use the same format as the `headerTemplate`.
        /// </summary>
        public string? FooterTemplate { get; set; }

        /// <summary>
        /// Whether or not to prefer page size as defined by css. Defaults to false,
        /// in which case the content will be scaled to fit the paper size.
        /// </summary>
        public bool? PreferCSSPageSize { get; set; }

        /// <summary>[Experimental] return as stream</summary>
        public CefNet.DevTools.Protocol.Page.PrintToPDFRequestTransferMode? TransferMode { get; set; }
    }
}
