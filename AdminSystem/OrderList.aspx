<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffNote" runat="server" style="z-index: 1; left: 97px; top: 472px; position: absolute" Text="Staff Note:"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 182px; top: 473px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 103px; top: 508px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 235px; top: 509px; position: absolute" Text="Clear Filter" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 86px; top: 18px; position: absolute; height: 399px; width: 330px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index : 1;" OnClick="btnAdd_Click" Text="Add" position="absolute" />
        </div>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index : 1;" Height="25px" OnClick="btnEdit_Click" Text="Edit" position="absolute" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 335px; top: 424px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
