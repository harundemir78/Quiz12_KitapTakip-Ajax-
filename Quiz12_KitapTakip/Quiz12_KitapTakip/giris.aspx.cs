using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz12_KitapTakip
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kitap"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tbluye where kulAd=@ad and parola=@pass ", conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                if (txtAd.Text.Equals(dr["kulAd"].ToString()) && txtPass.Text.Equals(dr["parola"].ToString()))
                {
                    Session["user"] = txtAd.Text;
                    Response.Redirect("profil.aspx");
                }
            }
            dr.Close();
            conn.Close();
        }
    }
}