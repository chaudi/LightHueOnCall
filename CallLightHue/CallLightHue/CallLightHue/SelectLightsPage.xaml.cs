using HueOnIncomingCall.Hue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallLightHue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectLightsPage : ContentPage
    {
        public SelectLightsPage()
        {
            InitializeComponent();
        }

        private void GetLights()
        {
            var hcom = new HueCommunicator("");
            var response = hcom.GetLights();
        }

        private void SetLights()
        {
            SharedFiles.Helpers.Settings.Lights = "1,2";
        }
    }
}