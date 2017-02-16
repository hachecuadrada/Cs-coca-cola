<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cs_coca_cola.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" width="1024">
        <tr>
            <td colspan=2>
                Coca Cola en el mundo</td>
            <td colspan=2>
                Coca Cola México</td>
            <td colspan=4 align="right">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td colspan=8 align="center" height="80">
                <asp:Image ID="Image1" runat="server" 
                    
                    ImageUrl="http://www.netambulo.com/wp-content/uploads/2013/03/coca-cola-zero-listillos.jpg" 
                    ImageAlign="AbsMiddle" Width="1024" />
                </td>
        </tr>
        <tr align="center">
            <td style="border-style: solid; border-width: 2px">
                Inicio</td>
            <td style="border-style: solid; border-width: 2px">
                <a href="WebForm2.aspx">Marcas</a></td>
            <td style="border-style: solid; border-width: 2px">
                Bienestar</td>
            <td style="border-style: solid; border-width: 2px">
                Medio Ambiente</td>
            <td style="border-style: solid; border-width: 2px">
                Comunidad</td>
            <td style="border-style: solid; border-width: 2px">
                Cooltura</td>
            <td style="border-style: solid; border-width: 2px">
                Historia</td>
            <td style="border-style: solid; border-width: 2px">
                Empleo</td>
        </tr>
        <tr>
            <td colspan=8 class="style2" align="center">
                <asp:Image ID="Image2" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide1.img.png/1486054695861.png" 
                    Width="1024" />
                </td>
        </tr>
        <tr align="center">
            <td colspan=2>
                Coca-Cola Original o Sin Azúcar</td>
            <td colspan=2>
                A la Mexicana</td>
            <td colspan=2>
                Centro de Innovación y Desarrollo</td>
            <td colspan=2>
                Coca-Cola y el Agua</td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image3" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide1.resize.w_111.h_73.png/ukcDwN7BjcgFiYxvxFGUw/1486054695861.png" />
            </td>
            <td>
                <asp:Image ID="Image4" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide2.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image5" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide3.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image6" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide4.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image7" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide5.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image8" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide6.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image9" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide7.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
            <td>
                <asp:Image ID="Image10" runat="server" 
                    ImageUrl="http://www.coca-colamexico.com.mx/homepage/_jcr_content/heroSlideshowPar/heroslideshowct/smartslides/slide8.resize.w_111.h_73.jpg/ukcDwN7BjcgFiYxvxFGUw/1486054695861.jpg" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
