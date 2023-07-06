using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Product.Models
{
    public class ProductSerivice
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString.ToString();

        public List<DeltawareProduct> GetProduct()
        {
            List<DeltawareProduct> dp = new List<DeltawareProduct>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from DeltawareProduct", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                DeltawareProduct dp1 = new DeltawareProduct();
                dp1.ProductId = Convert.ToInt32(dr.GetValue(0).ToString());
                dp1.Name = (dr.GetValue(1).ToString());
                dp1.Description = (dr.GetValue(2).ToString());

                dp.Add(dp1);
            }

            return dp;

             

        }
    }
     
}