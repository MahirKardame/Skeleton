<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" aria-busy="False">
        <div>
        </div>
        <p>
            <asp:Label ID="lblCarID" runat="server" style="z-index: 1; left: 10px; top: 32px; position: absolute" Text="Car ID" width="111px"></asp:Label>
            <asp:TextBox ID="txtCarID" runat="server" style="z-index: 1; left: 130px; top: 32px; position: absolute" width="116px"></asp:TextBox>
            <asp:Label ID="lblTotalStock" runat="server" style="z-index: 1; left: 10px; top: 58px; position: absolute" Text="Total Stock" width="111px"></asp:Label>
            <asp:TextBox ID="txtCarBrand" runat="server" style="z-index: 1; left: 130px; top: 141px; position: absolute" width="116px"></asp:TextBox>
            <asp:TextBox ID="txtTotalStock" runat="server" style="z-index: 1; left: 130px; top: 58px; position: absolute" width="116px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 10px; top: 84px; position: absolute" Text="Car Model" width="111px"></asp:Label>
            <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 130px; top: 85px; position: absolute" width="116px"></asp:TextBox>
            <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 130px; top: 113px; position: absolute" width="116px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 10px; top: 115px; position: absolute" Text="Car Colour" width="111px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCarBrand" runat="server" style="z-index: 1; left: 10px; top: 144px; position: absolute" Text="Car Brand" width="111px"></asp:Label>
            <asp:TextBox ID="txtStockArriveDate" runat="server" style="z-index: 1; top: 176px; position: absolute; left: 130px" width="116px"></asp:TextBox>
        </p>
        <asp:Label ID="lblStockArriveDate" runat="server" style="z-index: 1; left: 10px; top: 178px; position: absolute" Text="Stock Arrive Date"></asp:Label>
        <asp:CheckBox ID="chkStockAvailable" runat="server" style="z-index: 1; left: 130px; top: 208px; position: absolute" Text="Stock Available" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="[Error]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 53px; top: 300px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
