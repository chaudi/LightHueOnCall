using System;

namespace SharedFiles.Hue.Messages.Lights
{
    public class State
    {
        public int[] XY = new int[2];

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