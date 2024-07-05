<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmKullanıcılar.aspx.cs" Inherits="ControlGridWebApp.FrmKullanıcılar" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Kullanıcılar</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function () {
            $(".column-item").draggable({
                revert: "invalid",
                helper: "clone"
            });

            $("#Grid").droppable({
                drop: function (event, ui) {
                    var columnName = ui.draggable.text().trim();
                    AddColumnToGrid(columnName); 
                }
            });
        });
      
        function AddColumnToGrid(columnName) {
            __doPostBack('AddColumn', columnName);
        }
    </script>
<script type="text/javascript">

    function passDateValue(CtlID, DateValue) {
        window.opener.document.getElementById(CtlID).value = DateValue;
        window.close();
    }

</script>  

</head>
<body>
    <form id="form1" runat="server">
      
         <asp:Calendar ID="Calendar1" runat="server"   Font-Names="Verdana"  OnDayRender="Calendar1_DayRender"
BackColor="White"   BorderColor="Black"   BorderStyle="Solid"   CellSpacing="1"   Font-Size="9pt"
ForeColor="Black"   Height="250px"   NextPrevFormat="ShortMonth">
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TodayDayStyle BackColor="#999999" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <DayStyle BackColor="#CCCCCC" Height="50px" Width="100px" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
</asp:Calendar>
        <asp:ListBox ID="lstSelectedDates" runat="server" SelectionMode="Multiple"></asp:ListBox>
<br />
        <asp:Button ID="btnApplySelection" runat="server" Text="Seçili Günleri Uygula" OnClick="btnApplySelection_Click" />

        <div>
            
            <h2>Kullanıcılar</h2>
            <div id="available-columns" class="draggable-columns">
                <div class="column-item">Id</div>
                <div class="column-item">username</div>
                <div class="column-item">email</div>
                <div class="column-item">password</div>
            </div>
            <dx:ASPxButton  ID="btnFirstGrid" runat="server" Image-IconID="actions_changeview_32x32devav"  OnClick="btnFirstGrid_Click"></dx:ASPxButton>

            <div id="selected-columns" class="droppable-columns">
                <dx:ASPxGridView ID="Grid" runat="server" KeyFieldName="Id" ClientInstanceName="Grid" SettingsDataSecurity-AllowEdit="True" AutoGenerateColumns="False" Width="100%" EnableTheming="True" Theme="Office365">
                    <ClientSideEvents ContextMenu="function(s, e) { gridPopupMenu.ShowAtPos(e.htmlEvent.clientX, e.htmlEvent.clientY); e.htmlEvent.preventDefault(); }" />
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" ColumnResizeMode="Control" AllowFocusedRow="true" EnableCustomizationWindow="true" ConfirmDelete="true" />
                    <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False" />
                    <SettingsText EmptyHeaders=" " EmptyDataRow=" " />
                    <Columns>
                        <dx:GridViewDataColumn Caption="" VisibleIndex="0" Width="60">
                            <DataItemTemplate>
                                <dx:ASPxButton ID="btnNew" runat="server" FixedStyle="Left" Image-IconID="actions_add_32x32office2013" AutoPostBack="true">
                                    <ClientSideEvents Click="function() { popupNewUser.Show(); }" />
                                </dx:ASPxButton>
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="" VisibleIndex="1" Width="60">
                            <DataItemTemplate>
                                <dx:ASPxButton ID="btnNew" runat="server" Image-IconID="actions_edit_32x32devav" AutoPostBack="true">
                                    <ClientSideEvents Click="function() { popupGuncelle.Show(); }" />
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
                <dx:ASPxButton ID="btnYetki" runat="server" Image-IconID="xaf_modeleditor_settings_svg_32x32" CommandArgument='<%# Eval("Id") %>' OnClick="btnYetki_Click" />
            </DataItemTemplate>
        </dx:GridViewDataColumn>
                      <%--  <dx:GridViewDataTextColumn FieldName="Id" Caption="Id" VisibleIndex="3" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
<HeaderStyle CssClass="custom-grid-header"></HeaderStyle>

<CellStyle CssClass="custom-grid-row"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="username" Caption="Kullanıcı Adı" VisibleIndex="4" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
<HeaderStyle CssClass="custom-grid-header"></HeaderStyle>

<CellStyle CssClass="custom-grid-row"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="email" Caption="E-posta" VisibleIndex="5" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
<HeaderStyle CssClass="custom-grid-header"></HeaderStyle>

<CellStyle CssClass="custom-grid-row"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="password" Caption="Parola" VisibleIndex="6" HeaderStyle-CssClass="custom-grid-header" CellStyle-CssClass="custom-grid-row">
<HeaderStyle CssClass="custom-grid-header"></HeaderStyle>

<CellStyle CssClass="custom-grid-row"></CellStyle>
                        </dx:GridViewDataTextColumn>--%>
                    </Columns>
                    <Styles>
                        <Header CssClass="custom-grid-header" />
                        <Row CssClass="custom-grid-row" />
                        <AlternatingRow CssClass="custom-grid-row-alternating" />
                        <FocusedRow BackColor="#e47922" />
                    </Styles>
                    <Templates>
                        <EmptyDataRow>
                            <div id="gridDropZone" style="width: 100%; height: 20px; border: 1px solid #ccc; background-color: #f0f0f0; text-align: center; line-height: 20px;">Drop columns here</div>
                        </EmptyDataRow>
                    </Templates>
                </dx:ASPxGridView>
            </div>
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
                                    <dx:ASPxButton ID="btnUpdateUser" runat="server" Text="Güncelle" AutoPostBack="True" OnClick="btnGuncellePage_Click" />
                                </td>
                            </tr>
                        </table>
                        <dx:ASPxHiddenField ID="editUserId" runat="server" />
                    </div>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
            <dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" ClientInstanceName="gridPopupMenu" OnItemClick="gridPopupMenu_ItemClick" Theme="iOS">
                <Items>
                    <dx:MenuItem Name="SaveItem" Text="Kaydet" />
                </Items>
                <Items>
                    <dx:MenuItem Name="RemoveColumn" Text="Seçili sütunu kaldır" />
                </Items>
            </dx:ASPxPopupMenu>
        </div>
    </form>
</body>
</html>

