using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Cs_coca_cola
{
    public class Carrito
    {
        public static int elementos = 4;
        public static bool yacargo;
        public static Producto[] pdc = new Producto[elementos];
        public static String[] dts = new String[elementos];
        public static ImageButton[] imgb = new ImageButton[elementos];
    }
}