using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Quartet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name, string ID, int maxSpeed, double zeroTo60, int HP, int CC, int cylinders, int RPM
            CarCard C4 = new CarCard("Corvette Coupe", "C4", 281, 5.2, 344, 5400, 8, 5665);
            CarCard C3 = new CarCard("Porshe 911 Targa", "C3", 285, 5.2, 320, 3596, 6, 6800);
            CarCard E3 = new CarCard("BMW 645 Ci", "E3", 250, 5.6, 333, 4938, 8, 6100);
            CarCard F4 = new CarCard("Fisker Tramanto", "F4", 325, 3.6, 610, 5439, 8, 6100);
            CarCard H4 = new CarCard("BMW M5", "H4", 250, 4.7, 507, 4999, 10, 7750);
            WriteLine(C4.Compare(E3, CarCard.category.cylinders));
            ReadLine();
        }
    }
}
