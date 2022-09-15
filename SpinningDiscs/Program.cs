using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            List<string> kidzBop2Songs = new List<string> { "Firework", "Bye Bye Bye" };

            CD kidsBop = new CD("Kidz Bop 2", "CD", kidzBop2Songs);

            // TODO: Call each CD and DVD method to verify that they work as expected.

            kidsBop.PrintInfo();
            kidsBop.SpinDisc();

            string synopsis = "This movie is about a mouse who is adopted by a human family and the adventures they have along the way.";

            DVD stuartLittle = new DVD("Stuart Little", "DVD", synopsis);

            stuartLittle.PrintInfo();
            stuartLittle.SpinDisc();

            stuartLittle.WriteDisc();
            stuartLittle.ReadDisc();

            kidsBop.WriteDisc();
            kidsBop.ReadDisc();
        }
    }
}
