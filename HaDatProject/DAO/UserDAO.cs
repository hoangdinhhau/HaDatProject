using HaDatProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DAO
{
    public class UserDAO 
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }

        private UserDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query_login = "USP_Login @userName = N'" + userName + "' , @passWord = N'" + passWord + "'";

            DataTable result = DataProviderLog.Instance.ExecuteQuery(query_login, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
    }
}
