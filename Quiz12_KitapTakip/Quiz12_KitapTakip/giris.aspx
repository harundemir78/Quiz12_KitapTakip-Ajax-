<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="Quiz12_KitapTakip.giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="loginContent" runat="server">
      <ul>
        <li><a href="giris.aspx"> Giriş Yap</a></li>
        <li> <a href="kayit.aspx"> Kayıt Ol</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="govdeContent" runat="server">
    <div id="gir">
        <div id="gir_menu">
            Kullanıcı Adı<br />
            <asp:TextBox ID="txtAd" runat="server" /><br />
            Parola<br />
            <asp:TextBox ID="txtPass" runat="server" /><br />
             <asp:Button ID="btnGir" Text="Giriş Yap" runat="server" OnClick="btnGir_Click"/>
        </div>
   
    </div>

</asp:Content>
