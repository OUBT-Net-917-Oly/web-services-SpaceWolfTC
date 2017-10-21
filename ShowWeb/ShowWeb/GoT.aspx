<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoT.aspx.cs" Inherits="SimpsonsWeb.GoT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thrones</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Game of Thrones Web Client</h1>
        <h2 class="heading">
            <asp:Label ID="lblgotMessage" runat="server" Text="Message"></asp:Label>
        </h2>
        <div class="content">
            <asp:Button ID="btnGetAll" runat="server" Text="Get All" OnClick="btnGetAll_Click" /><br />
            <asp:Label ID="lblgotCharacter" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <div>
            LastName: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnFindByLast" runat="server" Text="Find by Last Name" OnClick="btnFindByLast_Click" /> <br />
            <asp:Label ID="lblgotLastMatch" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <div>
            FirstName: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnFindByFirst" runat="server" Text="Find by First Name" OnClick="btnFindByFirst_Click" /> <br />
            <asp:Label ID="lblgotFirstMatch" runat="server" Text=""></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>

