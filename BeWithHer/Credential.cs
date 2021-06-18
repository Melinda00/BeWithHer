using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeWithHer
{
    public class Credential
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Department { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public bool Adm { get; set; }
        public bool IsUser { get; set; }

        public static Credential LoadDoctor(object[] info)
        {
            Credential doctorCredential = new Credential();
            doctorCredential.ID = Convert.ToString(info[0]);
            doctorCredential.Password = Convert.ToString(info[1]);
            doctorCredential.Name = Convert.ToString(info[2]);
            doctorCredential.Sex = Convert.ToString(info[3]);
            doctorCredential.Age = Convert.ToString(info[4]);
            doctorCredential.Department = Convert.ToString(info[5]);
            doctorCredential.Phone = Convert.ToString(info[6]);
            doctorCredential.Remark = Convert.ToString(info[7]);
            doctorCredential.Adm = Convert.ToString(info[8]) == "T";
           
            return doctorCredential;
        }

        public static List<Credential> LoadDoctors(List<object[]> infos)
        {
            List<Credential> credentials = new List<Credential>();
            foreach(object[] info in infos) credentials.Add(LoadDoctor(info));
            return credentials;
        }
    }
}
