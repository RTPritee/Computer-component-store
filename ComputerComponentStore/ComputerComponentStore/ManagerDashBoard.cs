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

namespace ComputerComponentStore
{
    public partial class ManagerDashBoard : Form
    {
        private FormLogin Fl { get; set; }
        public ManagerDashBoard(FormLogin fl) : this()
        {
            this.Fl = fl;
        }
        public ManagerDashBoard()
        {
            InitializeComponent();
        }

        private void buttonComponentList_Click(object sender, EventArgs e)
        {
            FormManagerComponent admin = new FormManagerComponent();
            admin.Show();
            this.Visible = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Complete");
            Application.Exit();
           // this.Fl.Visible = true;   
        }
        private void buttonSalesmanList_Click(object sender, EventArgs e)
        {
            FormSalesmanList salList = new FormSalesmanList();
            salList.Show();
            this.Visible = false;
        }
        private void ManagerDashBoard_Load(object sender, EventArgs e)
        {

        }
        private void ManagerDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
