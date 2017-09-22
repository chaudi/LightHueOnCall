using System;

namespace HueOnIncomingCall.Hue.Messages
{
    public class RegisterUserRequest
    {
        private const int MaxDeviceTypeLength = 40;
        public string DeviceType
        {
            get { return DeviceType; }
            set
            {
                if (value.Length <= 40)
                {
                    DeviceType = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}