// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Scheduler;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler
{
    public static partial class JobOperationsExtensions
    {
        /// <summary>
        /// If the user wants the server to create the job id then he can use a
        /// POST request to the jobs resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Job operation.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        public static JobCreateResponse Create(this IJobOperations operations, JobCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// If the user wants the server to create the job id then he can use a
        /// POST request to the jobs resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Job operation.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        public static Task<JobCreateResponse> CreateAsync(this IJobOperations operations, JobCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Jobs can be created or updated with a PUT operation to a job's
        /// address. The resource name is the ID of the job. Doing a PUT
        /// operation on a jobId that already exists will completely overwrite
        /// the existing job. Putting an existing job (replace) will reset
        /// internal execution counters.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the job operation.
        /// </param>
        /// <returns>
        /// The Update Job operation response.
        /// </returns>
        public static JobCreateOrUpdateResponse CreateOrUpdate(this IJobOperations operations, string jobId, JobCreateOrUpdateParameters parameters)
        {
            try
            {
                return operations.CreateOrUpdateAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Jobs can be created or updated with a PUT operation to a job's
        /// address. The resource name is the ID of the job. Doing a PUT
        /// operation on a jobId that already exists will completely overwrite
        /// the existing job. Putting an existing job (replace) will reset
        /// internal execution counters.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the job operation.
        /// </param>
        /// <returns>
        /// The Update Job operation response.
        /// </returns>
        public static Task<JobCreateOrUpdateResponse> CreateOrUpdateAsync(this IJobOperations operations, string jobId, JobCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IJobOperations operations, string jobId)
        {
            try
            {
                return operations.DeleteAsync(jobId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IJobOperations operations, string jobId)
        {
            return operations.DeleteAsync(jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// The status of an individual job can be access by a GET call to a
        /// job's address, jobId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        public static JobGetResponse Get(this IJobOperations operations, string jobId)
        {
            try
            {
                return operations.GetAsync(jobId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The status of an individual job can be access by a GET call to a
        /// job's address, jobId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        public static Task<JobGetResponse> GetAsync(this IJobOperations operations, string jobId)
        {
            return operations.GetAsync(jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static JobGetHistoryResponse GetHistory(this IJobOperations operations, string jobId, JobGetHistoryParameters parameters)
        {
            try
            {
                return operations.GetHistoryAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static Task<JobGetHistoryResponse> GetHistoryAsync(this IJobOperations operations, string jobId, JobGetHistoryParameters parameters)
        {
            return operations.GetHistoryAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History With Filter operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static JobGetHistoryResponse GetHistoryWithFilter(this IJobOperations operations, string jobId, JobGetHistoryWithFilterParameters parameters)
        {
            try
            {
                return operations.GetHistoryWithFilterAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History With Filter operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static Task<JobGetHistoryResponse> GetHistoryWithFilterAsync(this IJobOperations operations, string jobId, JobGetHistoryWithFilterParameters parameters)
        {
            return operations.GetHistoryWithFilterAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetch all jobs in a job collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static JobListResponse List(this IJobOperations operations, JobListParameters parameters)
        {
            try
            {
                return operations.ListAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Fetch all jobs in a job collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static Task<JobListResponse> ListAsync(this IJobOperations operations, JobListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetch jobs in a job collection via a filter.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs with filter operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static JobListResponse ListWithFilter(this IJobOperations operations, JobListWithFilterParameters parameters)
        {
            try
            {
                return operations.ListWithFilterAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Fetch jobs in a job collection via a filter.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs with filter operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static Task<JobListResponse> ListWithFilterAsync(this IJobOperations operations, JobListWithFilterParameters parameters)
        {
            return operations.ListWithFilterAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Job collections can be updated through a simple PATCH operation.
        /// The format of the request is the same as that for creating a job,
        /// though if a field is unspecified we will carry forward the current
        /// value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        public static JobCollectionJobsUpdateStateResponse UpdateJobCollectionState(this IJobOperations operations, PatchJobCollectionJobsUpdateStateParameters parameters)
        {
            try
            {
                return operations.UpdateJobCollectionStateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Job collections can be updated through a simple PATCH operation.
        /// The format of the request is the same as that for creating a job,
        /// though if a field is unspecified we will carry forward the current
        /// value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        public static Task<JobCollectionJobsUpdateStateResponse> UpdateJobCollectionStateAsync(this IJobOperations operations, PatchJobCollectionJobsUpdateStateParameters parameters)
        {
            return operations.UpdateJobCollectionStateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Jobs can be updated through a simple PATCH operation to a job's
        /// address. The format of the request is the same as that for
        /// creating a job, though if a field is unspecified we will carry
        /// forward the current value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Job State operation.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        public static JobUpdateStateResponse UpdateState(this IJobOperations operations, string jobId, JobUpdateStateParameters parameters)
        {
            try
            {
                return operations.UpdateStateAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Jobs can be updated through a simple PATCH operation to a job's
        /// address. The format of the request is the same as that for
        /// creating a job, though if a field is unspecified we will carry
        /// forward the current value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Job State operation.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        public static Task<JobUpdateStateResponse> UpdateStateAsync(this IJobOperations operations, string jobId, JobUpdateStateParameters parameters)
        {
            return operations.UpdateStateAsync(jobId, parameters, CancellationToken.None);
        }
    }
}
