﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Training;
using Moq;
using NUnit.Framework;

namespace Azure.AI.FormRecognizer.Tests
{
    public partial class FormRecognizerSamples
    {
        [Test]
        public async Task RecognizeCustomFormsAsync()
        {
            #region Snippet:FormRecognizerCreateMocks
            var fakeModelId = Guid.NewGuid().ToString();
            var fakeOperationId = $"{fakeModelId}/analyzeResults/{Guid.NewGuid()}";
            var mockClient = new Mock<FormRecognizerClient>();
            var mockOperation = new Mock<RecognizeCustomFormsOperation>(fakeOperationId, mockClient.Object);
            #endregion

            #region Snippet:FormRecognizerSetUpClientMock
            var fakeDocumentUri = new Uri("https://fake.document.uri");

            mockClient.Setup(c => c.StartRecognizeCustomFormsFromUriAsync(fakeModelId, fakeDocumentUri,
                It.IsAny<RecognizeCustomFormsOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(mockOperation.Object));
            #endregion

            #region Snippet:FormRecognizerSetUpOperationMock
            var labelDataBox = FormRecognizerModelFactory.FieldBoundingBox(new List<PointF>()
                { new PointF(1f, 1f), new PointF(2f, 1f), new PointF(2f, 2f), new PointF(1f, 2f) });
            var labelData = FormRecognizerModelFactory.FieldData(labelDataBox, 1, "Total price:", new List<FormElement>());

            var valueDataBox = FormRecognizerModelFactory.FieldBoundingBox(new List<PointF>()
                { new PointF(4f, 1f), new PointF(5f, 1f), new PointF(5f, 2f), new PointF(4f, 2f) });
            var valueData = FormRecognizerModelFactory.FieldData(valueDataBox, 1, "$150.00", new List<FormElement>());

            var fieldValue = FormRecognizerModelFactory.FieldValueWithFloatValueType(150f);

            var formField = FormRecognizerModelFactory.FormField("totalPrice", labelData, valueData, fieldValue, 0.85f);
            var formPage = FormRecognizerModelFactory.FormPage(1, 8.5f, 11f, 0f, LengthUnit.Inch, new List<FormLine>(), new List<FormTable>());

            var pageRange = FormRecognizerModelFactory.FormPageRange(1, 1);
            var recognizedForm = FormRecognizerModelFactory.RecognizedForm("groceries", pageRange,
                new Dictionary<string, FormField>() { { "totalPrice", formField } },
                new List<FormPage>() { formPage });
            var recognizedFormCollection = FormRecognizerModelFactory.RecognizedFormCollection(new List<RecognizedForm>() { recognizedForm });

            Response<RecognizedFormCollection> operationResponse = Response.FromValue(recognizedFormCollection, Mock.Of<Response>());

            mockOperation.Setup(op => op.WaitForCompletionAsync(It.IsAny<CancellationToken>()))
                .Returns(new ValueTask<Response<RecognizedFormCollection>>(operationResponse));
            #endregion

            #region Snippet:FormRecognizerUseMocks
            bool result = await IsExpensiveAsync(fakeModelId, fakeDocumentUri, mockClient.Object);
            Assert.IsTrue(result);
            #endregion
        }

        #region Snippet:FormRecognizerMethodToTest
        private static async Task<bool> IsExpensiveAsync(string modelId, Uri documentUri, FormRecognizerClient client)
        {
            RecognizeCustomFormsOperation operation = await client.StartRecognizeCustomFormsFromUriAsync(modelId, documentUri);

            Response<RecognizedFormCollection> response =  await operation.WaitForCompletionAsync();
            RecognizedForm form = response.Value[0];

            if (form.FormType == "groceries")
            {
                FormField totalPriceField = form.Fields["totalPrice"];
                return totalPriceField.Confidence > 0.5f && totalPriceField.Value.AsFloat() > 100f;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
