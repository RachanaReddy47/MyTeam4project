using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team4.Models
{
    public class DBOperations
    {
       static  Team4Entities T = new Team4Entities();

        public static Login_Table SendType(Login_Table L)
        {
            var l = from v in T.Login_Table
                    where v.User_ID == L.User_ID && v.Password == v.Password
                    select v;
            return l.First();
        }

    }
}