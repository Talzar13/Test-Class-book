using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18___Making_Your_Own_Classes
{
    internal class Ball
    {
        // Instance variables
        private float size;
        private Color color;
        private int thrown;

        // Constructors.
        public Ball(float size, Color color)
        {
            this.size = size;
            this.color = color;
            this.thrown = 0;
        }

        // Methods.
        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                thrown++;
            }
        }

        public int TotalTimesThrown()
        {
            return thrown;
        }

        public float GetSize()
        {
            return size;
        }
    }
}
