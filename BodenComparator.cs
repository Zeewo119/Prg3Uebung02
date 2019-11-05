using Prg3Uebung02;
using System;
using System.Collections;

public class BodenComparator:IComparer
{

    public int Compare(Pflanze pflanze1, Pflanze pflanze2)
    {
        if (pflanze1._bodenart > pflanze2._bodenart)
        {
            return 1;
        }
        else if (pflanze1._bodenart < pflanze2._bodenart)
        {
            return -1;
        }
        else return 0;
    }

    public int Compare(object x, object y)
    {
        throw new NotImplementedException();
    }
}
