#region
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
#endregion

namespace MahlerNo2.Data
{
#region Meta
public partial class BreakTimeMeta
{
        [JsonProperty]
    public System.Int32 No { get; set; }	
    [JsonProperty]
    public System.DateTime At { get; set; }
}
#endregion

[MetadataType(typeof(BreakTimeMeta))]
[JsonObject(MemberSerialization.OptIn)]
public partial class BreakTime
{
        
}
}