using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class CarCard
    {
        public string name {  get; set; }
        public int maxSpeed {  get; set; }
        public double zeroTo60 { get; set; }
        public int HP { get; set; }
        public int CC { get; set; }
        public int cylinders { get; set; }
        public int RPM { get; set; }
        public CarCard(string name, int maxSpeed, double zeroTo60, int hP, int cC, int cylinders, int rPM)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.zeroTo60 = zeroTo60;
            this.HP = HP;
            this.CC = CC;
            this.cylinders = cylinders;
            this.RPM = RPM;
        }
    }
}
