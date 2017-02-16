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
        static int elementos = 4;
        Producto[] pdc = new Producto[elementos];
        String[] dts = new String[elementos];
        ImageButton[] imgb = new ImageButton[elementos];

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            cargaInicial();
        }

        protected void cargaInicial()
        {
            dts[0] = "Coca Cola-12";
            dts[1] = "Sprite-10";
            dts[2] = "Fanta-9";
            dts[3] = "Manzana Lift-8";
            for (int i = 0; i < elementos; i++)
            {
                pdc[i] = new Producto();
                pdc[i].Nombre = dts[i].Split('-')[0];
                pdc[i].Precio = Convert.ToInt32(dts[i].Split('-')[1]);
            }
            imgb[0] = ckc;
            imgb[1] = spr;
            imgb[2] = fnt;
            imgb[3] = mnz;

        }

        protected void cambioElemento()
        {
            int lineas = Table1.Rows.Count;
            while (Table1.Rows.Count > 1)
            {
                Table1.Rows.RemoveAt(lineas);
                lineas--;
            }
            for (int i = 0; i < elementos; i++)
            {
                if (pdc[i].Cantidad > 0)
                {
                    TableRow tbr = new TableRow();
                    TableCell[] cll = new TableCell[6];
                    for (int ii = 0; ii < elementos; ii++)
                    {
                        tbr.Cells.Add(cll[ii]);
                    }
                    tbr.Cells[0].Text = pdc[i].Cantidad.ToString();
                    tbr.Cells[1].Text = pdc[i].Nombre;
                    tbr.Cells[2].Text = pdc[i].Precio.ToString();
                    tbr.Cells[3].Text = (pdc[i].Precio*pdc[i].Cantidad).ToString();
                    tbr.Cells[4].Text = ((pdc[i].Precio * pdc[i].Cantidad)*.16).ToString();
                    tbr.Cells[4].Text = ((pdc[i].Precio * pdc[i].Cantidad) * 1.16).ToString();
                    Table1.Rows.Add(tbr);
                }
            }
        }

        protected void agregarProducto(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            for(int i = 0; i < elementos; i++)
            {
                if(imgb[i].Equals(btn))
                {
                    pdc[i].Cantidad++;
                    break;
                }
            }
            cambioElemento();
        }
    }
}
