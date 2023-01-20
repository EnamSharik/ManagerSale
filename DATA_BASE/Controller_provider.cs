using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<PROVIDER> EnableProviderTable() {
             
                
            var n = (from k in Conection.PROVIDER
                        where k.STATE == true
                        select k).ToList();

            return n;

        }
        public IQueryable EnableProviderLookUp() {


            var n = from k in Conection.PROVIDER
                    where k.STATE == true
                    select new {
                        ID = k.ID_PROVIDER,
                        COMPANY = k.COMPANY
                    };

            return n;

        }

        public List<PROVIDER> ProviderTable() {
             
                
            var n = (from k in Conection.PROVIDER
                        select k).ToList();

            return n;
            

        }

        public bool AddProvider(string company,string representative, string contact) {
            bool ready = false;

             

            PROVIDER PAY = new PROVIDER() {
                COMPANY = company,
                REPRESENTATIVE = representative,
                CONTACT_INFORMATION = contact,
                STATE = true
            };
                
            Conection.PROVIDER.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
            return ready;

        }

        public bool RemoveProvider(int id) {
            bool ready = false;
             
                
            PROVIDER pay = Conection.PROVIDER.Where(s => s.ID_PROVIDER == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditProvider(int id, string company, string representative, string contact, bool state) {
            bool ready = false;
             
                
            PROVIDER PAY = Conection.PROVIDER.Where(s => s.ID_PROVIDER == id).FirstOrDefault();
            PAY.COMPANY = company;
            PAY.REPRESENTATIVE = representative;
            PAY.CONTACT_INFORMATION = contact;
            PAY.STATE = state;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public int getIDProviderByCompany(string company) {
            int id = Conection.PROVIDER.Where(s => s.COMPANY == company).FirstOrDefault().ID_PROVIDER;
            return id;
        }

    }
}
