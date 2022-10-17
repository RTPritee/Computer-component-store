using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerComponentStore
{
    public partial class UCFDelete : UserControl
    {
        private DataAccess Da { get; set; }
        private string DeleteString;
        public UCFDelete()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Component;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dvgProduct.AutoGenerateColumns = false;
            this.dvgProduct.DataSource = ds.Tables[0];

        }
        private void DeleteRowTable()
        {

            try
            {



                var sql = "DELETE FROM Component WHERE Id='" + DeleteString + "';";
                int count = this.Da.ExecuteUpdateQuery(sql);

                if (count == 1)
                    MessageBox.Show("Delete successfull");
                else
                    MessageBox.Show(" failed");

                DeleteString = null;

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteString != null)
            {
                DeleteRowTable();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            DeleteString = txtDeleteId.Text;
            DeleteRowTable();
        }

        private void dvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dvgProduct.CurrentRow.Selected = true;

                DeleteString = dvgProduct.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }
    }
}
