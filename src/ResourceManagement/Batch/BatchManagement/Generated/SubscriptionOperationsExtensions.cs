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

namespace Microsoft.Azure.Management.Batch
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SubscriptionOperations.
    /// </summary>
    public static partial class SubscriptionOperationsExtensions
    {
            /// <summary>
            /// The Get Subscription Quotas operation returns the quotas of the
            /// subscription in the Batch service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The region of the quotas belongs.
            /// </param>
            public static SubscriptionQuotasGetResult GetSubscriptionQuotas(this ISubscriptionOperations operations, string locationName)
            {
                return Task.Factory.StartNew(s => ((ISubscriptionOperations)s).GetSubscriptionQuotasAsync(locationName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get Subscription Quotas operation returns the quotas of the
            /// subscription in the Batch service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The region of the quotas belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionQuotasGetResult> GetSubscriptionQuotasAsync(this ISubscriptionOperations operations, string locationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionQuotasWithHttpMessagesAsync(locationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
