<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="kayit.aspx.cs" Inherits="Quiz12_KitapTakip.kayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="loginContent" runat="server">
  <ul>
        <li><a href="giris.aspx"> Giriş Yap</a></li>
        <li> <a href="kayit.aspx"> Kayıt Ol</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="govdeContent" runat="server">
    <div>
        <table id="profil" style="border:thin 1px">
            <tr><td class="pTanim"> Adı:</td><td><input id="k_txtAd" type="text" /></td></tr>
            <tr><td class="pTanim"> Soyadı:</td><td><input id="k_txtSoyad" type="text" /></td></tr>
            <tr><td class="pTanim"> Mail:</td><td><input id="k_txtMail" type="text" /></td></tr>
            <tr><td class="pTanim"> Kullanıcı Adı:</td><td><input id="k_txtKulAd" type="text" /></td></tr>
            <tr><td class="pTanim"> Parola:</td><td><input id="k_txtParola" type="text" /></td></tr>
            <tr><td class="pTanim"> Parola(Tekrar):</td><td><input id="k_txtParola2" type="text" /></td></tr>
            <tr><td colspan="2"><input id="btnKayit" type="button" value="Kayıt Ol" onclick="kayit()" /></td></tr>
        </table>
    </div>
</asp:Content>

