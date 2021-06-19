using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeWithHer
{
    public class Department
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Hospital { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public static Department LoadDepartment(object[] info)
        {
            Department result = new Department();
            result.ID = Convert.ToString(info[0]);
            result.Name = Convert.ToString(info[1]);
            result.Hospital = Convert.ToString(info[2]);
            result.Address = Convert.ToString(info[3]);
            result.Phone = Convert.ToString(info[4]);
            return result;
        }

        public static List<Department> LoadDepartments(List<object[]> infos)
        {
            List<Department> result = new List<Department>();
            foreach (object[] info in infos) result.Add(LoadDepartment(info));
            return result;
        }

        public static Department LoadDepartment(string deptID)
        {
            string cmd = string.Format("select * from DEPARTMENT where D_ID = {0};", deptID);
            return LoadDepartment(BeWithHerConnector.ExecuteQuery(cmd)[0]);
        }
    }
}
