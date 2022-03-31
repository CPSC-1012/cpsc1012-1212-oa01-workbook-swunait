using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExercise
{
    public class Die
    {
        // Declare data fields for storing data
        private int _sides; // number of sides for the Die
        private int _value; // face value of the Die

        // Define properties to encapsulate access to the data fields
        public int Sides
        {
            get { return _sides; }  // A read-only property contains only an accessor (get) and not mutator (set)
        }
        public int Value
        {
            get { return _value; }
        }

        // Define constructors to assign meaningful values to the fields/properties
        //public Die()
        //{
        //    _sides = 6;
        //}
        public Die(int numSides)
        {
            _sides = numSides;
            Roll();
        }

        public void Roll()
        {
            Random rand = new Random();
            _value = rand.Next(1, Sides + 1);
        }
    }
}
