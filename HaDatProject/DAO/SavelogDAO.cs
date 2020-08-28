
using HaDatProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DAO
{
    public class SavelogDAO
    {
        private static SavelogDAO instance;

        public static SavelogDAO Instance
        {
            get { if (instance == null) instance = new SavelogDAO(); return instance; }
            private set { instance = value; }
        }
        private SavelogDAO() { }

        public List<Savelog> GetSavelogs()
        {
            List<Savelog> list = new List<Savelog>();
            string query = "Select *  from dbo.Savelog order by id desc";
            DataTable data = DataProviderLog.Instance.ExecuteQuery(query);
            foreach (DataRow a in data.Rows)
            {
                Savelog savelog = new Savelog(a);
                list.Add(savelog);
            }
            return list;
        }


        public List<Savelog> SeachSaveLogbyusername(string username)
        {
            List<Savelog> list = new List<Savelog>();

            string query = string.Format("SELECT * FROM dbo.Savelog WHERE username like N'%{0}%' ", username);

            DataTable data = DataProviderLog.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Savelog savelog = new Savelog(item);
                list.Add(savelog);
            }
            return list;
        }

        public List<Savelog> SeachSaveLogbyusernamechecktime_id(string username ,int checktime_id)
        {
            List<Savelog> list = new List<Savelog>();

            string query = string.Format("SELECT * FROM dbo.Savelog WHERE username like N'%{0}%' and checktime_id = {1} ", username,checktime_id);

            DataTable data = DataProviderLog.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Savelog savelog = new Savelog(item);
                list.Add(savelog);
            }
            return list;
        }

        public bool InsertSavelog(string userName,int checktime_id,DateTime last_info, DateTime edited_info,DateTime edit_time)
        {
            string query = string.Format("INSERT dbo.savelog ( userName, checktime_id, last_info, edited_info, edit_time ) VALUES  ( N'{0}', {1},'{2}','{3}','{4}')", userName, checktime_id, last_info.ToString("yyyy/MM/dd hh:mm:ss"), edited_info.ToString("yyyy/MM/dd hh:mm:ss"), edit_time.ToString("yyyy/MM/dd hh:mm:ss"));
            
            int result = DataProviderLog.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}