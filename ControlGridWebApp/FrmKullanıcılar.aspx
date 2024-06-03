<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmKullanıcılar.aspx.cs" Inherits="ControlGridWebApp.FrmKullanıcılar" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sayfa Başlığı</title>
</head>
<body>
    <form id="form1" runat="server">
      
        <dx:ASPxGridView ID="Grid" runat="server" KeyFieldName="Id" SettingsDataSecurity-AllowEdit="True" AutoGenerateColumns="False" Width="100%" EnableTheming="True" Theme="Office365">
    <ClientSideEvents ContextMenu="function(s, e) { gridPopupMenu.ShowAtPos(e.htmlEvent.clientX, e.htmlEvent.clientY); e.htmlEvent.preventDefault(); }" />
    <SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" ColumnResizeMode="Control" AllowFocusedRow="true" EnableCustomizationWindow="true" ConfirmDelete="true" />
    <SettingsDataSecurity AllowEdit="False" AllowInsert="False" />
    <SettingsText EmptyHeaders=" " EmptyDataRow=" " />
    <Columns>
        <dx:GridViewDataColumn Caption="" VisibleIndex="0" Width="60">
            <DataItemTemplate>
                <dx:ASPxButton ID="btnNew" runat="server" Image-IconID="actions_add_32x32office2013" AutoPostBack="false">
                    <ClientSideEvents Click="function() { popupNewUser.Show(); }" />
                </dx:ASPxButton>
            </DataItemTemplate>
        </dx:GridViewDataColumn>
        <dx:GridViewDataColumn Caption="" VisibleIndex="1" Width="60">
    <DataItemTemplate>
        <dx:ASPxButton ID="btnguncelle" runat="server" Image-IconID="actions_edit_32x32devav"  CommandArgument='<%# Eval("Id") %>' OnClick="btnGuncellePage_Click" AutoPostBack="false">
        </dx:ASPxButton>
    </DataItemTemplate>
</dx:GridViewDataColumn>
        <dx:GridViewDataColumn Caption="" VisibleIndex="2" Width="60">
            <DataItemTemplate>
                <dx:ASPxButton ID="btnDelete" runat="server" Image-IconID="actions_cancel_32x32" AutoPostBack="true" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" />
            </DataItemTemplate>
        </dx:GridViewDataColumn>
         <dx:GridViewDataColumn Caption="" VisibleIndex="2" Width="60">
            <DataItemTemplate>
                <dx:ASPxButton ID="btnYetki" runat="server" Image-IconID="xaf_modeleditor_settings_svg_32x32" AutoPostBack="true" CommandArgument='<%# Eval("Id") %>' OnClick="btnYetki_Click" />
            </DataItemTemplate>
        </dx:GridViewDataColumn>
        <dx:GridViewDataTextColumn FieldName="Id" Caption="Id" VisibleIndex="3" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="username" Caption="Kullanıcı Adı" VisibleIndex="4" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="email" Caption="E-posta" VisibleIndex="5" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="password" Caption="Parola" VisibleIndex="6" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
        </dx:GridViewDataTextColumn>
    </Columns>
    <Styles>
        <Header CssClass="custom-grid-header" />
        <Row CssClass="custom-grid-row" />
        <AlternatingRow CssClass="custom-grid-row-alternating" />
        <FocusedRow BackColor="#e47922" />
    </Styles>
</dx:ASPxGridView>
        <dx:ASPxPopupControl ID="popupNewUser" runat="server" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="True" ShowFooter="True" Modal="True" Width="400px">
            <ContentCollection>
                <dx:PopupControlContentControl runat="server">
                    <table width="400">
                        <tr>
                            <td>Kullanıcı Adı:</td>
                            <td>
                                <dx:ASPxTextBox ID="txtUsername" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>E-posta:</td>
                            <td>
                                <dx:ASPxTextBox ID="txtEmail" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Parola:</td>
                            <td>
                                <dx:ASPxTextBox ID="txtPassword" runat="server" TextMode="Password" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <dx:ASPxButton ID="btnSaveUser" runat="server" Text="Kaydet" AutoPostBack="True" OnClick="btnSaveUser_Click" />
                            </td>
                        </tr>
                    </table>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
<dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" ClientInstanceName="gridPopupMenu" OnItemClick="gridPopupMenu_ItemClick">
    <Items>
        <dx:MenuItem Name="SaveItem" Text="Kaydet" />
    </Items>
</dx:ASPxPopupMenu>
    </form>
</body>
</html>

