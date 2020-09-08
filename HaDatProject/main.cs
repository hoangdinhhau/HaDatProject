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

        BindingSource checkinoutlist = new BindingSource();

        void LoadAdmin()
        {
            // dtgMain.DataSource = checkinoutlist;
            Loadcheckinout();
        }

        void Loadcheckinout()
        {
            checkinoutlist.DataSource = CheckinoutDAO.Instance.GetCheckinouts();
            var x = CheckinoutDAO.Instance.GetCheckinouts();
            dtgMain.DataSource = checkinoutlist;
            string[] visibleColumns = { "ID", "pin", "checktime" };
            foreach (DataGridViewColumn col in dtgMain.Columns)
            {
                if (!visibleColumns.Contains(col.Name))
                {
                    col.Visible = false;
                }
            }
            dtgMain.Columns["checktime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
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
                txtId.Text = selected.Cells["ID"].Value.ToString();
                txtPIN.Text = selected.Cells["pin"].Value.ToString();
                dtpChecktime.Value = DateTime.Parse(selected.Cells["checktime"].Value.ToString());

            }
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {      
            AddCheckTimeBinding();
        }

        private void btResest_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtPIN.DataBindings.Clear();
            dtpChecktime.DataBindings.Clear();
            LoadAdmin();
        }

        void AddCheckTimeBinding()
        {
            txtId.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtPIN.DataBindings.Add(new Binding("Text", dtgMain.DataSource, "pin", true, DataSourceUpdateMode.Never));
            dtpChecktime.DataBindings.Add(new Binding("value", dtgMain.DataSource, "checktime", true, DataSourceUpdateMode.Never));
            txtPIN.DataBindings.Clear();
            txtId.DataBindings.Clear();
            dtpChecktime.DataBindings.Clear();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                DateTime checktime = Convert.ToDateTime(dtpChecktime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                //  string username = Login.txtUserName.Text;
                if (CheckinoutDAO.Instance.UpdateCheckinout(checktime, id))
                {
                    DateTime oldCheckTime = new DateTime();
                    var selectedRows = dtgMain.SelectedRows;
                    DataGridViewRow selectedRow = null;
                    if (selectedRows.Count > 0)
                    {
                        selectedRow = selectedRows[selectedRows.Count - 1];
                    }
                    else
                    {
                        var cells = dtgMain.SelectedCells;
                        if (cells.Count > 0)
                        {
                            selectedRow = dtgMain.Rows[cells[0].RowIndex];
                        }
                    }
                    oldCheckTime = DateTime.Parse(selectedRow.Cells["checktime"].Value.ToString());
                    SavelogDAO.Instance.InsertSavelog(Login.CurrentUser, id, oldCheckTime, checktime, DateTime.Now);
                    MessageBox.Show("Sửa thành công");
                    btSearch_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Cập nhật thất bại." + "\n" +
                    "Vui lòng chọn MSNV !");
            }

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn đăng xuất ?");
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string pin = txtSearch.Text;
                DateTime todate = Convert.ToDateTime(dtpTungay.Value.ToString("yyyy/MM/dd"));
                DateTime fromdate = Convert.ToDateTime(dtpDenngay.Value.ToString("yyyy/MM/dd"));
                checkinoutlist.DataSource = CheckinoutDAO.Instance.SeachCheckinout(pin, todate, fromdate);
                dtgMain.DataSource = checkinoutlist;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        private void btResest_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPIN.Text = "";
            txtSearch.Text = "";
            dtpChecktime.Text = DateTime.Now.Date.ToString();
            dtpDenngay.Text = DateTime.Now.Date.ToString();
            dtpTungay.Text = DateTime.Now.Date.ToString("yyyy/MM/01");         
            LoadAdmin();
        }

        private void lịchSửChỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLog log = new fLog();
            log.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
