// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class BlobPropertiesInternal
    {
        internal static BlobPropertiesInternal DeserializeBlobPropertiesInternal(XElement element)
        {
            DateTimeOffset? creationTime = default;
            DateTimeOffset lastModified = default;
            string etag = default;
            long? contentLength = default;
            string contentType = default;
            string contentEncoding = default;
            string contentLanguage = default;
            byte[] contentMD5 = default;
            string contentDisposition = default;
            string cacheControl = default;
            long? blobSequenceNumber = default;
            BlobType? blobType = default;
            LeaseStatus? leaseStatus = default;
            LeaseState? leaseState = default;
            LeaseDurationType? leaseDuration = default;
            string copyId = default;
            CopyStatus? copyStatus = default;
            string copySource = default;
            string copyProgress = default;
            DateTimeOffset? copyCompletionTime = default;
            string copyStatusDescription = default;
            bool? serverEncrypted = default;
            bool? incrementalCopy = default;
            string destinationSnapshot = default;
            DateTimeOffset? deletedTime = default;
            int? remainingRetentionDays = default;
            AccessTier? accessTier = default;
            bool? accessTierInferred = default;
            ArchiveStatus? archiveStatus = default;
            string customerProvidedKeySha256 = default;
            string encryptionScope = default;
            DateTimeOffset? accessTierChangeTime = default;
            int? tagCount = default;
            DateTimeOffset? expiresOn = default;
            bool? isSealed = default;
            RehydratePriority? rehydratePriority = default;
            DateTimeOffset? lastAccessedOn = default;
            if (element.Element("Creation-Time") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            if (element.Element("Content-Length") is XElement contentLengthElement)
            {
                contentLength = (long?)contentLengthElement;
            }
            if (element.Element("Content-Type") is XElement contentTypeElement)
            {
                contentType = (string)contentTypeElement;
            }
            if (element.Element("Content-Encoding") is XElement contentEncodingElement)
            {
                contentEncoding = (string)contentEncodingElement;
            }
            if (element.Element("Content-Language") is XElement contentLanguageElement)
            {
                contentLanguage = (string)contentLanguageElement;
            }
            if (element.Element("Content-MD5") is XElement contentMD5Element)
            {
                contentMD5 = contentMD5Element.GetBytesFromBase64Value("D");
            }
            if (element.Element("Content-Disposition") is XElement contentDispositionElement)
            {
                contentDisposition = (string)contentDispositionElement;
            }
            if (element.Element("Cache-Control") is XElement cacheControlElement)
            {
                cacheControl = (string)cacheControlElement;
            }
            if (element.Element("x-ms-blob-sequence-number") is XElement xMsBlobSequenceNumberElement)
            {
                blobSequenceNumber = (long?)xMsBlobSequenceNumberElement;
            }
            if (element.Element("BlobType") is XElement blobTypeElement)
            {
                blobType = blobTypeElement.Value.ToBlobType();
            }
            if (element.Element("LeaseStatus") is XElement leaseStatusElement)
            {
                leaseStatus = leaseStatusElement.Value.ToLeaseStatus();
            }
            if (element.Element("LeaseState") is XElement leaseStateElement)
            {
                leaseState = leaseStateElement.Value.ToLeaseState();
            }
            if (element.Element("LeaseDuration") is XElement leaseDurationElement)
            {
                leaseDuration = leaseDurationElement.Value.ToLeaseDurationType();
            }
            if (element.Element("CopyId") is XElement copyIdElement)
            {
                copyId = (string)copyIdElement;
            }
            if (element.Element("CopyStatus") is XElement copyStatusElement)
            {
                copyStatus = copyStatusElement.Value.ToCopyStatus();
            }
            if (element.Element("CopySource") is XElement copySourceElement)
            {
                copySource = (string)copySourceElement;
            }
            if (element.Element("CopyProgress") is XElement copyProgressElement)
            {
                copyProgress = (string)copyProgressElement;
            }
            if (element.Element("CopyCompletionTime") is XElement copyCompletionTimeElement)
            {
                copyCompletionTime = copyCompletionTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("CopyStatusDescription") is XElement copyStatusDescriptionElement)
            {
                copyStatusDescription = (string)copyStatusDescriptionElement;
            }
            if (element.Element("ServerEncrypted") is XElement serverEncryptedElement)
            {
                serverEncrypted = (bool?)serverEncryptedElement;
            }
            if (element.Element("IncrementalCopy") is XElement incrementalCopyElement)
            {
                incrementalCopy = (bool?)incrementalCopyElement;
            }
            if (element.Element("DestinationSnapshot") is XElement destinationSnapshotElement)
            {
                destinationSnapshot = (string)destinationSnapshotElement;
            }
            if (element.Element("DeletedTime") is XElement deletedTimeElement)
            {
                deletedTime = deletedTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("RemainingRetentionDays") is XElement remainingRetentionDaysElement)
            {
                remainingRetentionDays = (int?)remainingRetentionDaysElement;
            }
            if (element.Element("AccessTier") is XElement accessTierElement)
            {
                accessTier = new AccessTier(accessTierElement.Value);
            }
            if (element.Element("AccessTierInferred") is XElement accessTierInferredElement)
            {
                accessTierInferred = (bool?)accessTierInferredElement;
            }
            if (element.Element("ArchiveStatus") is XElement archiveStatusElement)
            {
                archiveStatus = new ArchiveStatus(archiveStatusElement.Value);
            }
            if (element.Element("CustomerProvidedKeySha256") is XElement customerProvidedKeySha256Element)
            {
                customerProvidedKeySha256 = (string)customerProvidedKeySha256Element;
            }
            if (element.Element("EncryptionScope") is XElement encryptionScopeElement)
            {
                encryptionScope = (string)encryptionScopeElement;
            }
            if (element.Element("AccessTierChangeTime") is XElement accessTierChangeTimeElement)
            {
                accessTierChangeTime = accessTierChangeTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("TagCount") is XElement tagCountElement)
            {
                tagCount = (int?)tagCountElement;
            }
            if (element.Element("Expiry-Time") is XElement expiryTimeElement)
            {
                expiresOn = expiryTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Sealed") is XElement sealedElement)
            {
                isSealed = (bool?)sealedElement;
            }
            if (element.Element("RehydratePriority") is XElement rehydratePriorityElement)
            {
                rehydratePriority = new RehydratePriority(rehydratePriorityElement.Value);
            }
            if (element.Element("LastAccessTime") is XElement lastAccessTimeElement)
            {
                lastAccessedOn = lastAccessTimeElement.GetDateTimeOffsetValue("R");
            }
            return new BlobPropertiesInternal(creationTime, lastModified, etag, contentLength, contentType, contentEncoding, contentLanguage, contentMD5, contentDisposition, cacheControl, blobSequenceNumber, blobType, leaseStatus, leaseState, leaseDuration, copyId, copyStatus, copySource, copyProgress, copyCompletionTime, copyStatusDescription, serverEncrypted, incrementalCopy, destinationSnapshot, deletedTime, remainingRetentionDays, accessTier, accessTierInferred, archiveStatus, customerProvidedKeySha256, encryptionScope, accessTierChangeTime, tagCount, expiresOn, isSealed, rehydratePriority, lastAccessedOn);
        }
    }
}
