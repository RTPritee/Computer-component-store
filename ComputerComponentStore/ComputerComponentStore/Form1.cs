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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Id = '" + this.textBoxUserId.Text + "' and Password = '" + this.textBoxPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-8DEA17C;Initial Catalog=project;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter project = new SqlDataAdapter(sqlcom);
            DataSet UserInfo = new DataSet();
            project.Fill(UserInfo);

            if (UserInfo.Tables[0].Rows.Count == 1)
            {
                this.ClearContent();
                this.Hide();
                MessageBox.Show("Login Valid");
                string name = UserInfo.Tables[0].Rows[0][1].ToString();

                if (UserInfo.Tables[0].Rows[0][3].ToString() == "manager")
                {
                    ManagerDashBoard mng = new ManagerDashBoard(this);
                    mng.Show();
                }
                else if (UserInfo.Tables[0].Rows[0][3].ToString() == "salesman")
                {
                    Salesman sal = new Salesman (this);
                    sal.Show();
                }

            }
            else
            {
                MessageBox.Show("Login Invalid");
                this.ClearContent();
            }

            sqlcon.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.textBoxUserId.Clear();
            this.textBoxPassword.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
