
using Android.App;
using Android.Content;
using Android.Widget;
using Android.Telephony;
using System.Threading.Tasks;
using SharedFiles.Hue;
using SharedFiles.Hue.Messages;
using System.Collections.Generic;
using SharedFiles.Hue.Messages.Lights;
using System.Diagnostics;

namespace HueOnIncomingCall.PhoneBroadcast
{
    [BroadcastReceiver]
    [IntentFilter(new[] { "android.intent.action.PHONE_STATE" })]
    public class PhoneBroadcastReciever : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Extras != null)
            {
                string state = intent.GetStringExtra(TelephonyManager.ExtraState);
                if (state == TelephonyManager.ExtraStateRinging)
                {
                    string telehpone = intent.GetStringExtra(TelephonyManager.ExtraIncomingNumber);
                    if (!string.IsNullOrEmpty(telehpone))
                    {
                        Toast.MakeText(context, "Incoming call", ToastLength.Short).Show();

                    }
                    else
                    {
                        Toast.MakeText(context, "Incoming call", ToastLength.Short).Show();
                    }
                }
            }
        }

        public async Task TurnOnLights()
        {
            var lastIP = SharedFiles.Helpers.Settings.LastIp;
            var lights = SharedFiles.Helpers.Settings.Lights;
            var r = lights.Split(',');
            var list = new List<Light>();
            foreach (var id in r)
            {
                list.Add(new Light
                {
                    State = new SharedFiles.Hue.Messages.Lights.State
                    {
                        Bri = 255,
                        On = true
                    },
                    Id = int.Parse(id),

                });
            }
            var hcom = new HueCommunicator(lastIP);
            var response = hcom.SetLights(list);
            Debug.WriteLine(response);
        }
    }
}