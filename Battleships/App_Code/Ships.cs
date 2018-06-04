using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ships
/// </summary>
public class Ships
{
    Board b = new Board();
    public Ships()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public virtual int Length
    {
        get { return 0; }
    } 

    public virtual string Code
    {
        get { return "0"; }
    }

    public bool isSunk(string sShip)
    {       
        int iOccurences = 0;
        if (sShip == "DH")
        {
            iOccurences = 0;
            for (int i = 0; i < b.GetCells.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetCells.GetLength(1); j++)
                {
                    if (b.GetCells[i, j].ToString() == "DH")
                    {
                        iOccurences++;
                    }
                }
            }
            if (iOccurences == 4)
            {
                return true;
            }
        }
        else if ((sShip =="EH"))
        {
            iOccurences = 0;
            for (int i = 0; i < b.GetCells.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetCells.GetLength(1); j++)
                {
                    if (b.GetCells[i, j].ToString() == "EH")
                    {
                        iOccurences++;
                    }
                }
            }
            if (iOccurences == 4)
            {
                return true;
            }
        }
        else if (sShip=="BH")
        {
            iOccurences = 0;
            for (int i = 0; i < b.GetCells.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetCells.GetLength(1); j++)
                {
                    if (b.GetCells[i, j].ToString() == "BH")
                    {
                        iOccurences++;
                    }
                }
            }
            if (iOccurences == 5)
            {
                return true;
            }
        }
        return false;
    }
}