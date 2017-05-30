// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Full view of network features for an app (presently VNET integration
    /// and Hybrid Connections).
    /// </summary>
    [JsonTransformation]
    public partial class NetworkFeatures : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkFeatures class.
        /// </summary>
        public NetworkFeatures() { }

        /// <summary>
        /// Initializes a new instance of the NetworkFeatures class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualNetworkName">The Virtual Network name.</param>
        /// <param name="virtualNetworkConnection">The Virtual Network summary
        /// view.</param>
        /// <param name="hybridConnections">The Hybrid Connections summary
        /// view.</param>
        /// <param name="hybridConnectionsV2">The Hybrid Connection V2 (Service
        /// Bus) view.</param>
        public NetworkFeatures(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string virtualNetworkName = default(string), VnetInfo virtualNetworkConnection = default(VnetInfo), IList<RelayServiceConnectionEntity> hybridConnections = default(IList<RelayServiceConnectionEntity>), IList<HybridConnection> hybridConnectionsV2 = default(IList<HybridConnection>))
            : base(location, id, name, kind, type, tags)
        {
            VirtualNetworkName = virtualNetworkName;
            VirtualNetworkConnection = virtualNetworkConnection;
            HybridConnections = hybridConnections;
            HybridConnectionsV2 = hybridConnectionsV2;
        }

        /// <summary>
        /// Gets the Virtual Network name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkName")]
        public string VirtualNetworkName { get; protected set; }

        /// <summary>
        /// Gets the Virtual Network summary view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkConnection")]
        public VnetInfo VirtualNetworkConnection { get; protected set; }

        /// <summary>
        /// Gets the Hybrid Connections summary view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hybridConnections")]
        public IList<RelayServiceConnectionEntity> HybridConnections { get; protected set; }

        /// <summary>
        /// Gets the Hybrid Connection V2 (Service Bus) view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hybridConnectionsV2")]
        public IList<HybridConnection> HybridConnectionsV2 { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (VirtualNetworkConnection != null)
            {
                VirtualNetworkConnection.Validate();
            }
            if (HybridConnections != null)
            {
                foreach (var element in HybridConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (HybridConnectionsV2 != null)
            {
                foreach (var element1 in HybridConnectionsV2)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
