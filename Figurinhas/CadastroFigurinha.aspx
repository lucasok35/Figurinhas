<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFigurinha.aspx.cs" Inherits="Figurinhas.CadastroFigurinha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cadastro de Figurinha</h2>
        </div>
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição:"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescricao" runat="server" Width="290px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAno" runat="server" Text="Ano:"></asp:Label>
        <br />
        <asp:TextBox ID="txtAno" runat="server" Width="83px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </form>
</body>
</html>
