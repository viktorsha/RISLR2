<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebApplicationForm.aspx.cs" Inherits="WebApplication2._1.WebApplicationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Marks</title>
    <link rel="shortcut icon" type="image/png" href="Source/img/pen.png" />
    <link rel="stylesheet" href="Source/css/styles.css" /> 
</head>
<body>
    <form id="form1" runat="server">
        <div class="text">
        <h1 >Marks web service</h1>
        <p>Enter a file name to receive XML view</p>
        <label>
            Enter file name
            <asp:TextBox ID="inputField" runat="server"></asp:TextBox>
        </label>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="420px" TextMode="MultiLine" Width="731px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
