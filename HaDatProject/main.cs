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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            LoadAdmin();
        }

        public static string GetDateFromDateTime(DateTime datevalue)
        {
            return datevalue.ToShortDateString();
        }

        BindingSource checkinoutlist = new BindingSource();

        void LoadAdmin()
        {
            dtgMain.DataSource = checkinoutlist;
            Loadcheckinout();
           // AddCheckinoutBinding();
        }

        void Loadcheckinout()
        {
            checkinoutlist.DataSource = CheckinoutDAO.Instance.GetCheckinouts();
            dtgMain.DataSource = checkinoutlist;
        }

        //void AddCheckinoutBinding()
        //{
        //    txtPIN.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "ID", true, DataSourceUpdateMode.Never));
        //    dtpChecktime.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "checktime", true, DataSourceUpdateMode.Never));
        //}

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var checkinouts = dtgMain.SelectedRows;
            if (checkinouts is null)
            {
                return;
            }
            var checkinout = checkinouts[0];

            txtPIN.Text = checkinout.Cells[0].Value.ToString();
            dtpChecktime.Text = checkinout.Cells[1].Value.ToString();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string pin = txtSearch.Text;
                checkinoutlist.DataSource = CheckinoutDAO.Instance.SeachCheckinout(pin);
                dtgMain.DataSource = checkinoutlist;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
