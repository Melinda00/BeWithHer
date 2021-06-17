using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeWithHer
{
    static class RegisterUtils
    {
        static public bool UidExist(string uid)
        {
            bool userExist = Convert.ToInt32(BeWithHerConnector.ExecuteQuery(String.Format("select count(U_ID) from UINFO where U_ID = '{0}';", uid))[0][0]) == 1;
            bool doctorExist = Convert.ToInt32(BeWithHerConnector.ExecuteQuery(String.Format("select count(DOC_ID) from DOCTOR where DOC_ID = '{0}';", uid))[0][0]) == 1;
            return userExist || doctorExist;
        }

        static public bool ValidPhoneNum(string phone)
        {
            if (phone.Length != 11) return false;
            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        static public bool ValidAge(string age)
        {
            int iAge = 0;

            try
            {
                iAge = Convert.ToInt32(age);
            }
            catch
            {
                return false;
            }

            return iAge > 0 && iAge < 100;
        }

        static public bool ValidPeriod(string period)
        {
            int iPeriod = 0;
            try
            {
                iPeriod = Convert.ToInt32(period);
            }
            catch
            {
                return false;
            }

            return iPeriod > 0 && iPeriod <= 31;
        }
    }
}
