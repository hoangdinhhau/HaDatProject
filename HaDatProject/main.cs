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
            dtgMain.DataSource = checkinoutlist;
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
            dtpChecktime.DataBindings.Add(new Binding("text", dtgMain.DataSource, "checktime", true, DataSourceUpdateMode.Never));
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
                    MessageBox.Show("Sửa thành công");

                 //   InsertSavelog(userName, id, last_info, checktime, DateTime.Now);
                    LoadAdmin();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại." + "\n"+
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
                checkinoutlist.DataSource = CheckinoutDAO.Instance.SeachCheckinout(pin);
                dtgMain.DataSource = checkinoutlist;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        private void btResest_Click_1(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtPIN.DataBindings.Clear();
            dtpChecktime.DataBindings.Clear();
            LoadAdmin();
        }

        private void lịchSửChỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLog log = new fLog();
            log.ShowDialog();
        }
    }
}
