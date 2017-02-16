<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Cs_coca_cola.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>
            Marcas
        </title>
        <style type="text/css">
            img 
            { 
                width:100px; 
                height:50px; 

            }
            .imgbttn 
            { 
                width:100px; 
                height:50px; 
            }
            td 
            { 
                text-align:center; 
                vertical-align:middle; 
                background-color:aliceblue; 

            }
            .style1
            {
                height: 108px; width: 100px;
            }
            .tables
            {
                align-items:center;
                border:1px;
                border-style:solid;
                border-color:black;
                width:100%;
                text-align:"center";
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <h1 align="center">Marcas</h1>
            <p align="right"><a href="WebForm1.aspx">Volver</a></p>
        </div>
        <div>
            <table class="tables">
                <tr style="width:100%">
                    <td class="style1">
                        <asp:ImageButton class="imgbttn" ID="sprite" runat="server" OnClick="agregarProducto" alt="Logo Sprite" src="http://i.forbesimg.com/media/lists/companies/sprite_416x416.jpg" />
                    </td>
                    <td class="style1">
                        <asp:ImageButton class="imgbttn" ID="coke" runat="server" OnClick="agregarProducto"  alt="Logo Coca Cola"  style="width:200px" src="https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Coca-Cola_logo.svg/1024px-Coca-Cola_logo.svg.png" />
                    </td>
                    <td class="style1">
                        <asp:ImageButton class="imgbttn" ID="fanta" runat="server" OnClick="agregarProducto" alt="Logo Fanta" src="https://yt3.ggpht.com/-2f11OmAvQlg/AAAAAAAAAAI/AAAAAAAAAAA/FVF84Ngxvsk/s900-c-k-no-mo-rj-c0xffffff/photo.jpg" />
                    </td>
                    <td class="style1">
                        <asp:ImageButton class="imgbttn" ID="apple" runat="server" OnClick="agregarProducto" alt="Logo Manzana" src="http://www.vector-logo.net/logo_preview/eps/m/Manzana_Lift.png" />
                    </td>
                </tr>
                <tr>
                    <td>
                    
                        <asp:ListBox ID="Lista" runat="server" Height="99px" Width="276px" OnTextChanged="Lista_TextChanged">

                        </asp:ListBox>
                    
                        <asp:Label ID="Label1" runat="server" Text="Total: "></asp:Label>
                    
                    </td>
                </tr>
            </table>
        </div>
            <br />
        <div id="resultado">
            <asp:Table ID="Table1" runat="server" OnLoad="Table1_Load" CssClass="tables">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        Cantidad
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Descripción
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio unitario
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio antes de impuestos
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Impuestos
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio total
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
        <div>
            <asp:Table ID="Table2" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        Cantidad
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Descripción
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio unitario
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio antes de impuestos
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Impuestos
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        Precio total
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
        </form>
    </body>
</html>