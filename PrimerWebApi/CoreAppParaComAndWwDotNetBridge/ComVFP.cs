using caplogon;
using capps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppParaComAndWwDotNetBridge
{
    public static class ComVFP
    {
        public static ul_logon UsoDeCapLogon(int idEmp)
        {
            var u = new ul_logon();
            var mErr = "";
            if (u.login("SUPERVISOR", "", ref mErr))
            {
                if (u.login_emp("SUPERVISOR", "", idEmp, ref mErr))
                    return u;
                else
                    throw new Exception(mErr);
            }
            else
                throw new Exception(mErr);
        }

        public static string UsoDeUlMovStk(ul_logon u)
        {
            var ums = new ul_movstk();
            var mErr = "";
            if (ums.set_ul_logon(u, ref mErr))
                return ums.get_rs_desing();
            else
                return mErr;
        }
    }
}
