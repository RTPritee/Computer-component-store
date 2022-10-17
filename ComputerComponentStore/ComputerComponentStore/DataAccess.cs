using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerComponentStore
{
    public class DataAccess
    {
        private SqlConnection sqlcon; 
        public SqlConnection Sqlcon 
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
       // private DataTable Da;
       

        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()  
        {

            this.Sqlcon = new SqlConnection("Data Source=DESKTOP-8DEA17C;Initial Catalog=project;Integrated Security=True");
            Sqlcon.Open();
        }

        private void QueryText(string query) 
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon); 
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);  
            this.Sda = new SqlDataAdapter(this.Sqlcom); 
            this.Ds = new DataSet(); 
            this.Sda.Fill(this.Ds);
            return Ds; 
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
        //private void AutoGenarateId()
        //{
           // var sql = "select Id from SalesmanList order by Id desc";
           // DataTable dt = this.ExecuteQueryTable(sql);

            //string oldId = dt.Rows[0]["Id"].ToString();
            //string[] temp = oldId.Split('-');
            //int num = Convert.ToInt32(temp[1]);
            //string newId = "s" + (++num).ToString("d3");

        //}
    }
}