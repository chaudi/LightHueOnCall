using HueOnIncomingCall.Hue;
using SharedFiles.Hue;
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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();

		}

        public async Task RegisterPressed()
        {
            var finder = new BridgeFinder();
            var ip = finder.FindBridge();

            if (ip != null)
            {
                var HueCom = new HueCommunicator(ip);
                var response = await HueCom.RegisterApp(new HueOnIncomingCall.Hue.Messages.RegisterUserRequest {DeviceType="Phone" });
                SharedFiles.Helpers.Settings.UserName = response.UserName;
            }
        }

	}
}