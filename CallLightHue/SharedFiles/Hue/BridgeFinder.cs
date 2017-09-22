using System;
using System.Diagnostics;
using System.Net.Http;

namespace SharedFiles.Hue
{
    public class BridgeFinder
    {
        public string FindBridge()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = client.GetStreamAsync("www.meethue.com/api/nupnp");

                    return string.Empty;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return null;
                }
            }
        }
    }
}
