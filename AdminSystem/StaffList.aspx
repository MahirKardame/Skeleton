<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStafflist" runat="server" style="z-index: 1; left: 22px; top: 15px; position: absolute; height: 285px; width: 315px"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" style="z-index: 1; left: 22px; top: 334px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 91px; top: 334px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 391px; position: absolute"></asp:Label>
    </form>
</body>
</html>
