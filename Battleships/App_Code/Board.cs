using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

/// <summary>
/// Summary description for Board
/// </summary>   

public class Board
{
    Random rnd = new Random();
    bool shipAddedFlag = false;
    private static string[,] cells = new string[10, 10];
    public Board()
    {
        
    }

    public string[,] GetCells
    {
        get
        {
            return cells;
        }
    }

    public void fillWater()
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells.SetValue("~",i,j);
            }            
        }
    }

    public void placeShips()
    {
        Ships[] shipsToPlace =
        {
            new Battleship(),
            new Destroyer(),
            new DestroyerTwo()
        };

        foreach (Ships s in shipsToPlace)
        {           
            do
            {                
                    shipAddedFlag = false;
                    randomCell(s.Length, s.Code);
                    Debug.WriteLine("Trying: {0}", s);                
            } while (!shipAddedFlag);
            Debug.WriteLine("Added to Fleet: {0}", s);
        }
    }

    public void randomCell(int length, string desc)
    {
        int row = rnd.Next(cells.GetLength(0)-length);
        int column = rnd.Next(cells.GetLength(1));

        tryToAdd(row, column, length, desc);
        
    }

    public void tryToAdd(int row, int column, int length, string desc)
    {
        int counter = 0;
        if (cells.GetValue(row, column).ToString() == "~")
        {
            for (int i = row; counter < length; i++)
            {
                if (cells.GetValue(i, column).ToString() == "~")
                {
                    counter++;
                }
                else
                {
                    randomCell(length, desc);
                }
            }
            addShip(row, column, length, desc);
        }
        else
        {
            randomCell(length, desc);
        }
    }

    public void addShip(int row, int column, int length, string desc)
    {
        int counter = 0;
        if (cells.GetValue(row, column).ToString() == "~")
        {
            for (int i = row + 1; counter < length - 1; i++)
            {
                if (cells.GetValue(i, column).ToString() == "~")
                {
                    cells.SetValue(desc, i, column);
                    counter++;
                }
            }

        }        
        cells.SetValue(desc, row, column);
        shipAddedFlag = true;
        Debug.Print("row : " + row + " col : " + column);
    }

    public string checkValue(int iRow, int iCol)
    {
        return cells.GetValue(iRow, iCol).ToString();        
    }

    public void changeValue(int iRow, int iCol, string newVal)
    {
        cells.SetValue(newVal, iRow, iCol);
    }
}