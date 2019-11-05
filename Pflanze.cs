using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung02
{
    public abstract class Pflanze
    {

        protected String name;
        protected int hoehe;
        protected int bodenart;

        private const int Sand = 1;
        private const int Lehm = 2;
        private const int Humus = 3;

        protected const int Rot = 1;
        protected const int Gelb = 2;
        protected const int Weiss = 3;
        protected const int Orange = 4;
        protected const int Gruen = 5;

        public Pflanze(String name, int hoehe, int bodenart)
        {
            this.name = name;
            this.hoehe = hoehe;
            this.bodenart = bodenart;
        }

        public String _name { get; set; }
        public int _hoehe { get; set; }
        public int _bodenart { get; set; }

        protected abstract int GetFarbe();

        public override bool Equals(object value)
        {
            Pflanze obj = value as Pflanze;
            // Is null?
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }

            // Is the same object?
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            // Is the same type?
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.bodenart == obj.bodenart && this.name.Equals(obj.name) && this.hoehe == obj.hoehe;
        }



        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 23 + this.name.GetHashCode();
            hash = hash * 23 + this.bodenart;
            hash = hash * 23 + this.hoehe;
            return hash;
        }
    }
}