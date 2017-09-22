using System.Collections.Generic;

namespace HueOnIncomingCall.Hue.Messages.Lights
{
    public class GetLightsResponse
    {
        public IEnumerable<Light> Lights { get; set; }
    }
}