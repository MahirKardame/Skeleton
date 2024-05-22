<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 15px; top: 13px; position: absolute; height: 393px; width: 446px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 32px; top: 446px; position: absolute" Text="Add" height="26px" width="55px" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 204px; top: 446px; position: absolute" Text="Edit" height="26px" width="55px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 636px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 388px; top: 443px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 24px; top: 573px; position: absolute" Text="Apply Filter" width="95px" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 159px; top: 572px; position: absolute" Text="Clear Filter" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 155px; top: 527px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 23px; top: 527px; position: absolute" Text="Enter a Full Name"></asp:Label>
    </form>
</body>
</html>
