using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<EMPLOYEES> EnableEmployeeTable() {

            var n = (from k in Conection.EMPLOYEES
                        where k.STATE == true
                        select k).ToList();

            return n;
            

        }

        public List<EMPLOYEES> EmployeesTable() {
             
            var n = (from k in Conection.EMPLOYEES
                        select k).ToList();

            return n;
            

        }

        public bool AddEmployees(string user, string password, bool superUser) {

            bool ready = false;

             

            var iter = from k in Conection.EMPLOYEES
                        select k;

            foreach (var n in iter) {
                //Si el usuario existe, sale de la ejecución
                if(n.USER == user) {
                    return false;
                }
            }
                    
            DATA_BASE.EMPLOYEES DSS = new DATA_BASE.EMPLOYEES()
            {
                USER = user,
                PASSWORD = password,
                SUPERUSER = superUser,
                STATE = true
            };
                    

            Conection.EMPLOYEES.InsertOnSubmit(DSS);
            Conection.SubmitChanges();
            ready = true;

        
            return ready;


        }

        public bool RemoveEmployees(int id) {
            bool ready = false;
             


            var employe = (from c in Conection.EMPLOYEES
                            where c.STATE == true && c.ID_EMPLOYEES == id
                            select c).FirstOrDefault();

            employe.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditEmployees(int id, string user, string password, bool state) {


            bool ready = false;
                 


            var employe = (from c in Conection.EMPLOYEES
                            where c.ID_EMPLOYEES == id
                            select c).FirstOrDefault();

            employe.STATE = state;
            employe.USER = user;
            employe.PASSWORD = password;
            employe.STATE = state;

            Conection.SubmitChanges();
            ready = true;
                    

                
            return ready;



        }
    
        public int getIdByName_employee(string user) {
             
                
                var employeed = (from emp in Conection.EMPLOYEES
                                where emp.USER == user
                                select emp.ID_EMPLOYEES).FirstOrDefault();

                return employeed;


            
        }
    }
}
