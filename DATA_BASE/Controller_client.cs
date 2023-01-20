using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

//CREAR OTRAS CLASES DB

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
       
        public List<CLIENT> EnableClientTable() {
             
                                   
            var n = (from k in Conection.CLIENT
                        where k.STATE == true
                        select k).ToList();
                
            return n;
            

        }

        public List<CLIENT> ClientTable() {
             
                
            var n = (from k in Conection.CLIENT
                        select k).ToList();

            return n;
            

        }
    
        public bool AddClient(string name, string nit, string tel) {
            
            
            bool ready = false;

                 
                var iter = from k in Conection.CLIENT
                            select k;

                foreach (var n in iter) {
                    //Si el usuario existe, sale de la ejecución
                    if (n.NIT == nit) {
                        return false;
                    }
                }

                CLIENT cliente = new CLIENT() {
                    NAME = name,
                    NIT = nit,
                    PHONE_NUMBER = tel,
                    STATE = true
                };

                Conection.CLIENT.InsertOnSubmit(cliente);
                Conection.SubmitChanges();
                ready = true;

                
            return ready;

        }
        
        public bool RemoveClient(int id) {
            bool ready = false;
             


            CLIENT cliente = Conection.CLIENT.Where(s => s.ID_CLIENT == id).FirstOrDefault();
            cliente.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditClient(int id, string name, string nit, string tel, bool state) {
            
         
            bool ready = false;
             


            CLIENT cliente = Conection.CLIENT.Where(s => s.ID_CLIENT == id).FirstOrDefault();
            cliente.NAME = name;
            cliente.PHONE_NUMBER = tel;
            cliente.NIT = nit;
            cliente.STATE = state;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;


        }
        
        public List<string> BooleanStates() {
            List<string> model = new List<string>();

            model.Add("True");
            model.Add("False");

            return model;
        }
    }
}
