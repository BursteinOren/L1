<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="L1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ForeColor="YellowGreen" BackColor="BlueViolet"></asp:Calendar>
        <br />
        <br />
        <asp:Label ID="lblCalendar1" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnOK" runat="server" Text="OK" />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server"   />
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Upload" OnClick="btnSave_Click"  />
        
    </div>
    </form>
</body>
</html>
