using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cs_coca_cola
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ListItemCollection registro = new ListItemCollection();
        TableRow[] tbr = new TableRow[4];
        TableCell[] cll = new TableCell[6];
        bool[] linea = new bool[4];
        Producto[] refresco = new Producto[4];


        protected void cambioElemento()
        {
            #region lista
            int total = 0;

            foreach (ListItem item in Lista.Items)
            {
                total += Convert.ToInt32(item.Value);
            }

            Label1.Text = "Total: " + total.ToString();
            #endregion

            #region tabla
            foreach (ListItem itm in Lista.Items)
            {
                switch (itm.Value)
                {
                    case "10":
                        if (!linea[0])
                        {
                            linea[0] = true;
                            Table1.Rows.Add(tbr[0]);
                        }

                        break;
                    case "12":
                        if (!linea[1])
                        {
                            linea[1] = true;
                            Table1.Rows.Add(tbr[1]);
                        }
                        break;
                    case "8":
                        if (!linea[2])
                        {
                            linea[2] = true;
                            Table1.Rows.Add(tbr[2]);
                        }
                        break;
                    case "9":
                        if (!linea[3])
                        {
                            linea[3] = true;
                            Table1.Rows.Add(tbr[3]);
                        }
                        break;
                }
            }
            #endregion

            int ite = Table2.Rows.Count;

            while (ite > 1)
            {
                Table2.Rows.Remove(Table2.Rows[ite]);
                ite--;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void agregarProducto(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            switch (btn.ID)
            {
                case "sprite":
                    Lista.Items.Add(new ListItem("Sprite", "10"));
                    break;
                case "coke":
                    Lista.Items.Add(new ListItem("Coca Cola", "12"));
                    break;
                case "apple":
                    Lista.Items.Add(new ListItem("Manzana Lift", "8"));
                    break;
                case "fanta":
                    Lista.Items.Add(new ListItem("Fanta", "9"));
                    break;
            }
            cambioElemento();
        }

        protected void Lista_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Table1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tbr.Length; i++)
            {
                tbr[i] = new TableRow();
                linea[i] = false;
                for (int ii = 0; ii < cll.Length; ii++)
                {
                    cll[i] = new TableCell();
                    tbr[i].Cells.Add(cll[i]);
                }
            }

            tbr[0].ID = "TSprite";
            tbr[1].ID = "TCoke";
            tbr[2].ID = "TApple";
            tbr[3].ID = "TFanta";
            tbr[0].Cells[1].Text = "Sprite";
            tbr[1].Cells[1].Text = "Coca Cola";
            tbr[2].Cells[1].Text = "Manzana Lift";
            tbr[3].Cells[1].Text = "Fanta";
            tbr[0].Cells[2].Text = "10";
            tbr[1].Cells[2].Text = "12";
            tbr[2].Cells[2].Text = "8";
            tbr[3].Cells[2].Text = "9";
            tbr[0].Cells[0].Text = "1";
            tbr[1].Cells[0].Text = "1";
            tbr[2].Cells[0].Text = "1";
            tbr[3].Cells[0].Text = "1";
        }
    }
}