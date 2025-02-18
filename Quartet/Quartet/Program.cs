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
            CarCard A3 = new CarCard("Ferrari F430 F1", "A3", 315, 4.0, 490, 4308, 8, 8500);
            CarCard G4 = new CarCard("Porsche Cayman S", "G4", 275, 5.4, 295, 3387, 6, 6250);
            CarCard G1 = new CarCard("Marcos Mantara", "G1", 225, 5.4, 190, 3998, 8, 4750);
            CarCard D3 = new CarCard("Nissan 350 Z", "D3", 250, 5.9, 3498, 6, 280, 6300);
            CarCard E1 = new CarCard("Aston Martin V8 Vantage", "E1", 280, 5.0, 4282, 8, 385, 7000);
            CarCard E4 = new CarCard("Bentley Azure", "E4", 241, 6.7, 6750, 8, 388, 4000);
            CarCard B2 = new CarCard("TVR Sagaris", "B2", 300, 3.9, 3966, 8, 400, 7000);
            CarCard B3 = new CarCard("Range Rover Sport", "B3", 225, 7.6, 4197, 8, 390, 5750);
            CarCard E2 = new CarCard("Ferrari F50", "E2", 325, 3.9, 521, 4700, 12, 8500);
            CarCard A4 = new CarCard("Viper GTS", "A4", 285, 4.6, 411, 7990, 10, 5100);
            CarCard A1 = new CarCard("BMW Z8", "A1", 250, 4.7, 400, 4941, 8, 6600);
            CarCard D1 = new CarCard("Mitsubishi Lancer RS", "D1", 220, 5.9, 300, 1997, 4, 6200);
            CarCard C2 = new CarCard("Toyota Celica", "C2", 205, 8.7, 6400, 4, 143, 1794);
            CarCard D2 = new CarCard("AudiRs 6 Plus", "D2", 280, 4.6, 480, 4172, 8, 6400);
            CarCard F1 = new CarCard("Opel Astra Coupe 2.0", "F1", 245, 7.5, 192, 1988, 4, 5400);

            //WriteLine(C4.Compare(E3, CarCard.category.cylinders));
            List<CarCard> list = new List<CarCard>();
            list.Add(C4);
            list.Add(C3);
            list.Add(E3);
            list.Add(F4);
            list.Add(H4);
            list.Add(A3);
            list.Add(G4);
            list.Add(G1);
            list.Add(D3);
            list.Add(E1);
            list.Add(E4);
            list.Add(B2);
            list.Add(B3);
            list.Add(E2);
            list.Add(A4);
            list.Add(A1);
            list.Add(D1);
            list.Add(C2);
            list.Add(D2);
            list.Add(F1);
            Deck d = new Deck(list);
            ReadLine();
        }
    }
}
