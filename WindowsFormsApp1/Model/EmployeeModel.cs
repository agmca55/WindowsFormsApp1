using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   public class EmployeeModel
    {
        public Int32 id { get; set; }
        public Int32 age { get; set; }
        public string name { get; set; }

        public static List<EmployeeModel> getEmployee()
        {
            List<EmployeeModel> lstEmp = new List<EmployeeModel>();
            lstEmp.Add(new EmployeeModel { id = 1, age = 25, name = "anil" });
            lstEmp.Add(new EmployeeModel { id = 2, age = 27, name = "raman" });
            lstEmp.Add(new EmployeeModel { id = 3, age = 25, name = "raghav" });
            lstEmp.Add(new EmployeeModel { id = 4, age = 33, name = "rakesh" });
            lstEmp.Add(new EmployeeModel { id = 5, age = 55, name = "ravi" });
            lstEmp.Add(new EmployeeModel { id = 6, age = 11, name = "satish" });
            lstEmp.Add(new EmployeeModel { id = 7, age = 78, name = "kishan" });
            lstEmp.Add(new EmployeeModel { id = 8, age = 24, name = "saman" });
            return lstEmp;
        }
    }
}
