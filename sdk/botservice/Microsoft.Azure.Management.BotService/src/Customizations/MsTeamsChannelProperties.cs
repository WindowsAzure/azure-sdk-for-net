namespace Microsoft.Azure.Management.BotService.Models
{
    using System.Collections.Generic;
    public partial class KikChannelProperties
    {
        public KikChannelProperties(string userName, string apiKey, bool isEnabled, bool? isValidated = default(bool?)) :
          this(userName, isEnabled, apiKey: apiKey, isValidated: isValidated) {}
    }
}
