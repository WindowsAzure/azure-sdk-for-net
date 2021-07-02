// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary>
    /// <see cref="MetricFeedback"/> instances are used to describe feedback on unsatisfactory anomaly detection results.
    /// When feedback is created for a given metric, it is applied to future anomaly detection processing of the same series.
    /// The processed points will not be re-calculated. The supported feedback classes are:
    /// <list type="bullet">
    ///   <item><see cref="MetricAnomalyFeedback"/></item>
    ///   <item><see cref="MetricChangePointFeedback"/></item>
    ///   <item><see cref="MetricCommentFeedback"/></item>
    ///   <item><see cref="MetricPeriodFeedback"/></item>
    /// </list>
    /// </summary>
    [CodeGenModel("MetricFeedback")]
    [CodeGenSuppress(nameof(MetricFeedback), typeof(string), typeof(FeedbackDimensionFilter))]
    public abstract partial class MetricFeedback : IUtf8JsonSerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricFeedback"/> class.
        /// </summary>
        /// <param name="metricId">The identifier of the metric to which the <see cref="MetricFeedback"/> applies.</param>
        /// <param name="dimensionKey">
        /// A key that identifies a set of time series to which the <see cref="MetricFeedback"/> applies.
        /// If all possible dimensions are set, this key uniquely identifies a single time series
        /// for the specified <paramref name="metricId"/>. If only a subset of dimensions are set, this
        /// key uniquely identifies a group of time series.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="metricId"/> or <paramref name="dimensionKey"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="metricId"/> is empty.</exception>
        internal MetricFeedback(string metricId, DimensionKey dimensionKey)
        {
            Argument.AssertNotNullOrEmpty(metricId, nameof(metricId));
            Argument.AssertNotNull(dimensionKey, nameof(dimensionKey));

            MetricId = metricId;
            DimensionKey = dimensionKey;
        }

        internal MetricFeedback(MetricFeedbackKind kind, string id, DateTimeOffset? createdOn, string userPrincipal, string metricId, FeedbackDimensionFilter dimensionFilter)
        {
            Kind = kind;
            Id = id;
            CreatedOn = createdOn;
            UserPrincipal = userPrincipal;
            MetricId = metricId;
            DimensionKey = dimensionFilter.DimensionKey;
        }

        /// <summary>
        /// The feedback kind.
        /// </summary>
        [CodeGenMember("FeedbackType")]
        public MetricFeedbackKind Kind { get; internal set; }

        /// <summary>
        /// The unique identifier of the <see cref="MetricFeedback"/>. Set by the service.
        /// </summary>
        [CodeGenMember("FeedbackId")]
        public string Id { get; }

        /// <summary>
        /// Date and time, in UTC, when the <see cref="MetricFeedback"/> was created.
        /// </summary>
        [CodeGenMember("CreatedTime")]
        public DateTimeOffset? CreatedOn { get; }

        /// <summary>
        /// The user who created the <see cref="MetricFeedback"/>. If <see cref="MetricsAdvisorKeyCredential"/>
        /// authentication was used when creating the feedback, this property contains the email address of the
        /// creator. If AAD authentication was used instead, the value of this property uniquely identifies the
        /// creator's user principal, but its value depends on the type of credential used. For instance, if a
        /// <c>ClientSecretCredential</c> is used, it will contain the client ID.
        /// </summary>
        public string UserPrincipal { get; }

        /// <summary>
        /// The identifier of the metric to which the <see cref="MetricFeedback"/> applies.
        /// </summary>
        public string MetricId { get; }

        /// <summary>
        /// A key that identifies a set of time series to which the <see cref="MetricFeedback"/> applies.
        /// If all possible dimensions are set, this key uniquely identifies a single time series
        /// for the specified <see cref="MetricId"/>. If only a subset of dimensions are set, this
        /// key uniquely identifies a group of time series.
        /// </summary>
        public DimensionKey DimensionKey { get; }

        /// <summary>
        /// Used by CodeGen during serialization.
        /// </summary>
        internal FeedbackDimensionFilter DimensionFilter => new FeedbackDimensionFilter(DimensionKey.Dimension);

        internal static MetricFeedback DeserializeMetricFeedback(JsonElement element)
        {
            if (element.TryGetProperty("feedbackType", out JsonElement discriminator))
            {
                var discriminatorString = discriminator.GetString();

                switch (discriminatorString)
                {
                    case "Anomaly":
                        return MetricAnomalyFeedback.DeserializeMetricAnomalyFeedback(element);
                    case "ChangePoint":
                        return MetricChangePointFeedback.DeserializeMetricChangePointFeedback(element);
                    case "Comment":
                        return MetricCommentFeedback.DeserializeMetricCommentFeedback(element);
                    case "Period":
                        return MetricPeriodFeedback.DeserializeMetricPeriodFeedback(element);
                    default:
                        throw new ArgumentException($"Unknown feedback type returned by the service: {discriminatorString}");
                }
            }
            else
            {
                throw new ArgumentException("The feedback type was not returned by the service");
            }
        }
    }
}
