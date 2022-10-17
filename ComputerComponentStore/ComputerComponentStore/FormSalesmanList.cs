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
    public partial class FormSalesmanList : Form
    {
        private DataAccess Da { get; set; }
        public FormSalesmanList()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopularGridView();
        }
        private void PopularGridView(string sql = "select * from SalesmanList")
        {
            var Component = Da.ExecuteQuery(sql);

            this.dgvSalesmanList.AutoGenerateColumns = false;
            this.dgvSalesmanList.DataSource = Component.Tables[0];
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.PopularGridView();

            this.textBoxId.Clear();
            this.textBoxSalName.Clear();
            this.dateTimePickerDoj.Text = "";
            this.textBoxSalary.Clear();
            this.textBoxBonus.Clear();
            this.comboBoxShift.SelectedIndex = -1;
            this.textBoxPhone.Clear();
            this.dateTimePickerDob.Text = "";
            this.radioButtonFemale.Checked = false;
            this.radioButtonMale.Checked = false;
            this.radioButtonFemale.Checked = false;
            this.radioButtonMale.Text = "Male";
            this.radioButtonFemale.Text = "Female";

           
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerDashBoard mdb = new ManagerDashBoard();
            mdb.Show();
            this.Visible = false;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //string sql = "select * from SalesmanList where Name like '"+this.textBoxSearch.Text+"%';";
            var sql = @"select * 
                         from SalesmanList
                         where  Name like '" + this.textBoxSearch.Text + "%'or Gender like'" + this.textBoxSearch.Text + "%' or Shift like '" + this.textBoxSearch.Text + "%';"; 
            this.PopularGridView(sql);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.InfoValidationToAdd())
                {
                    MessageBox.Show("Data is missing !\n Please fill up all information");
                    return;
                }
                var query = "select * from SalesmanList where Id = '" + this.textBoxId.Text + "'";
                var Com = this.Da.ExecuteQuery(query);
                if (Com.Tables[0].Rows.Count==1)
                {
                    //update
                    var sql = @"update SalesmanList
                                set Name = '"+this.textBoxSalName.Text + @"',
                                [Date of Joining] = '" + this.dateTimePickerDoj.Text + @"',
                                Salary = " + this.textBoxSalary + @",
                                Bonus = " + this.textBoxBonus + @",
                                Shift = '"+this.comboBoxShift.Text + @"',
                                Contact =" +this.textBoxPhone.Text + @",
                                [Date of Birth] = '"+this.dateTimePickerDob.Text+@"',
                                Gender = '" +this.radioButtonFemale.Text + @"'
                                where Id = '"+this.textBoxId.Text+"';";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Updated Data");
                    }
                    else
                        MessageBox.Show("Update Not Successful\nTry Again");
                }
                else
                {
                    //insert
                    var sql = @"insert into SalesmanList
                      values ('" + this.textBoxId.Text + "','" + this.textBoxSalName.Text + "','"
                            + this.dateTimePickerDoj.Text + "'," + this.textBoxSalary.Text + ","
                            + this.textBoxBonus.Text + ",'" + this.comboBoxShift.Text + "'," + this.textBoxPhone.Text + ",'"
                            + this.dateTimePickerDob.Text + "','" + this.radioButtonFemale.Text + "');";
                    int count = this.Da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Add Successful");
                    }
                    else
                        MessageBox.Show("Not Successful\nTry Again");
                }
                this.PopularGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("From here you can not Update ");
            }
        }
        private bool InfoValidationToAdd()
        {
            if (String.IsNullOrEmpty(this.textBoxId.Text)||String.IsNullOrEmpty(this.textBoxSalName.Text)
                ||String.IsNullOrEmpty(this.textBoxSalary.Text)||String.IsNullOrEmpty(this.textBoxBonus.Text)
                ||String.IsNullOrEmpty(this.comboBoxShift.Text)||String.IsNullOrEmpty(this.textBoxPhone.Text)
                || String.IsNullOrEmpty(this.radioButtonFemale.Text) || String.IsNullOrEmpty(this.radioButtonMale.Text))
            {
                return false;
            }
            else 
                return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvSalesmanList.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvSalesmanList.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from SalesmanList where Id = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been successfully deleted");
                }
                else
                    MessageBox.Show("Delete failed !");
                this.PopularGridView();
            }
            catch (Exception exx)
            {
                MessageBox.Show("An error has occured : " + exx.Message);
            }
        }
        private void dgvSalesmanList_DoubleClick(object sender, EventArgs e)
        {
            this.textBoxId.Text = this.dgvSalesmanList.CurrentRow.Cells["Id"].Value.ToString();
            this.textBoxSalName.Text = this.dgvSalesmanList.CurrentRow.Cells["SalesmanName"].Value.ToString();
            this.dateTimePickerDoj.Text  = this.dgvSalesmanList.CurrentRow.Cells["DateofJoining"].Value.ToString();
            this.textBoxSalary.Text = this.dgvSalesmanList.CurrentRow.Cells["Salary"].Value.ToString();
            this.textBoxBonus.Text = this.dgvSalesmanList.CurrentRow.Cells["Bonus"].Value.ToString();
            this.comboBoxShift.Text = this.dgvSalesmanList.CurrentRow.Cells["Shift"].Value.ToString();
            this.textBoxPhone.Text = this.dgvSalesmanList.CurrentRow.Cells["Contect"].Value.ToString();
            this.dateTimePickerDob.Text = this.dgvSalesmanList.CurrentRow.Cells["DateofBirth"].Value.ToString();
            this.radioButtonFemale.Text = this.dgvSalesmanList.CurrentRow.Cells["Gender"].Value.ToString();
            this.radioButtonMale.Text = this.dgvSalesmanList.CurrentRow.Cells["Gender"].Value.ToString();
        }
        private void FormSalesmanList_Load(object sender, EventArgs e)
        {

        }

        private void dgvSalesmanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormSalesmanList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
