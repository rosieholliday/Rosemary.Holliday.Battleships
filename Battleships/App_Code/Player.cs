using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Player
/// </summary>
public class Player
{
    Board b = new Board();
    Ships s = new Ships();
    public Player()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static int shipsHit = 0;

    public bool validateText(string input)
    {        
        if(input!=null&&input.Length==2)
        {
            if ("ABCDEFGHIJ".Contains(input[0].ToString().ToUpper()))
            {
                if ("1234567890".Contains(input[1].ToString()))
                {
                    return true;
                }
            }            
        }
    return false;
    }

    public int secondDigit(string input)
    {        
        String sRow = input[0].ToString().ToUpper();
        String sNumRow = sRow.Replace("A", "0").Replace("B", "1").Replace("C", "2").Replace("D", "3").Replace("E", "4").Replace("F", "5").Replace("G", "6").Replace("H", "7").Replace("I", "8").Replace("J", "9");
        int iRow;
        int.TryParse(sNumRow,out iRow);
        return iRow;
    }

    public int firstDigit(string input)
    {
        String sCol = input[1].ToString();
        int iCol;
        int.TryParse(sCol, out iCol);
        return iCol;
    }

    public string shoot(int iRow, int iCol)
    {
        String sReturned;
        sReturned = b.checkValue(iRow, iCol);
        if (sReturned.Contains("H"))
        {
            return "You have already hit this ship!";
        }
        else if (sReturned.Contains("D"))
        {
            b.changeValue(iRow, iCol, "DH");
            if (s.isSunk("DH"))
            {
                shipsHit++;
                if (checkIfWon())
                {
                   return "YOU HAVE WON!!";
                }
                else
                {
                    return "You sunk a ship!";
                }
            }
            else
            {
                return "You hit a ship!";
            }
        }
        else if (sReturned.Contains("B"))
        {
            b.changeValue(iRow, iCol, "BH");
            if (s.isSunk("BH"))
            {
                shipsHit++;
                if (checkIfWon())
                {
                    return "YOU HAVE WON!!";
                }
                else
                {
                    return "You sunk a ship!";
                }
            }
            else
            {
                return "You hit a ship!";
            }
        }
        else if (sReturned.Contains("E"))
        {
            b.changeValue(iRow, iCol, "EH");
            if (s.isSunk("EH"))
            {
                shipsHit++;
                if (checkIfWon())
                {
                    return "YOU HAVE WON!!";
                }
                else
                {
                    return "You sunk a ship!";
                }
            }
            else
            {
                return "You hit a ship!";
            }
        }
        else if (sReturned == "~")
        {
            b.changeValue(iRow, iCol, "O");
            return "You missed!";
        }
       
        return "";
    }

    public bool checkIfWon()
    {
        if(shipsHit==3)
        {
            return true;
        }
        return false;
    }
}