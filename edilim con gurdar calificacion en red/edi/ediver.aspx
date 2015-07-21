<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ediver.aspx.vb" Inherits="edi_ediver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            <iframe id="iframepaginahija" name="iframepaginahija" src="index.html" width="100%" height="800px"></iframe>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox_cookie" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox_iresul" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>

