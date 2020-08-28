using HaDatProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaDatProject
{
    public partial class fLog : Form
    {
        BindingSource listLog= new BindingSource();
        public fLog()
        {
            InitializeComponent();
            LoadLog();
        }

        private void btSeachLog_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text;
                int checktime_Id = 0;                
                
                if (txtChecktime_Id.Text == "")
                {
                    checktime_Id = 0;
                    listLog.DataSource = SavelogDAO.Instance.SeachSaveLogbyusername(username);
                }
                else
                {
                    checktime_Id = Convert.ToInt32(txtChecktime_Id.Text);
                    if (checktime_Id == 0)
                    {
                        listLog.DataSource = SavelogDAO.Instance.SeachSaveLogbyusername(username);
                    }
                    else if (username == "")
                    {
                        listLog.DataSource = SavelogDAO.Instance.SeachSaveLogbyusernamechecktime_id(username, checktime_Id);
                    }
                    else
                    {
                        listLog.DataSource = SavelogDAO.Instance.SeachSaveLogbyusernamechecktime_id(username, checktime_Id);
                    }
                    dtgLog.DataSource = listLog;
                }
               
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        void LoadLog()
        {
            listLog.DataSource = SavelogDAO.Instance.GetSavelogs();
            dtgLog.DataSource = listLog;
        }
    }
}
