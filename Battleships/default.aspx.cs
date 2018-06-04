using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    Player p = new Player();
    Game g = new Game();
    Board b = new Board();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            g.play();        
        }
        txtUserGuess.Focus();
        showGrid();
    }

    protected void btnShoot_Click(object sender, EventArgs e)
    {
        String sGuess = txtUserGuess.Text.ToString();
        int iRow;
        int iColumn;
        if(p.validateText(sGuess))
        {
            iRow = p.firstDigit(sGuess);
            iColumn = p.secondDigit(sGuess);
            pnlError.Controls.Clear();
            pnlError.Controls.Add(new LiteralControl(p.shoot(iRow, iColumn)));
            pnlGrid.Controls.Clear();
            showGrid();
        }
        else
        {
            //throw up an error saying input wasn't right!
            pnlError.Controls.Add(new LiteralControl("Please make sure you put in a valid coordinate"));
        }
        txtUserGuess.Text = "";
    }

    public void showGrid()
    {
        //if you want to see the grid and placements, uncomment this :)
        //int iRow = 0;
        //pnlGrid.Controls.Add(new LiteralControl("<table><tr><td></td><td>A</td><td>B</td><td>C</td><td>D</td><td>E</td><td>F</td><td>G</td><td>H</td><td>I</td><td>J</td></tr>"));
        //for (int i = 0; i < b.GetCells.GetLength(0); i++)
        //{
        //    pnlGrid.Controls.Add(new LiteralControl("<tr><td>" + iRow + "</td>"));
        //    for (int j = 0; j < b.GetCells.GetLength(1); j++)
        //    {
        //        pnlGrid.Controls.Add(new LiteralControl("<td>" + b.GetCells[i, j].ToString() + "</td>"));
        //    }
        //    pnlGrid.Controls.Add(new LiteralControl("</tr>"));
        //    iRow++;
        //}
    }
}