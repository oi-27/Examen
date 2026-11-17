<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Examen.CapaPresentacion.Menu" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menú Principal</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 50px; text-align: center; }
        .menu-container { margin-top: 30px; }
        .btn { padding: 15px 30px; font-size: 16px; margin: 10px; cursor: pointer; background-color: #007bff; color: white; border: none; border-radius: 5px; text-decoration: none; display: inline-block; }
        .btn:hover { background-color: #0056b3; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sistema de Gestión - Menú Principal</h1>
            <div class="menu-container">
                <asp:HyperLink ID="lnkEquipos" runat="server" NavigateUrl="~/CapaPresentacion/Equipos.aspx" CssClass="btn">Gestionar Equipos</asp:HyperLink>
                <asp:HyperLink ID="lnkUsuarios" runat="server" NavigateUrl="~/CapaPresentacion/Usuarios.aspx" CssClass="btn">Gestionar Usuarios</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>