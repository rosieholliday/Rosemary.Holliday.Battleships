using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Game
/// </summary>
public class Game
{
    public Game()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void play()
    {
        Board board = new Board();
        board.fillWater();
        board.placeShips();
    }
}