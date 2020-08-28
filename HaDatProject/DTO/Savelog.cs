using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DTO
{
    public class Savelog
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
        private int checktime_id;
        public int Checktime_id
        {
            get { return checktime_id; }
            set { checktime_id = value; }
        }

        private DateTime last_info;
        public DateTime Last_info
        {
            get { return last_info; }
            set { last_info = value; }
        }
        private DateTime edited_info;
        public DateTime Edited_info
        {
            get { return edited_info; }
            set { edited_info = value; }
        }
        private DateTime edit_time;
        public DateTime Edit_time
        {
            get { return edit_time; }
            set { edit_time = value; }
        }

        public Savelog(int id, string username, int checktime_id,
            DateTime last_info, DateTime edited_info, DateTime edit_time)
        {
            this.ID = id;
            this.Username = username;
            this.Checktime_id = checktime_id;
            this.Last_info = last_info;
            this.Edited_info = edited_info;
            this.Edit_time = edit_time;
        }

        public Savelog(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Username = row["username"].ToString();
            this.Checktime_id = (int)row["checktime_id"];
            var last_info = row["last_info"];
            if (last_info.ToString() != "")
                this.Last_info = (DateTime)last_info;
            var edited_info = row["edited_info"];
            if (edited_info.ToString() != "")
                this.Edited_info = (DateTime)edited_info;
            var edit_time = row["edit_time"];
            if (edit_time.ToString() != "")
                this.Edit_time = (DateTime)edit_time;

        }
    }
}
