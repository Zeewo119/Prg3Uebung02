using Prg3Uebung02;
using System;

public class Strauch: Pflanze
{

        private int farbe;
    Strauch(String name, int hoehe, int bodenart) : base(name, hoehe, bodenart)
    {
        this.farbe = Gruen;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() * 23 + this.GetFarbe();
    }

    public override bool Equals(object value)
    {
        Strauch obj = value as Strauch;
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

        return this.bodenart == obj._bodenart && this.name.Equals(obj._name) && this.hoehe == obj._hoehe && this.GetFarbe() == obj.GetFarbe();
    }

    protected override int GetFarbe()
    {
        return this.farbe;
    }
}
