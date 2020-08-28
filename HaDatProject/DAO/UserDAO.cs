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
            string query = "SELECT * FROM dbo.users WHERE username = N'" + userName + "' AND password = N'" + passWord + "' ";

            DataTable result = DataProviderLog.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
