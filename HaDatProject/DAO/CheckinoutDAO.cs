using HaDatProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DAO
{
    public class CheckinoutDAO
    {

        private static CheckinoutDAO instance;
        public static CheckinoutDAO Instance
        {
            get { if (instance == null) instance = new CheckinoutDAO(); return CheckinoutDAO.instance; }
            private set { CheckinoutDAO.instance = value; }
        }
        private CheckinoutDAO() { }

        public List<Checkinout> GetCheckinouts()
        {
            List<Checkinout> list = new List<Checkinout>();
            string query = "Select *  from dbo.Checkinout";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow a in data.Rows)
            {
                Checkinout checkinout = new Checkinout(a);
                list.Add(checkinout);
            }
            return list;
        }

        public bool UpdateCheckinout(DateTime checktime, int Id)
        {
            string query = string.Format("UPDATE dbo.Checkinout SET Checktime = {0} WHERE id = {1}", checktime.Date.ToString("yyyy/MM/dd"), Id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Checkinout> SeachCheckinout(string pin)
        {
            List<Checkinout> list = new List<Checkinout>();

            string query = string.Format("SELECT * FROM dbo.Checkinout WHERE pin LIKE N'%{0}%' ", pin);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Checkinout checkinout = new Checkinout(item);
                list.Add(checkinout);
            }
            return list;
        }
    }
}
