<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="popuppage.aspx.cs" Inherits="ControlGridWebApp.popuppage" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxPopupControl ID="popupGuncelle" runat="server" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="True" ShowFooter="True" Modal="True" Width="400px">
            <ContentCollection>
                <dx:PopupControlContentControl runat="server">
                    <div style="padding: 20px;">
                        <table width="80%">
                            <tr>
                                <td style="padding-bottom: 10px;">Kullanıcı Adı:</td>
                            </tr>
                            <tr>
                                <td><dx:ASPxTextBox ID="editUsername" runat="server" /></td>
                            </tr>
                            <tr>
                                <td style="padding-top: 10px; padding-bottom: 10px;">E-posta:</td>
                            </tr>
                            <tr>
                                <td><dx:ASPxTextBox ID="editEmail" runat="server" /></td>
                            </tr>
                            <tr>
                                <td style="padding-top: 10px; padding-bottom: 10px;">Parola:</td>
                            </tr>
                            <tr>
                                <td><dx:ASPxTextBox ID="editPassword" runat="server" TextMode="Password" /></td>
                            </tr>
                            <tr>
                                <td align="center" style="padding-top: 20px;">
                                    <dx:ASPxButton ID="btnUpdateUser" runat="server" Text="Güncelle" AutoPostBack="True" OnClick="btnUpdateUser_Click" />
                                </td>
                            </tr>
                        </table>
                        <dx:ASPxHiddenField ID="editUserId" runat="server" />
                    </div>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
        <div>
        </div>
    </form>
</body>
</html>
