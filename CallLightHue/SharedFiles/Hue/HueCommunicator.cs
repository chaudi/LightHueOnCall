using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using HueOnIncomingCall.Hue.Messages;
using HueOnIncomingCall.Hue.Messages.Lights;

namespace HueOnIncomingCall.Hue
{
    public class HueCommunicator
    {
        private HttpClient client;
        public string Username { get; set; }

        public HueCommunicator(string ip)
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri(ip)
            };
        }

        public async Task<GetLightsResponse> GetLights()
        {

            var response = await client.GetAsync($"/api/{Username}/lights");
            var responseMessage = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<GetLightsResponse>(await response.Content.ReadAsStringAsync());

            return responseObject;
        }

        public async Task<bool> SetLights(IEnumerable<Light> lights)
        {
            foreach (var light in lights)
            {
                var json = JsonConvert.SerializeObject(lights);
                var content = new StringContent(json);

                var response = await client.PutAsync($"/api/{Username}/lights{light.Id}", content);
                var responseMessage = await response.Content.ReadAsStringAsync();
                if (responseMessage.Contains("error"))
                {
                    return false;
                }
            }
            return true;
        }

        public async Task<RegisterUserResponse> RegisterApp(RegisterUserRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request));
            var response = await client.PostAsync("/api/", content);
            var responseObject = JsonConvert.DeserializeObject<RegisterUserResponse>(await response.Content.ReadAsStringAsync());
            return responseObject;
        }

    }
}