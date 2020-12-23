﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Azure.Analytics.Synapse.Spark;
using Azure.Analytics.Synapse.Spark.Models;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.Samples
{
    /// <summary>
    /// This sample demonstrates how to submit Spark job in Azure Synapse Analytics using synchronous methods of <see cref="SparkBatchClient"/>.
    /// </summary>
    public partial class Sample1_SubmitSparkJob : SampleFixture
    {
        [Test]
        public void SubmitSparkJobSync()
        {
            // Environment variable with the Synapse workspace endpoint.
            string endpoint = TestEnvironment.EndpointUrl;

            // Environment variable with the Synapse Spark pool name.
            string sparkPoolName = TestEnvironment.SparkPoolName;

            // Environment variable with the ADLS Gen2 storage account associated with the Synapse workspace.
            string storageAccount = TestEnvironment.StorageAccountName;

            // Environment variable with the file system of ADLS Gen2 storage account associated with the Synapse workspace.
            string fileSystem = TestEnvironment.StorageFileSystemName;

            #region Snippet:CreateSparkBatchClient
            SparkBatchClient client = new SparkBatchClient(new Uri(endpoint), sparkPoolName, new DefaultAzureCredential());
            #endregion

            #region Snippet:SubmitSparkBatchJob
            string name = $"batch-{Guid.NewGuid()}";
            string file = string.Format("abfss://{0}@{1}.dfs.core.windows.net/samples/net/wordcount/wordcount.zip", fileSystem, storageAccount);
            SparkBatchJobOptions request = new SparkBatchJobOptions(name, file)
            {
                ClassName = "WordCount",
                Arguments =
                {
                    string.Format("abfss://{0}@{1}.dfs.core.windows.net/samples/net/wordcount/shakespeare.txt", fileSystem, storageAccount),
                    string.Format("abfss://{0}@{1}.dfs.core.windows.net/samples/net/wordcount/result/", fileSystem, storageAccount),
                },
                DriverMemory = "28g",
                DriverCores = 4,
                ExecutorMemory = "28g",
                ExecutorCores = 4,
                ExecutorCount = 2
            };

            SparkBatchOperation createOperation = client.StartCreateSparkBatchJob(request);
            while (!createOperation.HasCompleted)
            {
                System.Threading.Thread.Sleep(2000);
                createOperation.UpdateStatus();
            }
            SparkBatchJob jobCreated = createOperation.Value;
            #endregion

            #region Snippet:ListSparkBatchJobs
            Response<SparkBatchJobCollection> jobs = client.GetSparkBatchJobs();
            foreach (SparkBatchJob job in jobs.Value.Sessions)
            {
                Console.WriteLine(job.Name);
            }
            #endregion

            #region Snippet:GetSparkBatchJob
            SparkBatchOperation getOperation = client.StartGetSparkBatchJob (jobCreated.Id);
            while (!getOperation.HasCompleted)
            {
                System.Threading.Thread.Sleep(2000);
                getOperation.UpdateStatus();
            }
            SparkBatchJob retrievedJob = getOperation.Value;

            Debug.WriteLine($"Job is returned with name {retrievedJob.Name} and state {retrievedJob.State}");
            #endregion

            #region Snippet:DeleteSparkBatchJob
            Response operation = client.CancelSparkBatchJob(jobCreated.Id);
            #endregion
        }
    }
}
