using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Quiz12_KitapTakip
{
    public partial class profil : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            lblKisi.Text = Session["user"].ToString() ;
           string kulAd=Session["user"].ToString();
            if (kulAd.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kitap"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select ad,soyad,mail,durum from tbluye where kulAd=@ad ", conn);
                cmd.Parameters.AddWithValue("@ad", kulAd.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    lblAd.Text = item[0].ToString();
                    lblSoyad.Text = item[1].ToString();
                    lblMail.Text = item[2].ToString();
                    lblDurum.Text = item[3].ToString();
                }
                
               
            }
          
        }
      
        protected void logOut_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }
    }
}