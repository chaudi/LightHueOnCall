
using Android.App;
using Android.Content;
using Android.Widget;
using Android.Telephony;

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
    }
}