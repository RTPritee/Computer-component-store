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
    public partial class Salesman : Form
    {
        private string[] s = new string[100];
        private static byte countIteam;
        private int totalPrice;
        private DataAccess Da { get; set; }
        private FormLogin F3 { get; set; }
        public Salesman()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopularGridView();
        }
        public Salesman(FormLogin f3) : this()
        {
            this.F3 = f3;
        }
        public byte CountIteam
        {
            get { return countIteam; }
            set { }
        }
        private void PopularGridView(string sql = "select * from Component") // optional parameter - default value dea dey
        {
            var Component = Da.ExecuteQuery(sql);

            this.dgvSalesmanComponent.AutoGenerateColumns = false;
            this.dgvSalesmanComponent.DataSource = Component.Tables[0];
        }
       
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            lblIteamCount.Text = countIteam.ToString();
            this.PopularGridView();
            countIteam = 0;
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = null;
            }
            totalPrice = 0;
            Resetlabels();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            this.Visible = false;
        }
       
        private void Salesman_Load(object sender, EventArgs e)
        {

        }

        private void pctbCart_Click(object sender, EventArgs e)
        {
            if (countIteam == 0)
            {
               
                MessageBox.Show("YOU DON'T HAVE ANYTHING IN CART, SELECT PRODUCT FIRST", "CART");
            }
            else
            {
                FormCart C1 = new FormCart(this, s, countIteam);
                C1.Show();
                this.Hide();
                
            }
        }

        private void dgvSalesmanComponent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesmanComponent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvSalesmanComponent.CurrentRow.Selected = true;
                    //s[countIteam] = dgvSalesmanComponent.Rows[e.RowIndex].Cells[1].Value.ToString();


                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Add to cart selected product?", "product", buttons);
                    if (result == DialogResult.OK)
                    {
                        s[countIteam] = dgvSalesmanComponent.Rows[e.RowIndex].Cells[1].Value.ToString();
                        lblIteamCount.Text = s[countIteam];
                        string sql = "select * from Component WHERE Id='" + s[countIteam] + "';";
                        var ds = this.Da.ExecuteQueryTable(sql);
                        string price = ds.Rows[0][5].ToString();
                        totalPrice += Int32.Parse(price);
                        lblPrice.Text = totalPrice.ToString();
                        countIteam++;
                        lblIteamCount.Text = countIteam.ToString();
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Select from the sell not from blank space");
            }

        }
        private void Resetlabels()
        {
            lblIteamCount.Text = "";
            lblPrice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countIteam = 0;
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = null;
            }
            totalPrice = 0;
            Resetlabels();

        }

       
    }
}
