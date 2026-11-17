<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Examen.CapaPresentacion.Equipos" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mantenimiento de Equipos</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; }
        .form-group { margin-bottom: 15px; }
        label { display: inline-block; width: 120px; font-weight: bold; }
        input[type="text"] { padding: 5px; width: 250px; }
        .btn { padding: 8px 15px; cursor: pointer; background-color: #28a745; color: white; border: none; border-radius: 4px; }
        .btn-danger { background-color: #dc3545; }
        .btn-warning { background-color: #ffc107; color: black; }
        .message { margin-top: 15px; font-weight: bold; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Gestión de Equipos</h2>
            <asp:HyperLink ID="lnkVolver" runat="server" NavigateUrl="~/CapaPresentacion/Menu.aspx">&larr; Volver al Menú</asp:HyperLink>
            <hr />

            <div class="form-group">
                <label>Equipo ID:</label>
                <asp:TextBox ID="txtEquipoID" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Tipo de Equipo:</label>
                <asp:TextBox ID="txtTipoEquipo" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Modelo:</label>
                <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Usuario ID:</label>
                <asp:TextBox ID="txtUsuarioID" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-warning" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
            </div>

            <div class="message">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>