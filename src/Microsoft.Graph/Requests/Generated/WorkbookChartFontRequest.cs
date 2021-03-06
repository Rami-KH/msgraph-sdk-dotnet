// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookChartFontRequest.
    /// </summary>
    public partial class WorkbookChartFontRequest : BaseRequest, IWorkbookChartFontRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartFontRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartFontRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartFont using POST.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <returns>The created WorkbookChartFont.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFont> CreateAsync(WorkbookChartFont workbookChartFontToCreate)
        {
            return this.CreateAsync(workbookChartFontToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartFont using POST.
        /// </summary>
        /// <param name="workbookChartFontToCreate">The WorkbookChartFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFont> CreateAsync(WorkbookChartFont workbookChartFontToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartFont>(workbookChartFontToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartFont.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartFont>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartFont.
        /// </summary>
        /// <returns>The WorkbookChartFont.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFont> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFont> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartFont>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartFont using PATCH.
        /// </summary>
        /// <param name="workbookChartFontToUpdate">The WorkbookChartFont to update.</param>
        /// <returns>The updated WorkbookChartFont.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFont> UpdateAsync(WorkbookChartFont workbookChartFontToUpdate)
        {
            return this.UpdateAsync(workbookChartFontToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartFont using PATCH.
        /// </summary>
        /// <param name="workbookChartFontToUpdate">The WorkbookChartFont to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartFont.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFont> UpdateAsync(WorkbookChartFont workbookChartFontToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartFont>(workbookChartFontToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFontRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFontRequest Expand(Expression<Func<WorkbookChartFont, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFontRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFontRequest Select(Expression<Func<WorkbookChartFont, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartFontToInitialize">The <see cref="WorkbookChartFont"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartFont workbookChartFontToInitialize)
        {

        }
    }
}
