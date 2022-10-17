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
    public partial class UCFUpdate : UserControl
    {
        private DataAccess Da { get; set; }
        private string productId;
        public UCFUpdate(string s)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            productId = s;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                var query = "select * from Component where Id = '" + productId + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //label1.Text = query;
                    //update
                    var sql = @"UPDATE Component
                                SET  Components = '" + this.txtProductName.Text + @"', 
                                Model = '" + this.txtModel.Text + @"',
                                Quantity = '" + this.txtQuantity.Text + @"',
                                UnitPrice = '" + this.txtUnitPrice.Text + @"'
                                WHERE Id = '" + this.productId + "';";
                    int count = this.Da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
