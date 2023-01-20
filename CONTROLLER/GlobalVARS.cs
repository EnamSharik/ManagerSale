using DevExpress.XtraGrid.Views.Tile;
using MANAGER_SALE.DATA_BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.CONTROLLER {
    public class GlobalVARS  {

        //ETERNAL VARS
        public static int id_employeed { get; set; } = 0;
        public static string ConexionDB { get; set; } = "Data Source=BRANDON-PC;Initial Catalog=POINT_OF_SALE;Integrated Security=True";

        
        //FINITE VARS
        public static int id_client { get; set; } = 0;
        public static CONTROLLER.ProductoToList gestorProductoEnlistado { get; set; } = new CONTROLLER.ProductoToList();
        public static bool pagoRealizado { get; set; } = false;
        public static CONTROLLER.PaymenthMethodToList gestorDeMetodosDePagoEnlistados { get; set; } = new CONTROLLER.PaymenthMethodToList();
        public static int ID_CURRENT_BUY { get; set; } = 0;
        public static int ID_CURRENT_PRODUCT { get; set; } = 0;
        public static decimal cantidadPagada { set; get; } = 0;

       

        public static void RESTART_CYCLE() {
            id_client= 0;
            ID_CURRENT_BUY = 0;
            ID_CURRENT_PRODUCT = 0;
            pagoRealizado = false;
            cantidadPagada = 0;
            gestorProductoEnlistado = new ProductoToList();
            gestorDeMetodosDePagoEnlistados = new PaymenthMethodToList();
    }
    }
}
