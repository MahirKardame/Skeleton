﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 89px; top: 241px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 299px; position: absolute"></asp:Label>
            <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 206px; width: 254px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 21px; top: 241px; position: absolute" Text="Add" />
        </div>
    </form>
</body>
</html>
