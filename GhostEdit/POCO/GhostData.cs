using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GhostEdit
{
    public partial class GhostData
    {
        [JsonProperty("posts")]
        public Post[] Posts { get; set; }
    }
}
