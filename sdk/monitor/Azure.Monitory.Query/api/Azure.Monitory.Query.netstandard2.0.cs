namespace Azure.Monitory.Query
{
    public partial class LogsClient
    {
        protected LogsClient() { }
        public LogsClient(Azure.Core.TokenCredential credential) { }
        public LogsClient(Azure.Core.TokenCredential credential, Azure.Monitory.Query.MonitorQueryClientOptions options) { }
        public virtual Azure.Response<Azure.Monitory.Query.Models.QueryResults> Query(string workspace, string query, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Monitory.Query.Models.QueryResults>> QueryAsync(string workspace, string query, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MetricsClient
    {
        protected MetricsClient() { }
        public MetricsClient(Azure.Core.TokenCredential credential) { }
        public MetricsClient(Azure.Core.TokenCredential credential, Azure.Monitory.Query.MonitorQueryClientOptions options) { }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricNamespace>> GetMetricNamespaces(string resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricNamespace>>> GetMetricNamespacesAsync(string resource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricDefinition>> GetMetrics(string resource, string metricsNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricDefinition>>> GetMetricsAsync(string resource, string metricsNamespace, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Monitory.Query.Models.MetricQueryResult> Query(string resource, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.TimeSpan interval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Monitory.Query.Models.MetricQueryResult>> QueryAsync(string resource, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.TimeSpan interval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MonitorQueryClientOptions : Azure.Core.ClientOptions
    {
        public MonitorQueryClientOptions(Azure.Monitory.Query.MonitorQueryClientOptions.ServiceVersion version = Azure.Monitory.Query.MonitorQueryClientOptions.ServiceVersion.V1) { }
        public enum ServiceVersion
        {
            V1 = 0,
        }
    }
}
namespace Azure.Monitory.Query.Models
{
    public enum AggregationType
    {
        None = 0,
        Average = 1,
        Count = 2,
        Minimum = 3,
        Maximum = 4,
        Total = 5,
    }
    public partial class BatchRequest
    {
        public BatchRequest() { }
        public System.Collections.Generic.IList<Azure.Monitory.Query.Models.LogQueryRequest> Requests { get { throw null; } }
    }
    public partial class BatchResponse
    {
        internal BatchResponse() { }
        public Azure.Monitory.Query.Models.BatchResponseError Error { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.LogQueryResponse> Responses { get { throw null; } }
    }
    public partial class BatchResponseError
    {
        internal BatchResponseError() { }
        public string Code { get { throw null; } }
        public Azure.Monitory.Query.Models.BatchResponseErrorInnerError InnerError { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class BatchResponseErrorInnerError
    {
        internal BatchResponseErrorInnerError() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.ErrorDetails> Details { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class ErrorDetails
    {
        internal ErrorDetails() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public partial class LocalizableString
    {
        internal LocalizableString() { }
        public string LocalizedValue { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class LogQueryRequest
    {
        public LogQueryRequest() { }
        public Azure.Monitory.Query.Models.QueryBody Body { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string Workspace { get { throw null; } set { } }
    }
    public partial class LogQueryResponse
    {
        internal LogQueryResponse() { }
        public Azure.Monitory.Query.Models.QueryResults Body { get { throw null; } }
        public string Id { get { throw null; } }
        public int? Status { get { throw null; } }
    }
    public partial class MetadataValue
    {
        internal MetadataValue() { }
        public Azure.Monitory.Query.Models.LocalizableString Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class Metric
    {
        internal Metric() { }
        public string Id { get { throw null; } }
        public Azure.Monitory.Query.Models.LocalizableString Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.TimeSeriesElement> Timeseries { get { throw null; } }
        public string Type { get { throw null; } }
        public Azure.Monitory.Query.Models.MetricUnit Unit { get { throw null; } }
    }
    public partial class MetricAvailability
    {
        internal MetricAvailability() { }
        public System.TimeSpan? Retention { get { throw null; } }
        public System.TimeSpan? TimeGrain { get { throw null; } }
    }
    public partial class MetricDefinition
    {
        internal MetricDefinition() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.LocalizableString> Dimensions { get { throw null; } }
        public string Id { get { throw null; } }
        public bool? IsDimensionRequired { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricAvailability> MetricAvailabilities { get { throw null; } }
        public Azure.Monitory.Query.Models.LocalizableString Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public Azure.Monitory.Query.Models.AggregationType? PrimaryAggregationType { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.AggregationType> SupportedAggregationTypes { get { throw null; } }
        public Azure.Monitory.Query.Models.MetricUnit? Unit { get { throw null; } }
    }
    public partial class MetricNamespace
    {
        internal MetricNamespace() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.Monitory.Query.Models.MetricNamespaceName Properties { get { throw null; } }
        public string Type { get { throw null; } }
    }
    public partial class MetricNamespaceName
    {
        internal MetricNamespaceName() { }
        public string MetricNamespaceNameValue { get { throw null; } }
    }
    public partial class MetricQueryResult
    {
        internal MetricQueryResult() { }
        public int? Cost { get { throw null; } }
        public System.TimeSpan? Interval { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.Metric> Metrics { get { throw null; } }
        public string Namespace { get { throw null; } }
        public string Resourceregion { get { throw null; } }
        public string Timespan { get { throw null; } }
    }
    public enum MetricUnit
    {
        Count = 0,
        Bytes = 1,
        Seconds = 2,
        CountPerSecond = 3,
        BytesPerSecond = 4,
        Percent = 5,
        MilliSeconds = 6,
        ByteSeconds = 7,
        Unspecified = 8,
        Cores = 9,
        MilliCores = 10,
        NanoCores = 11,
        BitsPerSecond = 12,
    }
    public partial class MetricValue
    {
        internal MetricValue() { }
        public double? Average { get { throw null; } }
        public double? Count { get { throw null; } }
        public double? Maximum { get { throw null; } }
        public double? Minimum { get { throw null; } }
        public System.DateTimeOffset TimeStamp { get { throw null; } }
        public double? Total { get { throw null; } }
    }
    public partial class QueryBody
    {
        public QueryBody(string query) { }
        public string Query { get { throw null; } }
        public string Timespan { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Workspaces { get { throw null; } }
    }
    public partial class QueryResultColumn
    {
        internal QueryResultColumn() { }
        public string Name { get { throw null; } }
        public string Type { get { throw null; } }
    }
    public partial class QueryResults
    {
        internal QueryResults() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.QueryResultTable> Tables { get { throw null; } }
    }
    public partial class QueryResultTable
    {
        internal QueryResultTable() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.QueryResultColumn> Columns { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IList<string>> Rows { get { throw null; } }
    }
    public enum ResultType
    {
        Data = 0,
        Metadata = 1,
    }
    public partial class TimeSeriesElement
    {
        internal TimeSeriesElement() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetricValue> Data { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Monitory.Query.Models.MetadataValue> Metadatavalues { get { throw null; } }
    }
}
