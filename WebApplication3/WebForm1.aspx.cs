using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            byte[] imgData = FileUpload1.FileBytes;
            Session["img"] = imgData;
            SqlCommand cmd = new SqlCommand("Insert into Prduct(ProductName,ProductPrice,ProductImage,ProductDesc) values(@ProductName,@ProductPrice,@ProductImage,@ProductDesc)", con);
            cmd.Parameters.AddWithValue("@ProductName", productname.Text);
            cmd.Parameters.AddWithValue("@ProductPrice", productprice.Text);
            cmd.Parameters.AddWithValue("@ProductImage", imgData);
            cmd.Parameters.AddWithValue("@ProductDesc", productdesc.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            Response.Redirect("ShowImage.aspx");
            con.Close();
        }
    }
}