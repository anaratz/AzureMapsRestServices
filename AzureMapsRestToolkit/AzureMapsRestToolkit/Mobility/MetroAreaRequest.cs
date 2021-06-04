﻿using System.Text.Json.Serialization;

using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    public class MetroAreaRequest : RequestBase
    {
        /// <summary>
        /// The applicable location input. Can be position (specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679") or countryCode (2-character ISO country code).
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }


        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The type of the query. By default originType=position, specified as a comma separated string composed by latitude followed by longitude, e.g. "47.641268,-122.125679”.
        /// </summary>
        [JsonPropertyName("queryType")]
        public QueryType QueryType { get; set; }
    }
}
