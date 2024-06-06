<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectcolumn.aspx.cs" Inherits="ControlGridWebApp.selectcolumn" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sayfa Başlığı</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Column Selection</h2>
            <div id="available-columns">
                <!-- List available columns here -->
                <div class="column-item">Id</div>
                <div class="column-item">Kullanıcı Adı</div>
                <div class="column-item">E-posta</div>
                <div class="column-item">Parola</div>
            </div>
            <div id="selected-columns">
                <!-- Selected columns will be displayed here -->
            </div>
        </div>
    </form>
</body>
</html>
