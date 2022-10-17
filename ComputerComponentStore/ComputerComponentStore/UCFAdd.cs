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
    public partial class UCFAdd : UserControl
    {
        private DataAccess Da { get; set; }
        private string newId;

        public UCFAdd(string s)
        {
            InitializeComponent();
            GenateNewId(s);
            this.Da = new DataAccess();
        }
        private void UCFAdd_Load(object sender, EventArgs e)
        {

        }
        private void GenateNewId(string s)
        {
            string c = s.Substring(s.Length - 5);
            int i = Int32.Parse(c);
            i++;
           
            newId = "c-" + i.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                var sql = @"insert into Component values('4','" + newId + "','" + this.txtProductName.Text + "','" + this.txtModel.Text + "','" + this.txtQuantity.Text + "','" + this.txtUnitPrice.Text + "');";
                int count = this.Da.ExecuteUpdateQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion successfull");
                else
                    MessageBox.Show("Data insertion failed");



            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
