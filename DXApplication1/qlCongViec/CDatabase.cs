using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlCongViec
{
    class CDatabase
    {
        SqlConnection sqlcnn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string svname = "PCLC3-PC03";
        string dbname = "qlCongViec";
        public CDatabase()
        {
            string cnnstr = "Data source=PCLC3-PC03; database=qlCongViec;Integrated Security = True";
            sqlcnn = new SqlConnection(cnnstr);
        }

        public DataTable Execute(string str)
        {
            da = new SqlDataAdapter(str, sqlcnn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string str)
        {
            SqlCommand sqlcmd = new SqlCommand(str, sqlcnn);
            sqlcnn.Open();
           sqlcmd.ExecuteNonQuery();
            sqlcnn.Close();
        }

        public void Update(string str, DataTable dt)
        {
            da = new SqlDataAdapter(str, sqlcnn);
            SqlCommandBuilder sqlbd = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
