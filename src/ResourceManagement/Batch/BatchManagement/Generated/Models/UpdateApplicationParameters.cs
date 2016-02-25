// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for an ApplicationOperations.UpdateApplication request.
    /// </summary>
    public partial class UpdateApplicationParameters
    {
        /// <summary>
        /// Initializes a new instance of the UpdateApplicationParameters
        /// class.
        /// </summary>
        public UpdateApplicationParameters() { }

        /// <summary>
        /// Initializes a new instance of the UpdateApplicationParameters
        /// class.
        /// </summary>
        public UpdateApplicationParameters(bool? allowUpdates = default(bool?), string defaultVersion = default(string), string displayName = default(string))
        {
            AllowUpdates = allowUpdates;
            DefaultVersion = defaultVersion;
            DisplayName = displayName;
        }

        /// <summary>
        /// Gets or sets whether packages within the application may be
        /// overwritten using the same version string.
        /// </summary>
        [JsonProperty(PropertyName = "allowUpdates")]
        public bool? AllowUpdates { get; set; }

        /// <summary>
        /// Gets or sets which package to use if a client requests the
        /// application but does not specify a version.
        /// </summary>
        [JsonProperty(PropertyName = "defaultVersion")]
        public string DefaultVersion { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
