using System;
using System.Collections.Generic;
using System.Text;

namespace Prg3Uebung02
{
    class Blume: Pflanze
    {

        private int farbe;
        Blume(String name, int hoehe, int bodenart,int farbe): base(name, hoehe, bodenart)
        {
            if (farbe == Gruen)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.farbe = farbe;
        }

        protected override int GetFarbe()
        {
            return this.farbe;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 23 + this.GetFarbe();
        }

        public override bool Equals(object value)
        {
            Blume obj = value as Blume;
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

            return this.bodenart == obj.bodenart && this.name.Equals(obj.name) && this.hoehe == obj.hoehe && this.GetFarbe() == obj.GetFarbe();
        }
    }
}
