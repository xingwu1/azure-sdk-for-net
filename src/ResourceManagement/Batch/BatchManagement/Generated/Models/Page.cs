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
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a page in Azure responses.
    /// </summary>
    /// <typeparam name="T">Type of the page content items</typeparam>
    [JsonObject]
    public class Page<T> : IPage<T>
    {
         /// <summary>
         /// Gets the link to the next page.
         /// </summary>
         [JsonProperty("nextLink")]
         public string NextPageLink { get; private set; }

         [JsonProperty("value")]
         private IList<T> Items{ get; set; }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         public IEnumerator<T> GetEnumerator()
         {
              return (Items == null) ? Enumerable.Empty<T>().GetEnumerator() : Items.GetEnumerator();
         }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
    }
}
