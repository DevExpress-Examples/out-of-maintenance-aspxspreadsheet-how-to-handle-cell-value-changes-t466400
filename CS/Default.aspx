<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxSpreadsheet runat="server" ID="spreadsheet" ClientInstanceName="spreadsheet"
            Height="700px" WorkDirectory="~/App_Data/WorkDirectory" ShowConfirmOnLosingChanges="false" />
    </div>
    </form>
</body>
</html>

