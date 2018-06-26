// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric value.
    /// </summary>
    public partial class MetricValue
    {
        /// <summary>
        /// Initializes a new instance of the MetricValue class.
        /// </summary>
        public MetricValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricValue class.
        /// </summary>
        /// <param name="timeStamp">Timestamp of metric value.</param>
        /// <param name="average">Average value of metric.</param>
        /// <param name="minimum">Minimum value of metric.</param>
        /// <param name="maximum">Maximum value of metric.</param>
        /// <param name="total">Total value of metric.</param>
        /// <param name="count">Count of metric values.</param>
        /// <param name="properties">Metric value properties.</param>
        public MetricValue(System.DateTime? timeStamp = default(System.DateTime?), double? average = default(double?), double? minimum = default(double?), double? maximum = default(double?), double? total = default(double?), int? count = default(int?), string properties = default(string))
        {
            TimeStamp = timeStamp;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            Total = total;
            Count = count;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets timestamp of metric value.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTime? TimeStamp { get; private set; }

        /// <summary>
        /// Gets average value of metric.
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Gets minimum value of metric.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; private set; }

        /// <summary>
        /// Gets maximum value of metric.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; private set; }

        /// <summary>
        /// Gets total value of metric.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; private set; }

        /// <summary>
        /// Gets count of metric values.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; private set; }

        /// <summary>
        /// Gets metric value properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public string Properties { get; private set; }

    }
}