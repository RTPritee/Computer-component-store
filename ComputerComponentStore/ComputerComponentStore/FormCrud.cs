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
    public partial class FormCrud : MetroForm
    {
        private DataAccess Da { get; set; }
        private FormOperation Ol { get; set; }
        public FormCrud(int x, string s)
        {
            InitializeComponent();
            UserControlChange(x, s);
        }
        public FormCrud(FormOperation m1, int x, string s) : this(x, s)
        {
            this.Ol = m1;

        }

        private void FormCrud_Load(object sender, EventArgs e)
        {

        }
        private void UserControlChange(int x, string s)
        {
            switch (x)
            {
                case 1:
                    UCFAdd AF = new UCFAdd(s);
                    pnlCrud.Controls.Add(AF);

                    break;

                case 2:
                    UCFDelete DF = new UCFDelete();
                    pnlCrud.Controls.Add(DF);


                    break;

                case 3:
                    UCFUpdate EF = new UCFUpdate(s);
                    pnlCrud.Controls.Add(EF);

                    break;

                    /*case 4:
                        UserForm UF = new UserForm();
                        pnlCrud.Controls.Add(UF);
                        break;*/


            }
        }
        private void CrudForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show("Application Clossing?", "Exit!");
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Ol.Show();
            this.Hide();
        }
    }
}
