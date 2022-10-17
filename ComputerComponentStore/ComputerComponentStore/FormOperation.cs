using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ComputerComponentStore
{
    public partial class FormOperation : MetroForm
    {
        private DataAccess Da { get; set; }
        private static string s = null;
        private FormManagerComponent F1 { get; set; }
        private string lastId;
        public FormOperation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public FormOperation(FormManagerComponent fl) : this()
        {

            this.F1 = fl;

        }
        private void PopulateGridView(string sql = "select * from Component;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dvgProduct.AutoGenerateColumns = false;
            this.dvgProduct.DataSource = ds.Tables[0];
        }
        private void CrudFormCreator(int x)
        {
            FormCrud CF = new FormCrud(this, x, s);
            CF.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Component;";
            var ds = this.Da.ExecuteQueryTable(sql);
            int i = ds.Rows.Count;
            lastId = ds.Rows[i - 1][1].ToString();

            FormCrud CF = new FormCrud(this, 1, lastId);
            CF.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CrudFormCreator(2);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (s == null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Select A Row First ", "Message", buttons);
            }
            else
            {
                CrudFormCreator(3);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Component where Components = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dvgProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dvgProduct.CurrentRow.Selected = true;

                    s = dvgProduct.Rows[e.RowIndex].Cells[0].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select from the sell not from blank space");
            }
        }

        private void FormOperation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Application Clossing?", "Exit!");
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.F1.Show();
            this.Hide();
        }
        private void FormOperation_Load(object sender, EventArgs e)
        {

        }
    }
}
