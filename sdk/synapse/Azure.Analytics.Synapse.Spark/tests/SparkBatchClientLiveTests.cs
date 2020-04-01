﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Analytics.Synapse.Spark.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Analytics.Synapse.Spark.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="SparkBatchClient"/> class.
    /// </summary>
    /// <remarks>
    /// These tests have a dependency on live Azure services and may incur costs for the associated
    /// Azure subscription.
    /// </remarks>
    public class SparkBatchClientLiveTests : SparkClientTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SparkBatchClientLiveTests"/> class.
        /// </summary>
        /// <param name="isAsync">A flag used by the Azure Core Test Framework to differentiate between tests for asynchronous and synchronous methods.</param>
        public SparkBatchClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        /// <summary>
        /// Verifies that the <see cref="SparkBatchClient" /> is able to connect to the
        /// Azure Synapse Analytics service and perform operations.
        /// </summary>
        [Test]
        [Ignore("This test case cannot pass due to backend limitations for service principals.")]
        public async Task TestSparkBatchJob()
        {
            // Submit the Spark job
            var createParams = this.CreateSparkJobRequestParameters();
            var jobCreateResponse = (await SparkBatchClient.CreateSparkBatchJobAsync(createParams)).Value;

            // Poll the Spark job until it finishes
            var getJobResponse = await this.PollSparkBatchJobSubmissionAsync(jobCreateResponse);

            // Verify the Spark batch job completes successfully
            Assert.True("success".Equals(getJobResponse.State, StringComparison.OrdinalIgnoreCase) && getJobResponse.Result == SparkBatchJobResultType.Succeeded,
                string.Format(
                    "Job: {0} did not return success. Current job state: {1}. Actual result: {2}. Error (if any): {3}",
                    getJobResponse.Id,
                    getJobResponse.State,
                    getJobResponse.Result,
                    string.Join(", ", getJobResponse.Errors ?? new List<SparkServiceError>())
                )
            );

            // Get the list of Spark batch jobs and check that the submitted job exists
            var listJobResponse = await this.ListSparkBatchJobsAsync();
            Assert.NotNull(listJobResponse);
            Assert.IsTrue(listJobResponse.Any(job => job.Id == getJobResponse.Id));
        }

        [Test]
        public async Task TestGetSparkBatchJob()
        {
            var sparkJobs = (await SparkBatchClient.GetSparkBatchJobsAsync()).Value;
            foreach (var expectedSparkJob in sparkJobs.Sessions)
            {
                var actualSparkJob = await SparkBatchClient.GetSparkBatchJobAsync(expectedSparkJob.Id);
                ValidateSparkBatchJob(expectedSparkJob, actualSparkJob);
            }
        }
    }
}
