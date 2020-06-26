﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Training;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.FormRecognizer.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="FormTrainingClient"/> class.
    /// </summary>
    /// <remarks>
    /// These tests have a dependency on live Azure services and may incur costs for the associated
    /// Azure subscription.
    /// </remarks>
    public class FormTrainingClientLiveTests : FormRecognizerLiveTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormTrainingClientLiveTests"/> class.
        /// </summary>
        /// <param name="isAsync">A flag used by the Azure Core Test Framework to differentiate between tests for asynchronous and synchronous methods.</param>
        public FormTrainingClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void FormTrainingClientCannotAuthenticateWithFakeApiKey()
        {
            var client = CreateInstrumentedFormTrainingClient(apiKey: "fakeKey");
            Assert.ThrowsAsync<RequestFailedException>(async () => await client.GetAccountPropertiesAsync());
        }

        [Test]
        public async Task FormTrainingClientCanAuthenticateWithTokenCredential()
        {
            var client = CreateInstrumentedFormTrainingClient(useTokenCredential: true);
            var trainingFilesUri = new Uri(TestEnvironment.BlobContainerSasUrl);

            TrainingOperation operation = await client.StartTrainingAsync(trainingFilesUri, useTrainingLabels: false);

            CustomFormModel model = await operation.WaitForCompletionAsync(PollingInterval);

            // Sanity check to make sure we got an actual response back from the service.
            Assert.IsNotNull(model.ModelId);
            Assert.AreEqual(CustomFormModelStatus.Ready, model.Status);
            Assert.IsNotNull(model.Errors);
            Assert.AreEqual(0, model.Errors.Count);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task StartTraining(bool labeled)
        {
            var client = CreateInstrumentedFormTrainingClient();
            var trainingFilesUri = new Uri(TestEnvironment.BlobContainerSasUrl);

            TrainingOperation operation = await client.StartTrainingAsync(trainingFilesUri, labeled);
            await operation.WaitForCompletionAsync(PollingInterval);

            Assert.IsTrue(operation.HasValue);

            CustomFormModel model = operation.Value;

            Assert.IsNotNull(model.ModelId);
            Assert.IsNotNull(model.TrainingStartedOn);
            Assert.IsNotNull(model.TrainingCompletedOn);
            Assert.AreEqual(CustomFormModelStatus.Ready, model.Status);
            Assert.IsNotNull(model.Errors);
            Assert.AreEqual(0, model.Errors.Count);

            foreach (TrainingDocumentInfo doc in model.TrainingDocuments)
            {
                Assert.IsNotNull(doc.DocumentName);
                Assert.IsNotNull(doc.PageCount);
                Assert.AreEqual(TrainingStatus.Succeeded, doc.Status);
                Assert.IsNotNull(doc.Errors);
                Assert.AreEqual(0, doc.Errors.Count);
            }

            foreach (var submodel in model.Submodels)
            {
                Assert.IsNotNull(submodel.FormType);
                foreach (var fields in submodel.Fields)
                {
                    Assert.IsNotNull(fields.Value.Name);
                    if (labeled)
                        Assert.IsNotNull(fields.Value.Accuracy);
                    else
                        Assert.IsNotNull(fields.Value.Label);
                }
            }
        }

        [Test]
        public async Task StartTrainingFailsWithInvalidPrefix()
        {
            var client = CreateInstrumentedFormTrainingClient();
            var trainingFilesUri = new Uri(TestEnvironment.BlobContainerSasUrl);
            TrainingOperation operation;

            var filter = new TrainingFileFilter { IncludeSubFolders = true, Prefix = "invalidPrefix" };

            operation = await client.StartTrainingAsync(trainingFilesUri, useTrainingLabels: false, filter);

            Assert.ThrowsAsync<RequestFailedException>(async () => await operation.WaitForCompletionAsync(PollingInterval));
        }

        [Test]
        public async Task StartTrainingError()
        {
            var client = CreateInstrumentedFormTrainingClient();

            var containerUrl = new Uri("https://someUrl");

            TrainingOperation operation = await client.StartTrainingAsync(containerUrl, useTrainingLabels: false);
            Assert.ThrowsAsync<RequestFailedException>(async () => await operation.WaitForCompletionAsync(PollingInterval));

            Assert.False(operation.HasValue);
            Assert.Throws<RequestFailedException>(() => operation.Value.GetType());
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task TrainingOps(bool labeled)
        {
            var client = CreateInstrumentedFormTrainingClient();
            var trainingFilesUri = new Uri(TestEnvironment.BlobContainerSasUrl);

            TrainingOperation operation = await client.StartTrainingAsync(trainingFilesUri, labeled);

            await operation.WaitForCompletionAsync(PollingInterval);

            Assert.IsTrue(operation.HasValue);

            CustomFormModel trainedModel = operation.Value;

            CustomFormModel resultModel = await client.GetCustomModelAsync(trainedModel.ModelId);

            Assert.AreEqual(trainedModel.ModelId, resultModel.ModelId);
            Assert.AreEqual(trainedModel.TrainingStartedOn, resultModel.TrainingStartedOn);
            Assert.AreEqual(trainedModel.TrainingCompletedOn, resultModel.TrainingCompletedOn);
            Assert.AreEqual(CustomFormModelStatus.Ready, resultModel.Status);
            Assert.AreEqual(trainedModel.Status, resultModel.Status);
            Assert.AreEqual(trainedModel.Errors.Count, resultModel.Errors.Count);

            for (int i = 0; i < resultModel.TrainingDocuments.Count; i++)
            {
                var tm = trainedModel.TrainingDocuments[i];
                var rm = resultModel.TrainingDocuments[i];

                Assert.AreEqual(tm.DocumentName, rm.DocumentName);
                Assert.AreEqual(tm.PageCount, rm.PageCount);
                Assert.AreEqual(TrainingStatus.Succeeded, rm.Status);
                Assert.AreEqual(tm.Status, rm.Status);
                Assert.AreEqual(tm.Errors.Count, rm.Errors.Count);
            }

            for (int i = 0; i < resultModel.Submodels.Count; i++)
            {
                Assert.AreEqual(trainedModel.Submodels[i].FormType, resultModel.Submodels[i].FormType);

                foreach (var fields in resultModel.Submodels[i].Fields)
                {
                    Assert.AreEqual(trainedModel.Submodels[i].Fields[fields.Key].Name, fields.Value.Name);
                    if (labeled)
                        Assert.AreEqual(trainedModel.Submodels[i].Fields[fields.Key].Accuracy, fields.Value.Accuracy);
                    else
                        Assert.AreEqual(trainedModel.Submodels[i].Fields[fields.Key].Label, fields.Value.Label);
                }
            }

            CustomFormModelInfo modelInfo = client.GetCustomModelsAsync().ToEnumerableAsync().Result.FirstOrDefault();

            Assert.IsNotNull(modelInfo.ModelId);
            Assert.IsNotNull(modelInfo.TrainingStartedOn);
            Assert.IsNotNull(modelInfo.TrainingCompletedOn);
            Assert.IsNotNull(modelInfo.Status);

            AccountProperties accountP = await client.GetAccountPropertiesAsync();

            Assert.IsNotNull(accountP.CustomModelCount);
            Assert.IsNotNull(accountP.CustomModelLimit);

            await client.DeleteModelAsync(trainedModel.ModelId);

            Assert.ThrowsAsync<RequestFailedException>(() => client.GetCustomModelAsync(trainedModel.ModelId));
        }

        [Test]
        public void DeleteModelFailsWhenModelDoesNotExist()
        {
            var client = CreateInstrumentedFormTrainingClient();
            var fakeModelId = "00000000-0000-0000-0000-000000000000";

            Assert.ThrowsAsync<RequestFailedException>(async () => await client.DeleteModelAsync(fakeModelId));
        }

        [Test]
        public async Task CopyModel()
        {
            var sourceClient = CreateInstrumentedFormTrainingClient();
            var targetClient = CreateInstrumentedFormTrainingClient();
            var resourceID = TestEnvironment.TargetResourceId;
            var region = TestEnvironment.TargetResourceRegion;

            await using var trainedModel = await CreateDisposableTrainedModelAsync(useTrainingLabels: true);

            CopyAuthorization targetAuth = await targetClient.GetCopyAuthorizationAsync(resourceID, region);

            CopyModelOperation operation = await sourceClient.StartCopyModelAsync(trainedModel.ModelId, targetAuth);

            await operation.WaitForCompletionAsync(PollingInterval);
            Assert.IsTrue(operation.HasValue);

            CustomFormModelInfo modelCopied = operation.Value;

            Assert.IsNotNull(modelCopied.TrainingCompletedOn);
            Assert.IsNotNull(modelCopied.TrainingStartedOn);
            Assert.AreEqual(targetAuth.ModelId, modelCopied.ModelId);
            Assert.AreNotEqual(trainedModel.ModelId, modelCopied.ModelId);
        }

        [Test]
        [Ignore("Issue: https://github.com/Azure/azure-sdk-for-net/issues/12319")]
        public void CopyModelError()
        {
            var sourceClient = CreateInstrumentedFormTrainingClient();
            var targetClient = CreateInstrumentedFormTrainingClient();
            var resourceID = TestEnvironment.TargetResourceId;
            var region = TestEnvironment.TargetResourceRegion;

            CopyAuthorization targetAuth = CopyAuthorization.FromJson("{\"modelId\":\"328c3b7d - a563 - 4ba2 - 8c2f - 2f26d664486a\",\"accessToken\":\"5b5685e4 - 2f24 - 4423 - ab18 - 000000000000\",\"expirationDateTimeTicks\":1591932653,\"resourceId\":\"resourceId\",\"resourceRegion\":\"westcentralus\"}");

            Assert.ThrowsAsync<RequestFailedException>(async () => await sourceClient.StartCopyModelAsync("00000000-0000-0000-0000-000000000000", targetAuth));
        }

        [Test]
        public async Task StartCopyModelFailsWithWrongRegion()
        {
            var sourceClient = CreateInstrumentedFormTrainingClient();
            var targetClient = CreateInstrumentedFormTrainingClient();
            var resourceID = TestEnvironment.TargetResourceId;
            var wrongRegion = TestEnvironment.TargetResourceRegion == "westcentralus" ? "eastus2" : "westcentralus";

            await using var trainedModel = await CreateDisposableTrainedModelAsync(useTrainingLabels: true);
            CopyAuthorization targetAuth = await targetClient.GetCopyAuthorizationAsync(resourceID, wrongRegion);

            var operation = await sourceClient.StartCopyModelAsync(trainedModel.ModelId, targetAuth);

            Assert.ThrowsAsync<RequestFailedException>(async () => await operation.WaitForCompletionAsync(PollingInterval));
        }

        [Test]
        public async Task GetCopyAuthorization()
        {
            var targetClient = CreateInstrumentedFormTrainingClient();
            var resourceID = TestEnvironment.TargetResourceId;
            var region = TestEnvironment.TargetResourceRegion;

            CopyAuthorization targetAuth = await targetClient.GetCopyAuthorizationAsync(resourceID, region);

            Assert.IsNotNull(targetAuth.ModelId);
            Assert.IsNotNull(targetAuth.AccessToken);
            Assert.IsNotNull(targetAuth.ExpiresOn);
            Assert.AreEqual(resourceID, targetAuth.ResourceId);
            Assert.AreEqual(region, targetAuth.Region);
        }

        [Test]
        public async Task SerializeDeserializeCopyAuthorizationAsync()
        {
            var targetClient = CreateInstrumentedFormTrainingClient();
            var resourceID = TestEnvironment.TargetResourceId;
            var region = TestEnvironment.TargetResourceRegion;

            CopyAuthorization targetAuth = await targetClient.GetCopyAuthorizationAsync(resourceID, region);

            string jsonTargetAuth = targetAuth.ToJson();

            CopyAuthorization targetAuthFromJson = CopyAuthorization.FromJson(jsonTargetAuth);

            Assert.AreEqual(targetAuth.ModelId, targetAuthFromJson.ModelId);
            Assert.AreEqual(targetAuth.ExpiresOn, targetAuthFromJson.ExpiresOn);
            Assert.AreEqual(targetAuth.AccessToken, targetAuthFromJson.AccessToken);
            Assert.AreEqual(targetAuth.ResourceId, targetAuthFromJson.ResourceId);
            Assert.AreEqual(targetAuth.Region, targetAuthFromJson.Region);
        }
    }
}
