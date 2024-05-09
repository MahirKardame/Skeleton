<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 421px; margin-left: 4440px;">
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 13px; top: 28px; position: absolute" Text="Supplier ID" width="115px"></asp:Label>
            <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 150px; top: 22px; position: absolute" width="128px" OnTextChanged="txtSupplierId_TextChanged"></asp:TextBox>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 13px; top: 108px; position: absolute" Text="Email" width="115px"></asp:Label>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 13px; top: 69px; position: absolute" Text="Name" width="115px"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 148px; position: absolute" Text="Phone Number" width="115px"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 13px; top: 191px; position: absolute" Text="Address" width="115px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 150px; top: 184px; position: absolute" width="128px" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
            <asp:Label ID="lblLastOrderDate" runat="server" style="z-index: 1; left: 13px; top: 232px; position: absolute" Text="Last Ordered Date"></asp:Label>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 166px; top: 268px; position: absolute" Text="Is Available" OnCheckedChanged="chkAvailable_CheckedChanged" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 306px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 187px; top: 346px; position: absolute" Text="Cancel" height="26px" width="60px" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 106px; top: 346px; position: absolute; right: 1312px;" Text="Ok" height="26px" width="60px" />
            <asp:TextBox ID="txtPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 150px; top: 144px; position: absolute" width="128px" OnTextChanged="txtPhoneNumber_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtLastOrderDate" runat="server" height="22px" style="z-index: 1; left: 150px; top: 229px; position: absolute" width="128px" OnTextChanged="txtLastOrderDate_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtSupplierName" runat="server" height="22px" OnTextChanged="txtSupplierName_TextChanged1" style="z-index: 1; left: 150px; top: 64px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtSupplierEmail" runat="server" height="22px" OnTextChanged="txtSupplierEmail_TextChanged" style="z-index: 1; left: 150px; top: 104px; position: absolute" width="128px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 4450px; top: 15px; position: absolute" Text="Button" />
            <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 311px; top: 24px; position: absolute" Text="Find" width="60px" />
        </div>
    </form>
</body>
</html>
