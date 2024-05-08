<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 532px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; bottom: 507px" Text="Customer ID" width="78px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 129px; top: 37px; position: absolute"></asp:TextBox>
&nbsp;<p>
            &nbsp;</p>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="Full name"></asp:Label>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 460px; top: 64px; position: absolute" Text="Find" />
        </p>
        <asp:TextBox ID="txtFullName" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 129px; top: 85px; position: absolute; margin-top: 13px" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 16px; top: 157px; position: absolute" Text="Customer Email" width="78px"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 129px; top: 156px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblCustomerPhone" runat="server" style="z-index: 1; left: 10px; top: 217px; position: absolute; width: 78px" Text="Customer Phone Number"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtCustomerPhone" runat="server" style="z-index: 1; left: 129px; top: 218px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 12px; top: 312px; position: absolute" Text="Address" width="78px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 130px; top: 308px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblRegistrationDate" runat="server" style="z-index: 1; left: 7px; top: 364px; position: absolute" Text="Registration Date" width="78px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtRegistrationDate" runat="server" style="z-index: 1; left: 129px; top: 370px; position: absolute" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkEmailOptIn" runat="server" style="z-index: 1; left: 133px; top: 424px; position: absolute" Text="EmailOptIn" width="168px" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 464px; position: absolute; right: 527px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 502px; position: absolute; width: 70px; right: 1500px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" height="29px" style="z-index: 1; left: 155px; top: 501px; position: absolute; width: 70px" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
