﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffLoginPage" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Staff Login Page"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 62px; top: 179px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 196px; top: 122px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 196px; top: 179px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 87px; top: 234px; position: absolute; right: 1228px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 262px; top: 234px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 62px; top: 122px; position: absolute; right: 1224px;" Text="UserName:"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 413px; top: 172px; position: absolute"></asp:Label>
    </form>
</body>
</html>
