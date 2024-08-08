<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="FrmKullanıcılar.aspx.cs" Inherits="ControlGridWebApp.FrmKullanıcılar" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<%@ Register Assembly="DevExpress.XtraScheduler.v19.1.Core, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraScheduler" TagPrefix="cc1" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Kullanıcılar</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">

    <script>
        $(document).ready(function () {
            $(".column-item").draggable({
                revert: "invalid",
                helper: "clone"
            });

            $("#Grid").droppable({
                accept: ".column-item",
                drop: function (event, ui) {
                    var columnName = ui.helper.text().trim();
                    AddColumnToGrid(columnName);
                    AddFieldToPivotGrid(columnName);
                }
            });

        });

        function AddColumnToGrid(columnName) {
            __doPostBack('AddColumn', columnName);
        }
    </script>
    <script type="text/javascript">
        function OnButtonClick(s, e) {
            if (Grid.IsCustomizationWindowVisible())
                Grid.HideCustomizationWindow();
            else
                Grid.ShowCustomizationWindow();
        }
        function OnContextMenuItemClick(s, e) {
            if (e.item.name == "Kaydet") {
                e.processOnServer = true;
                e.usePostBack = true;
            }
        }

    </script>
    <style type="text/css">
        .auto-style1 {
            width: 951px;
        }

        .dxwschsTimeRuler {
            display: none;
        }

        .auto-style2 {
            width: 100%;
            height: 544px;
        }

        body {
            font-family: Arial, sans-serif;
        }

        .draggable-columns {
            width: 300px;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
            display: flex;
            flex-direction: column;
            gap: 10px;
        }

        .column-item {
            padding: 10px 15px;
            border: 1px solid #007bff;
            border-radius: 5px;
            background-color: #ffffff;
            color: #333;
            cursor: move;
            font-size: 14px;
            text-align: center;
            transition: background-color 0.3s, box-shadow 0.3s;
        }

            .column-item:hover {
                background-color: #e9ecef;
                box-shadow: 0 4px 8px rgba(0,0,0,0.2);
            }

            .column-item:active {
                background-color: #dee2e6;
                box-shadow: 0 2px 4px rgba(0,0,0,0.1);
            }
    </style>
    <asp:PlaceHolder runat="server" ID="themeStylesheetPlaceHolder"></asp:PlaceHolder>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server">

        <contenttemplate>
            <fieldset>
                <asp:DropDownList ID="DropDownList1" runat="server"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Text="Material" Value="Material" />
                    <asp:ListItem Text="Office2010Black" Value="Office2010Black" />
                    <asp:ListItem Text="Metropolis" Value="Metropolis" />
                    <asp:ListItem Text="Glass" Value="Glass" />
                    <asp:ListItem Text="MetropolisBlue" Value="MetropolisBlue" />
                    <asp:ListItem Text="Office2003Blue" Value="Office2003Blue" />
                    <asp:ListItem Text="Office2003Olive" Value="Office2003Olive" />
                    <asp:ListItem Text="IOS" Value="IOS" />
                    <asp:ListItem Text="MaterialCompact" Value="MaterialCompact" />
                     <asp:ListItem Text="Moderno" Value="Moderno" />
                     <asp:ListItem Text="SoftOrange" Value="SoftOrange" />
                    <asp:ListItem Text="Youthful" Value="Youthful" />
                    <asp:ListItem Text="PlasticBlue" Value="PlasticBlue" />
                    <asp:ListItem Text="Office2010Silver" Value="Office2010Silver" />
                </asp:DropDownList>
            </fieldset>
        </contenttemplate>

        <div id="available-columns" class="draggable-columns">
            <div class="column-item">Id</div>
            <div class="column-item">username</div>
            <div class="column-item">email</div>
            <div class="column-item">password</div>
            <div class="column-item">events</div>
        </div>
          <dx:ASPxPivotGrid ID="PivotGrid" runat="server"></dx:ASPxPivotGrid>
        <div class="card-body">
            <dx:ASPxButton ID="btnFirstGrid" runat="server" Image-IconID="actions_changeview_32x32devav" OnClick="btnFirstGrid_Click" AutoPostBack="true"></dx:ASPxButton>
            <div id="selected-columns" class="droppable-columns">
                    <dx:ASPxGridView ID="Grid" runat="server" KeyFieldName="Id" ClientInstanceName="Grid" OnFillContextMenuItems="grid_FillContextMenuItems" OnContextMenuItemVisibility="grid_ContextMenuItemVisibility" OnContextMenuItemClick="grid_ContextMenuItemClick" Width="50%" AutoGenerateColumns="False" EnableTheming="true" Theme="">
                       <SettingsBehavior ConfirmDelete="true" EnableCustomizationWindow="true" EnableRowHotTrack="true" ColumnResizeMode="Control" />
                        <%--    <Templates>
                                <EmptyDataRow>
                                    <div id="gridDropZone" style="width: 100%; height: 20px; border: 1px solid #ccc; background-color: #f0f0f0; text-align: center; line-height: 20px;">Drop columns here</div>
                                </EmptyDataRow>
                            </Templates>--%>
                        <ClientSideEvents ContextMenuItemClick="OnContextMenuItemClick"/>
                        <SettingsContextMenu Enabled="true">
                            <RowMenuItemVisibility NewRow="false" EditRow="false" Refresh="true" DeleteRow="false">
                                <ExportMenu Visible="false" />
                            </RowMenuItemVisibility>
                        </SettingsContextMenu>
                        <SettingsPager Visible="False">
                        </SettingsPager>
                        <Settings ShowFooter="true" ShowGroupPanel="true" ShowGroupFooter="VisibleIfExpanded" />
                        <SettingsBehavior EnableCustomizationWindow="true" />
                        <SettingsPopup>
                            <CustomizationWindow PopupAnimationType="Slide" />
                        </SettingsPopup>
                        <Columns>
                            <dx:GridViewDataColumn Caption="" VisibleIndex="0">
                                <DataItemTemplate>
                                    <asp:LinkButton ID="btnNew" runat="server" AutoPostBack="true" OnClientClick="popupNewUser.Show()"> <i class="fa fa-plus" style="font-size:28px;color:black"></i>
                                    </asp:LinkButton>
                                    <asp:LinkButton ID="btnGuncelle" runat="server" FixedStyle="Left" OnClientClick=" popupGuncelle.Show()" AutoPostBack="true"><%--<i class="fa fa-edit"--%> <i class="fa fa-refresh fa-spin" style="font-size:28px;color:black"></i>
                                    </asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" FixedStyle="Left" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" AutoPostBack="true">
                                        <i class="fa fa-trash-o" style="font-size:28px;color:black"></i>
                                    </asp:LinkButton>
                                    <asp:LinkButton ID="btnYetki" runat="server" FixedStyle="Left" CommandArgument='<%# Eval("Id") %>' OnClick="btnYetki_Click" AutoPostBack="true">
                                        <i class="fa fa-cog fa-spin" style="font-size:28px;color:black"></i>
                                    </asp:LinkButton>
                                </DataItemTemplate>
                            </dx:GridViewDataColumn>
                        </Columns>
                         <Settings HorizontalScrollBarMode="Auto" />
                        <Styles>
                            <Header CssClass="custom-grid-header" />
                            <Row CssClass="custom-grid-row" />
                            <AlternatingRow CssClass="custom-grid-row-alternating" />
                            <FocusedRow BackColor="#e47922" />
                        </Styles>
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
                                    <td>
                                        <dx:ASPxTextBox ID="editUsername" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 10px; padding-bottom: 10px;">E-posta:</td>
                                </tr>
                                <tr>
                                    <td>
                                        <dx:ASPxTextBox ID="editEmail" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 10px; padding-bottom: 10px;">Parola:</td>
                                </tr>
                                <tr>
                                    <td>
                                        <dx:ASPxTextBox ID="editPassword" runat="server" TextMode="Password" />
                                    </td>
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
        </div>
    </form>
</body>
</html>

