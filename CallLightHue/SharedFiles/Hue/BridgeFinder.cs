using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                    return null;
                }
            }
        }
    }
}
