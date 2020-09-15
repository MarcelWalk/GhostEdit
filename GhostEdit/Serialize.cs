using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GhostEdit
{
    public static class Serialize
    {
        public static string ToJson(this GhostData self) => JsonConvert.SerializeObject(self);
    }
}
