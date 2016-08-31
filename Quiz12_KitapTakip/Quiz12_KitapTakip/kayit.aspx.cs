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
using System.Web.Services;
namespace Quiz12_KitapTakip
{
    public partial class kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static void Kayit(string ad,string soyad,string mail,string user,string  pass)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kitap"].ConnectionString);
            
            
            SqlDataAdapter adapter = new SqlDataAdapter("insert into tblUye (ad,soyad,mail,kulAd,parola) values(@ad,@soyad,@mail,@kulAd,@parola)", conn);
            adapter.SelectCommand.Parameters.AddWithValue("ad", ad);
            adapter.SelectCommand.Parameters.AddWithValue("soyad", soyad);
            adapter.SelectCommand.Parameters.AddWithValue("mail", mail);
            adapter.SelectCommand.Parameters.AddWithValue("kulAd", user);
            adapter.SelectCommand.Parameters.AddWithValue("parola", pass);
           
            conn.Open();
            adapter.SelectCommand.ExecuteNonQuery();
            conn.Close();
          
           
        }
    }
}