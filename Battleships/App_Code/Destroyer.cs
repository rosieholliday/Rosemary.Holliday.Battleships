using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Destroyer
/// </summary>
public class Destroyer : Ships
{
    public Destroyer()
    { }

    public override int Length
    {
        get
        {
            return 4;
        }
    }

    public override string Code
    {
        get
        {
            return "D";
        }
    }
}
