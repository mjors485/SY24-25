using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name, int maxSpeed, double zeroTo60, int hP, int cC, int cylinders, int rPM
            CarCard C4 = new CarCard("Corvette Coupe", 281, 5.2, 344, 5400, 8, 5665);
            CarCard C3 = new CarCard("Porshe 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
            CarCard E3 = new CarCard("BMW 645 Ci", 250, 5.6, 333, 4938, 8, 6100);
            CarCard F4 = new CarCard("Fisker Tramanto", 325, 3.6, 610, 5439, 8, 6100);
            CarCard H4 = new CarCard("BMW M5", 250, 4.7, 507, 4999, 10, 7750);
        }
    }
}
