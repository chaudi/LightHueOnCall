using SharedFiles.Hue;

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