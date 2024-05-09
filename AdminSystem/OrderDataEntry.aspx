<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 395px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 157px; top: 16px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPaid" runat="server" style="z-index: 1; left: 91px; top: 63px; position: absolute" Text="Paid" />
        <asp:Label ID="lblDatePlaced" runat="server" style="z-index: 1; left: 82px; top: 117px; position: absolute" Text="Date Placed"></asp:Label>
        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; left: 70px; top: 171px; position: absolute" Text="Delivery Type"></asp:Label>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 86px; top: 18px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="lblStaffNote" runat="server" style="z-index: 1; left: 86px; top: 220px; position: absolute" Text="Staff Note"></asp:Label>
        <asp:Label ID="lblCustomerNote" runat="server" style="z-index: 1; left: 93px; top: 269px; position: absolute" Text="Customer Note"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 97px; top: 313px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtDatePlaced" runat="server" style="z-index: 1; left: 167px; top: 118px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryType" runat="server" style="z-index: 1; left: 169px; top: 171px; position: absolute"></asp:TextBox>
        <asp:TextBox runat="server" style="z-index: 1; left: 162px; top: 222px; position: absolute" ID="txtStaffNote"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNote" runat="server" style="z-index: 1; left: 199px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 147px; top: 313px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 429px; position: absolute"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 102px; top: 364px; position: absolute; width: 98px" Text="Submit" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 367px; top: 26px; position: absolute" Text="Find" />
    </form>
</body>
</html>
