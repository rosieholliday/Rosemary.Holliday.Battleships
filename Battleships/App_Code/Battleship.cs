using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Battleship
/// </summary>
public class Battleship :Ships
{
    public Battleship()
    { }

    public override int Length
    {
        get
        {
            return 5;
        }
    }

    public override string Code
    {
        get
        {
            return "B";
        }
    }
}