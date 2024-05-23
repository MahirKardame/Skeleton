<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 418px;
            margin-bottom: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 357px">
            <asp:ListBox ID="lstStockList" runat="server"  style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 360px; width: 376px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-top: 22px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 24px" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
