<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmKullanıcılar.aspx.cs" Inherits="ControlGridWebApp.FrmKullanıcılar" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>

<%@ Register Assembly="DevExpress.Web.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<%@ Register assembly="DevExpress.XtraScheduler.v19.1.Core, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraScheduler" tagprefix="cc1" %>



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

    <style type="text/css">
        .auto-style1 {
            width: 951px;
        }

        .dxwschsTimeRuler {
    display: none;
}
        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h2>
                <table class="dxflInternalEditorTable_Office365">
                    <tr>
                        <td class="auto-style1">
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:hazalConnectionString3 %>" DeleteCommand="DELETE FROM [events] WHERE [id] = @id" InsertCommand="INSERT INTO [events] ([enddate], [startday], [event], [notes], [userid], [subject]) VALUES (@enddate, @startday, @event, @notes, @userid, @subject)" SelectCommand="SELECT [id], [enddate], [startday], [event], [notes], [userid], [subject] FROM [events]" UpdateCommand="UPDATE [events] SET [enddate] = @enddate, [startday] = @startday, [event] = @event, [notes] = @notes, [userid] = @userid, [subject] = @subject WHERE [id] = @id">
                                <DeleteParameters>
                                    <asp:Parameter Name="id" Type="Int32" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="enddate" Type="DateTime" />
                                    <asp:Parameter Name="startday" Type="DateTime" />
                                    <asp:Parameter Name="event" Type="String" />
                                    <asp:Parameter Name="notes" Type="String" />
                                    <asp:Parameter Name="userid" Type="Int32" />
                                    <asp:Parameter Name="subject" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="enddate" Type="DateTime" />
                                    <asp:Parameter Name="startday" Type="DateTime" />
                                    <asp:Parameter Name="event" Type="String" />
                                    <asp:Parameter Name="notes" Type="String" />
                                    <asp:Parameter Name="userid" Type="Int32" />
                                    <asp:Parameter Name="subject" Type="String" />
                                    <asp:Parameter Name="id" Type="Int32" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
                            <dxwschs:ASPxScheduler  ID="ASPxScheduler1" runat="server"   Images-Appointment-Recurrence-Height="1000" AppointmentDataSourceID="SqlDataSource3"  ClientIDMode="AutoID" ResourceDataSourceID="SqlDataSource3" Start="2024-07-09" Theme="Office365" EnableCallbackCompression="False" Font-Strikeout="False" ForeColor="Black">
                                <Views>
<DayView ViewSelectorItemAdaptivePriority="2" ShowWorkTimeOnly="True">

    <TimeRulers>
        <cc1:TimeRuler Visible="False" />
    </TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4"></AppointmentDisplayOptions>
</DayView>

<WorkWeekView ViewSelectorItemAdaptivePriority="6" ShowAllAppointmentsAtTimeCells="True" ShowWorkTimeOnly="True">

    <TimeRulers>
<cc1:TimeRuler Visible="False"></cc1:TimeRuler>
</TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4" SnapToCellsMode="Disabled"></AppointmentDisplayOptions>
</WorkWeekView>
                                    <WeekView Enabled="true">
                                    </WeekView>
<MonthView ViewSelectorItemAdaptivePriority="5"></MonthView>

<TimelineView ViewSelectorItemAdaptivePriority="3"></TimelineView>

                                    <FullWeekView Enabled="true">

                                        <TimeRulers>
<cc1:TimeRuler Visible="False"></cc1:TimeRuler>
</TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4"></AppointmentDisplayOptions>
                                    </FullWeekView>

<AgendaView ViewSelectorItemAdaptivePriority="1"></AgendaView>
                                </Views>

<Images>
<Appointment>
<Recurrence Height="1000px"></Recurrence>
</Appointment>
</Images>

                                <OptionsBehavior HighlightSelectionHeaders="True" />
                                <OptionsMenu EnableMenuScrolling="True" />
                                <OptionsView ResourceColorFillArea="ResourceHeader">
                                </OptionsView>
                                <Storage EnableReminders="False" EnableSmartFetch="False" EnableTimeZones="False" TimeZoneId="Turkey Standard Time">
                                    <Appointments AutoRetrieveId="True">
                                        <Mappings AppointmentId="id" Description="notes" End="enddate" ResourceId="event" Start="startday" Subject="subject" Type="userid" />
                                    </Appointments>
                                    <Resources AutoReload="False">
                                        <Mappings Caption="event" ResourceId="id" />
                                    </Resources>
                                </Storage>
                                 
                            </dxwschs:ASPxScheduler>
                        </td>
                        <td>
                            <dxwschs:ASPxDateNavigator ID="ASPxDateNavigator1" runat="server" ClientIDMode="AutoID" MasterControlID="ASPxScheduler1" Width="600px">
                            </dxwschs:ASPxDateNavigator>
                        </td>
                    </tr>
                </table>
                Kullanıcılar</h2>
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

