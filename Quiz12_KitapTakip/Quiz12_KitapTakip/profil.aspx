<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="profil.aspx.cs" Inherits="Quiz12_KitapTakip.profil" %>
<asp:Content ID="Content2" ContentPlaceHolderID="loginContent" runat="server">
    <ul>
        <li><asp:Label runat="server" ID="lblKisi"></asp:Label></li>
        <li><asp:LinkButton runat="server" ID="btnKisi" Text="Profil" /></li>
         <li>
             <asp:LinkButton Text="Çıkış" runat="server" OnClick="logOut_Click" />
            
         </li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="govdeContent" runat="server" >
    <div id="profil">
    <table id="profilTable" onload="ProfilDoldur()">
       <tr>
           <td class="pTanim">Adı:</td>
           <td>
               <asp:Label id="lblAd" runat="server" /></td>
       </tr>
         <tr>
           <td class="pTanim">Soyadı:</td>
           <td>
               <asp:Label id="lblSoyad" runat="server" /></td>
       </tr>
         <tr>
           <td class="pTanim">Mail:</td>
           <td>
               <asp:Label id="lblMail" runat="server" /></td>
       </tr>
         <tr>
           <td class="pTanim">Üyelik Durumu:</td>
           <td>
               <asp:Label id="lblDurum" runat="server" /></td>
       </tr>
        
    </table>
        </div>
</asp:Content>

