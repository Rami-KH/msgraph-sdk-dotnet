// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsAmorDegrcRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsAmorDegrcRequestBody
    {
    
        /// <summary>
        /// Gets or sets Cost.
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Cost { get; set; }
    
        /// <summary>
        /// Gets or sets DatePurchased.
        /// </summary>
        [DataMember(Name = "datePurchased", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken DatePurchased { get; set; }
    
        /// <summary>
        /// Gets or sets FirstPeriod.
        /// </summary>
        [DataMember(Name = "firstPeriod", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken FirstPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets Salvage.
        /// </summary>
        [DataMember(Name = "salvage", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Salvage { get; set; }
    
        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Period { get; set; }
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [DataMember(Name = "basis", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
