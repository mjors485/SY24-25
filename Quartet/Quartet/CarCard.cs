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
        public enum category { ID, maxSpeed, zeroTo60, HP, CC, cylinders, RPM }
        public string name {  get; set; }
        public string ID { get; set; }
        public int maxSpeed {  get; set; }
        public double zeroTo60 { get; set; }
        public int HP { get; set; }
        public int CC { get; set; }
        public int cylinders { get; set; }
        public int RPM { get; set; }
        
        public CarCard(string name, string ID, int maxSpeed, double zeroTo60, int HP, int CC, int cylinders, int RPM)
        {
            this.name = name;
            this.ID = ID;
            this.maxSpeed = maxSpeed;
            this.zeroTo60 = zeroTo60;
            this.HP = HP;
            this.CC = CC;
            this.cylinders = cylinders;
            this.RPM = RPM;
        }

        public CarCard Compare(CarCard other, category c) 
        {
            if (other == null) return this;

            if (c == category.maxSpeed) 
                if (maxSpeed > other.maxSpeed)
                    return this;
                else
                    return other;

            if (c == category.zeroTo60)
                if (zeroTo60 < other.zeroTo60)
                    return this;
                else
                    return other;

            if (c == category.HP)
                if (HP > other.HP)
                    return this;
                else
                    return other;

            if (c == category.CC)
                if (CC > other.CC)
                    return this;
                else
                    return other;

            if (c == category.cylinders)
                if (cylinders > other.cylinders)
                    return this;
                else
                    return other;

            if (c == category.RPM)
                if (RPM > other.RPM)
                    return this;
                else
                    return other;

            return null;
        }

        public override string ToString()
        {
            return name + ":\n\tname:" + name
                + "\n\tID:" + ID
                + "\n\tmaxspeed:" + maxSpeed
                + "\n\tzeroTo60:" + zeroTo60
                + "\n\tHP:" + HP
                + "\n\tCC:" + CC
                + "\n\tcylinders:" + cylinders
                + "\n\tRPM:" + RPM;
        }
    }
}
