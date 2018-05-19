using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18___Making_Your_Own_Classes
{
    internal class Color
    {
        // Variables for the colors (using byte for the range of 0 - 255;
        private byte red, blue, green, alpha;


        // Constructors. 
        public Color(byte red, byte blue, byte green, byte alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public Color(byte red, byte blue, byte green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 255;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public void SetRed(byte red)
        {
            this.red = red;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public byte GetGreyScale()
        {
            return (byte)((red + blue + green) / 3);

        }


    }
}
