// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ParameterGroupingOperations.
    /// </summary>
    public static partial class ParameterGroupingOperationsExtensions
    {
            /// <summary>
            /// Post a bunch of required parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostRequiredParameters'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostRequired(this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters)
            {
                ((IParameterGroupingOperations)operations).PostRequiredAsync(parameterGroupingPostRequiredParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a bunch of required parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostRequiredParameters'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostRequiredAsync(this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PostRequiredWithHttpMessagesAsync(parameterGroupingPostRequiredParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Post a bunch of optional parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostOptionalParameters'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostOptional(this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParameters))
            {
                ((IParameterGroupingOperations)operations).PostOptionalAsync(parameterGroupingPostOptionalParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a bunch of optional parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostOptionalParameters'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostOptionalAsync(this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PostOptionalWithHttpMessagesAsync(parameterGroupingPostOptionalParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Post parameters from multiple different parameter groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='parameterGroupingPostMultiParamGroupsSecondParamGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostMultiParamGroups(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = default(ParameterGroupingPostMultiParamGroupsSecondParamGroup))
            {
                ((IParameterGroupingOperations)operations).PostMultiParamGroupsAsync(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post parameters from multiple different parameter groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='parameterGroupingPostMultiParamGroupsSecondParamGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostMultiParamGroupsAsync(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = default(ParameterGroupingPostMultiParamGroupsSecondParamGroup), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PostMultiParamGroupsWithHttpMessagesAsync(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Post parameters with a shared parameter group object
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostSharedParameterGroupObject(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup))
            {
                ((IParameterGroupingOperations)operations).PostSharedParameterGroupObjectAsync(firstParameterGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post parameters with a shared parameter group object
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostSharedParameterGroupObjectAsync(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PostSharedParameterGroupObjectWithHttpMessagesAsync(firstParameterGroup, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}