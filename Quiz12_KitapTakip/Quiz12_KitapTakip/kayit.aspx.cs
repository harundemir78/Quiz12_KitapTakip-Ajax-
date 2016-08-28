using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace Quiz12_KitapTakip
{
    public partial class kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void Kayit(string ad,string soyad,string mail,string user,string  pass)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kitap"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into tblUye (ad,soyad,mail,durum,kulAd,parola) values(@ad,@soyad,@mail,@kulAd,@parola)", conn);
            cmd.Parameters.AddWithValue("@ad",ad);
            cmd.Parameters.AddWithValue("@soyad", soyad);
            cmd.Parameters.AddWithValue("@mail",mail);
            cmd.Parameters.AddWithValue("@kulAd",user);
            cmd.Parameters.AddWithValue("@parola",pass);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
          
           
        }
    }
}