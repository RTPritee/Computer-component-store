using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace ComputerComponentStore
{
    public partial class FormManagerComponent : Form
    {
        private DataAccess Da { get; set; }
        private ManagerDashBoard F2 { get; set; }
        public FormManagerComponent()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = "select * from Component";
            this.PopularGridView(sql);
        }
        public FormManagerComponent(ManagerDashBoard f2) : this()
        {
            this.F2 = f2;
        }
        private void PopularGridView (string sql)
        {
            var Component = Da.ExecuteQuery(sql);

            this.dgvComponentList.AutoGenerateColumns = false;
            this.dgvComponentList.DataSource = Component.Tables[0];
        }
       
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from Component";
            this.PopularGridView(sql);
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerDashBoard mdb = new ManagerDashBoard();
            mdb.Show();
            this.Visible = false;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Component where Components like '" + this.textBoxSearch.Text + "%';";
            this.PopularGridView(sql);
        }
        private void FormManagerComponent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FormManagerComponent_Load(object sender, EventArgs e)
        {

        }

        private void panelComponentEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            FormOperation O1 = new FormOperation(this);
            O1.Show();
        }
    }
}
