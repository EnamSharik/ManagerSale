using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        //LOGIN

        public bool ValidateUser(string user) {
             
            
            bool validate = false;
            //
            var query = (from n in Conection.EMPLOYEES
                        where n.USER == user
                        select n).FirstOrDefault();

            if (query.USER.Equals(user)) {
                validate = true;
                return validate;
            } else {
                validate = false;
            }
                    
            return validate;
            
            

        }

        public bool ValidatePSSW(string user, string password) {
             
            bool validate = false;
                
            var n = (from k in Conection.EMPLOYEES
                        where k.STATE == true
                        select k);

            foreach (var k in n) {
                if (k.USER.Equals(user) && k.PASSWORD.Equals(password)) {
                    validate = true;
                    return validate;
                } else {
                    validate = false;
                }
            }

            return validate;

            
        }
   
        public bool isSuperUser(string user) {
             
            EMPLOYEES usere = (from k in Conection.EMPLOYEES
                        where k.USER == user
                        select k).FirstOrDefault();
                
            return usere.SUPERUSER;
            
        }
    }
}
