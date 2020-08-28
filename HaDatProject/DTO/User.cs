using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DTO
{
    public class User
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public User(int id, string username, string password, string email)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }

        public User(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Email = row["email"].ToString();
        }
    }
}
