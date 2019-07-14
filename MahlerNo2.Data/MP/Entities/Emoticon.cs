#region
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
#endregion

namespace MahlerNo2.Data
{
#region Meta
public partial class EmoticonMeta
{
        [JsonProperty]
    public System.Int32 EmoticonId { get; set; }	
    [JsonProperty]
    public System.Int32 EmoticonCode { get; set; }
}
#endregion

[MetadataType(typeof(EmoticonMeta))]
[JsonObject(MemberSerialization.OptIn)]
public partial class Emoticon
{
        
}
}