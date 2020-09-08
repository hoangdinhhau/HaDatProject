using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaDatProject.DTO
{
    public class Checkinout
    {
        public int ID { get; set; }
        private string pin;
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        private DateTime checktime;
        public DateTime Checktime
        {
            get { return checktime; }
            set { checktime = value; }
        }
        private string checktype;
        public string Checktype
        {
            get { return checktype; }
            set { checktype = value; }
        }
        private int verifycode;
        public int Verifycode
        {
            get { return verifycode; }
            set { verifycode = value; }
        }
        private string sn;
        public string SN
        {
            get { return sn; }
            set { sn = value; }
        }
        private string sensorid;
        public string Sensorid
        {
            get { return sensorid; }
            set { sensorid = value; }
        }
        private string workcode;
        public string Workcode
        {
            get { return workcode; }
            set { workcode = value; }
        }
        private string reserved;
        public string Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        private string sn_name;
        public string Sn_name
        {
            get { return sn_name; }
            set { sn_name = value; }
        }

        public Checkinout(int id, string pin, DateTime checktime, string checktype,
            int verifycode, string sn, string sensorid, string workcode, string reserved, string sn_name)
        {
            this.ID = id;
            this.Pin = pin;
            this.Checktime = checktime;
            this.Checktype = checktype;
            this.Verifycode = verifycode;
            this.SN = sn;
            this.Sensorid = sensorid;
            this.Workcode = workcode;
            this.Reserved = reserved;
            this.Sn_name = sn_name;
        }

        public Checkinout(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Pin = row["pin"].ToString();
            var checktimetemp = row["checktime"];
            if (checktimetemp.ToString() != "")
                this.Checktime = (DateTime)checktimetemp;
            this.Checktype = row["checktype"].ToString();
            this.Verifycode = (int)row["verifycode"];
            this.SN = row["sn"].ToString();
            this.Sensorid = row["sensorid"].ToString();
            this.Workcode = row["workcode"].ToString();
            this.Reserved = row["reserved"].ToString();
            this.Sn_name = row["sn_name"].ToString();
        }
    }
}
