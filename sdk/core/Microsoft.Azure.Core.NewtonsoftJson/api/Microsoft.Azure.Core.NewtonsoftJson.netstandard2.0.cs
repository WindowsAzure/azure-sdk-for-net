namespace Azure.Core
{
    public partial class NewtonsoftJsonObjectSerializer : Azure.Core.ObjectSerializer, Azure.Core.ISerializedNameProvider
    {
        public NewtonsoftJsonObjectSerializer() { }
        public NewtonsoftJsonObjectSerializer(Newtonsoft.Json.JsonSerializerSettings settings) { }
        string? Azure.Core.ISerializedNameProvider.GetSerializedName(System.Reflection.MemberInfo memberInfo) { throw null; }
        public override object Deserialize(System.IO.Stream stream, System.Type returnType, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<object> DeserializeAsync(System.IO.Stream stream, System.Type returnType, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Serialize(System.IO.Stream stream, object? value, System.Type inputType, System.Threading.CancellationToken cancellationToken) { }
        public override System.Threading.Tasks.ValueTask SerializeAsync(System.IO.Stream stream, object? value, System.Type inputType, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
