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
            var x = CheckinoutDAO.Instance.GetCheckinouts();
            // dtgMain.AutoGenerateColumns = false;
            dtgMain.DataSource = checkinoutlist;
            string[] visibleColumns = { "ID", "pin", "checktime" };
            foreach(DataGridViewColumn col in dtgMain.Columns)
            {
                if(! visibleColumns.Contains(col.Name))
                {
                    col.Visible = false;
                }
            }
            dtgMain.Columns["checktime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }


        //void AddCheckinoutBinding()
        //{
        //    txtPIN.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "ID", true, DataSourceUpdateMode.Never));
        //    dtpChecktime.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "checktime", true, DataSourceUpdateMode.Never));
        //}


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

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void dtgMain_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var selectedRows = dtgMain.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var selected = selectedRows[selectedRows.Count - 1];
                txtPIN.Text = selected.Cells["pin"].Value.ToString();
                dtpChecktime.Value = DateTime.Parse(selected.Cells["checktime"].Value.ToString());

            }
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
