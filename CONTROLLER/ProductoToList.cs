using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Drawing;
using MANAGER_SALE.CONTROLLER.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.CONTROLLER {
    public class ProductoToList {
        public double total { get; set; }
        public List<BEAN.ProductoPorComprar> listadoDeProductos = new List<BEAN.ProductoPorComprar>();
        DATA_BASE.Controller controller = new DATA_BASE.Controller();
        
    
        public void ADD(int id_producto) {
            //VALIDAR SI EL PRODUCTO (ID PRODUCTO) EXISTE EN EL LISTADO
            //SI EXISTE MODIFICAR LA CANTIDAD (+1)
            //AGREGAR EL PRECIO DEL PRODUCTO AL TOTAL
            // SI EL PRODUCTO NO EXISTE
            //AGREGARLO AL LISTADO
            //SUMAR EL PRECIO DEL PRODUCTO AL TOTAL

            if (validarExistenciaDeProducto(id_producto)) {

                var productoDx = listadoDeProductos.Where(s => s.ID_product == id_producto).FirstOrDefault();
                productoDx.quantity++;
                calculateTotal();


            } else {
                BEAN.ProductoPorComprar producto = new BEAN.ProductoPorComprar(id_producto);
                producto.SubTotal += Convert.ToDouble(controller.getPriceByID(id_producto));

                listadoDeProductos.Add(producto);
                calculateTotal();
            } 

            

        }

        public void DELETE(int id_producto) {
            //DESHABILITAR EL PRODUCTO
            //DESCONTAR EL PRECIO DE LOS PRODUCTOS DEL TOTAL
                     
            listadoDeProductos.Remove(s => s.ID_product == id_producto);
            calculateTotal();
        }

        internal bool validarExistenciaDeProducto(int id) {
            bool valor = false;
            foreach(var n in listadoDeProductos) {
                if (n.ID_product == id) {
                    return true;
                    
                } else {
                    continue;
                }

            }
            return valor;
        }
    
        internal void calculateTotal() {
            double money = 0;
            foreach (var n in this.listadoDeProductos) {
                money += n.quantity * n.SubTotal;
            }
            this.total = money;
        } 
    
    }
}
