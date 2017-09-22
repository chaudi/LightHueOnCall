using Android.Content;
using Android.Telephony;

namespace HueOnIncomingCall.CallStuff
{
    public class CallInterceptor : PhoneStateListener
    {

        Context context;

        public CallInterceptor(Context context_)
        {
            this.context = context_;
        }

        public override void OnCallStateChanged(CallState state, string incomingNumber)
        {
            if (state == CallState.Ringing)
            {
                
                base.OnCallStateChanged(state, incomingNumber);
            }
        }
    }
}