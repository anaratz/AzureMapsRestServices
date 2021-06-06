﻿using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchRequestBaseExtended : SearchRequestBase
    {
        /// <summary>
        /// Indexes for which extended postal codes should be included in the results.
        /// Available indexes are: 
        /// - Addr = Address ranges
        /// - Geo = Geographies
        /// - PAD = Point Addresses
        /// - POI = Points of Interest
        /// - Str = Streets
        ///  -XStr = Cross Streets(intersections)
        ///  Value should be a comma separated list of index types(in any order) or None for no indexes.
        ///  By default extended postal codes are included for all indexes except Geo. Extended postal code lists for geographies can be quite long so they have to be explicitly requested when needed.
        ///  Usage examples:
        ///  - extendedPostalCodesFor= POI
        ///   -extendedPostalCodesFor= PAD, Addr, POI
        ///   -extendedPostalCodesFor = None
        ///   Extended postal code is returned as an extendedPostalCode property of an address. Availability is region-dependent.
        /// </summary>
        [JsonPropertyName("extendedPostalCodesFor")]
        public string ExtendedPostalCodesFor { get; set; }

        /// <summary>
        /// Starting offset of the returned results within the full result set
        /// </summary>
        [JsonPropertyName("ofs")]
        public int? Offset { get; set; }

        /// <summary>
        /// Maximum number of responses that will be returned
        /// </summary>
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
