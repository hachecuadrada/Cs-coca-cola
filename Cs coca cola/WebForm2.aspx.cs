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

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (!Carrito.yacargo)
            {
                cargaInicial();
                Carrito.yacargo = true;
            }
        }

        protected void cargaInicial()
        {
            Carrito.dts[0] = "Coca Cola-12";
            Carrito.dts[1] = "Sprite-10";
            Carrito.dts[2] = "Fanta-9";
            Carrito.dts[3] = "Manzana Lift-8";
            for (int i = 0; i < Carrito.elementos; i++)
            {
                Carrito.pdc[i] = new Producto();
                Carrito.pdc[i].Nombre = Carrito.dts[i].Split('-')[0];
                Carrito.pdc[i].Precio = Convert.ToInt32(Carrito.dts[i].Split('-')[1]);
            }
            Carrito.imgb[0] = ckc;
            Carrito.imgb[1] = spr;
            Carrito.imgb[2] = fnt;
            Carrito.imgb[3] = mnz;
        }

        protected void cambioElemento()
        {
            int lineas = Table1.Rows.Count;
            while (Table1.Rows.Count > 1)
            {
                Table1.Rows.RemoveAt(lineas);
                lineas--;
            }
            for (int i = 0; i < Carrito.elementos; i++)
            {
                if (Carrito.pdc[i].Cantidad > 0)
                {
                    TableRow tbr = new TableRow();
                    TableCell[] cll = new TableCell[6];
                    for (int ii = 0; ii < 6; ii++)
                    {
                        cll[ii] = new TableCell();
                        tbr.Cells.Add(cll[ii]);
                    }
                    tbr.Cells[0].Text = Carrito.pdc[i].Cantidad.ToString();
                    tbr.Cells[1].Text = Carrito.pdc[i].Nombre;
                    tbr.Cells[2].Text = Carrito.pdc[i].Precio.ToString();
                    double bruto = Carrito.pdc[i].Precio * Carrito.pdc[i].Cantidad;
                    tbr.Cells[3].Text = Math.Round(bruto, 2).ToString();
                    double IVA = bruto * .16;
                    tbr.Cells[4].Text = Math.Round(IVA,2).ToString();
                    double total = bruto + IVA;
                    tbr.Cells[5].Text = Math.Round(total, 2).ToString();
                    Table1.Rows.Add(tbr);
                }
            }
        }

        protected void agregarProducto(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            for(int i = 0; i < Carrito.elementos; i++)
            {
                if(Carrito.imgb[i].ID.Equals(btn.ID))
                {
                    Carrito.pdc[i].Cantidad++;
                    break;
                }
            }
            cambioElemento();
        }
    }
}
