using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleOOP1
{
    /// <summary>
    /// This class models Circle shape.
    /// </summary>
    public class Circle
    {
        // Define data fields for data you want to storage about the Circle
        private double _radius;

        // Define a Radius to encapsulate access to the _radius data field
        public double Radius
        {
            get { return _radius; }
            set
            {
                // Validate the new value assigned to the Radius
                if (value <= 0)
                {
                    throw new Exception("Radius must be a positive non-zero number.");
                }
                _radius = value;
            }
        }
       
        // Define constructors to assign meaningful values to the data fields
        public Circle()
        {
            _radius = 1;
        }
        public Circle(double newRadius)
        {
            Radius = newRadius;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
