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
    }
}
