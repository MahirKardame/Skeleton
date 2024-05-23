<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 515px; top: 340px; position: absolute" Text="Momentum Motors Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 149px; top: 431px; position: absolute; width: 102px" Text="Customer" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 350px; top: 434px; position: absolute; width: 102px" Text="Orders" />
        <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 542px; top: 437px; position: absolute; width: 102px" Text="Staff" />
        <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 730px; top: 437px; position: absolute; width: 102px" Text="Stock" />
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; left: 963px; top: 438px; position: absolute; width: 102px" Text="Supplier" />
    </form>
</body>
</html>
