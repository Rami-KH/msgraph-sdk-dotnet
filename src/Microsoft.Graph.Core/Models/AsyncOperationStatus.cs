// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    /// <summary>
    /// The type AsyncOperationStatus.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AsyncOperationStatus
    {
    
        /// <summary>
        /// Gets or sets operation.
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false, IsRequired = false)]
        public string Operation { get; set; }
    
        /// <summary>
        /// Gets or sets percentageComplete.
        /// </summary>
        [DataMember(Name = "percentageComplete", EmitDefaultValue = false, IsRequired = false)]
        public double? PercentageComplete { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
