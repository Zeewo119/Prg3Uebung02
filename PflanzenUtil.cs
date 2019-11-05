using Prg3Uebung02;
using System;
using System.Collections.Generic;
using System.Linq;

public class PflanzenUtil
{

    public static Pflanze[] SortByHeight(Pflanze[] pflanzen)
    {
        Pflanze[] sortedPflanzen = pflanzen.OrderBy(a => a._hoehe).ToArray();
        return sortedPflanzen;
    }

    public static List<Pflanze> SortByHeight(List<Pflanze> pflanzen)
    {
        IComparer<Pflanze> bodenComparator = (IComparer<Pflanze>) new BodenComparator();
        pflanzen.Sort(bodenComparator);
        return pflanzen;
    }
}
