<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ws_Agroinge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AGROINGE CONSULTING</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="SIMULADOR SCADA AGROINGE">
            <div id="header">
                <h1>SIMULADOR SCADA AGROINGE</h1>
            </div>
            <div>
                <asp:Label runat="server" Text="Barril Fermentación 1" Font-Bold="True" Font-Names="Roboto" Font-Italic="False" Font-Overline="False" Font-Size="14" Font-Strikeout="False" TabIndex="0" BorderStyle="None"></asp:Label>
                <br>
                <br />
            </div>
            <div>
                <asp:Label runat="server" Text="Sensores:" Font-Size="12" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                <br>
                <br />
            </div>
            <div>
                <asp:Label runat="server" Text="Temperatura:" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                <asp:TextBox runat="server" Height="20" Width="50"></asp:TextBox>
                <asp:Label runat="server" Text="ºC" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" Text="Presión:" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                <asp:TextBox runat="server" Height="20" Width="50"></asp:TextBox>
                <asp:Label runat="server" Text="bar" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" Text="Nivel:" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                <asp:TextBox runat="server" Height="20" Width="50"></asp:TextBox>
                <asp:Label runat="server" Text="%" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
            </div>
             <div>
                <asp:Label runat="server" Text="pH:" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                <asp:TextBox runat="server" Height="20" Width="50"></asp:TextBox>
                <asp:Label runat="server" Text="pH" Font-Size="10" Font-Strikeout="False" Font-Names="Roboto"></asp:Label>
                 <br>
                 <br />
            </div>
            <div>
                <asp:Button runat="server" Text="Guardar" CommandName="btnGuardar" ID="btnGuardarCambios" OnClientClick="btnGuardar" />
                <br>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Logs: " Font-Italic="True" Font-Names="Roboto" Font-Size="6"></asp:Label>
                <br>
                <br />
                <asp:TextBox ID="TextBoxError" runat="server" Font-Italic="True" Font-Names="Roboto" Font-Size="6" Width="100" Height="15" ReadOnly="True" Rows="15" Wrap="True" AutoPostBack="False" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>


