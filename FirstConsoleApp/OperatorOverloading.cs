using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Box
    {
        public double Length { get; set; } // Length of a box
        public double Breadth { get; set; } // Breadth of a box
        public double Height { get; set; } // Height of a box

        public double getVolume()
        {
            return Length * Breadth * Height;
        }

        public static bool operator >(Box b1, Box b2)
        {
            if (b1.getVolume() > b2.getVolume())
                return true;
            return false;
        }

        public static bool operator <(Box b1, Box b2)
        {
            if (b1.getVolume() < b2.getVolume())
                return true;
            return false;
        }

        // TODO: Provide toString implementation which returns H x L x B in the given format

        // TODO: Provide implementation == and != operators

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.Length = b.Length + c.Length;
            box.Breadth = b.Breadth + c.Breadth;
            box.Height = b.Height + c.Height;
            return box;
        }
    }
}
