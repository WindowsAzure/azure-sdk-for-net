// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity tabular translator. </summary>
    public partial class TabularTranslator : CopyTranslator
    {

        /// <summary> Column mappings. Example: &quot;UserId: MyUserId, Group: MyGroup, Name: MyName&quot; Type: string (or Expression with resultType string). This property will be retired. Please use mappings property. </summary>
        public object ColumnMappings { get; }
        /// <summary> The schema mapping to map between tabular data and hierarchical data. Example: {&quot;Column1&quot;: &quot;$.Column1&quot;, &quot;Column2&quot;: &quot;$.Column2.Property1&quot;, &quot;Column3&quot;: &quot;$.Column2.Property2&quot;}. Type: object (or Expression with resultType object). This property will be retired. Please use mappings property. </summary>
        public object SchemaMapping { get; }
        /// <summary> The JSON Path of the Nested Array that is going to do cross-apply. Type: object (or Expression with resultType object). </summary>
        public object CollectionReference { get; }
        /// <summary> Whether to map complex (array and object) values to simple strings in json format. Type: boolean (or Expression with resultType boolean). </summary>
        public object MapComplexValuesToString { get; }
        /// <summary> Column mappings with logical types. Tabular-&gt;tabular example: [{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}].  Hierarchical-&gt;tabular example: [{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}]. Type: object (or Expression with resultType object). </summary>
        public object Mappings { get; }
    }
}
