#region
using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
#endregion

namespace MahlerNo2.Data
{
    #region Meta
    public class ShotMeta
    {
        [JsonProperty] public DateTime At { get; set; }
        [JsonProperty] public string Note { get; set; }
        [JsonProperty] public byte[] Data { get; set; }
    }
    #endregion

    [MetadataType(typeof(ShotMeta))]
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Shot
    {
    }
}