using System;

namespace HueOnIncomingCall.Hue.Messages.Lights
{
    public class State
    {
        public Tuple<float, float> XY
        {
            get; set;
        }

        public bool On { get; set; }

        public int Bri
        {
            get { return Bri; }
            set
            {
                if (value >= 1 && value <= 254)
                {
                    Bri = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}