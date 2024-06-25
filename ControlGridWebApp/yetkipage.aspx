<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yetkipage.aspx.cs" Inherits="ControlGridWebApp.yetkipage" %>
<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="GridYetki" runat="server" KeyFieldName="Id" AutoGenerateColumns="False" AutoPostBack="true" Width="100%">
                <Columns>
                    <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="Id" Caption="Id" VisibleIndex="2" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="code" Caption="Code" VisibleIndex="3" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="menuname" Caption="Menu Name" VisibleIndex="4" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>
            <asp:Button ID="btnYetkiVer" runat="server" Text="Yetki Ver" OnClick="btnYetkiVer_Click" />
            <asp:Button ID="btnYetkiKaldir" runat="server" Text="Yetki Kaldır" OnClick="btnYetkiKaldir_Click" />
        </div>
    </form>
</body>
</html>
