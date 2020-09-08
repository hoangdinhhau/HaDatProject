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
            string query = "select * from checkinout where CONVERT(date, checktime) like CONVERT(date, getdate()) order by checktime desc";
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
            string query = string.Format("UPDATE dbo.Checkinout SET Checktime = '{0}' WHERE id = {1}", checktime.ToString("yyyy/MM/dd HH:mm:ss"), Id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Checkinout> SeachCheckinout(string pin, DateTime todate, DateTime fromdate)
        {
            var _todate = todate.ToString("yyyy/MM/dd");
            _todate = _todate.ToString();
            var _fromdate = fromdate.ToString("yyyy/MM/dd");
            _fromdate = _fromdate.ToString();
            List<Checkinout> list = new List<Checkinout>();
            string query = string.Format("SELECT * FROM dbo.Checkinout WHERE pin LIKE N'%{0}%' and CONVERT(date, checktime) between '{1}' and '{2}' ",
                pin, _todate, _fromdate);

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
