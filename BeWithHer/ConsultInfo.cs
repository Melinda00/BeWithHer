using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeWithHer
{
    public class ConsultInfo
    {
        public string BarCode { get; set; }
        public string UserID { get; set; }
        public string DoctorID { get; set; }
        public string Date { get; set; }
        public int Color { get; set; }
        public int Flow { get; set; }
        public int State { get; set; }
        public int Grade { get; set; }
        public string UserRemark { get; set; }
        public string DoctorReply { get; set; }
        public string ConstructRemark()
        {
            return UserRemark + "@" + DoctorReply;
        }


        public static ConsultInfo LoadConsultInfo(object[] info)
        {
            ConsultInfo result = new ConsultInfo();
            result.BarCode = Convert.ToString(info[0]);
            result.UserID = Convert.ToString(info[1]);
            result.DoctorID = Convert.ToString(info[2]);
            result.Date = Convert.ToString(info[3]);
            result.Color = Convert.ToInt32(info[4]);
            result.Flow = Convert.ToInt32(info[5]);
            result.State = Convert.ToInt32(info[6]);
            result.Grade = Convert.ToInt32(info[7]);
            string[] rmks = Convert.ToString(info[8]).Split('@');
            result.UserRemark = rmks[0];
            result.DoctorReply = rmks.Length == 1 ? "" : rmks[1];
            return result;
        }

        public static List<ConsultInfo> LoadConsultInfos(List<object[]> infos)
        {
            List<ConsultInfo> result = new List<ConsultInfo>();
            foreach (object[] info in infos) result.Add(LoadConsultInfo(info));
            return result;
        }

    }
}
