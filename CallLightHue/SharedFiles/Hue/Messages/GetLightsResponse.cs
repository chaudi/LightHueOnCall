using System.Collections.Generic;

namespace SharedFiles.Hue.Messages.Lights
{
    public class GetLightsResponse
    {
        public IEnumerable<Light> Lights { get; set; }
    }
}