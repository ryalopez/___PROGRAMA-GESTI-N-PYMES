﻿<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <!-- Para hablantes de español -->
    <meta name="keywords" lang="es" content="limpieza, reformas, servicio doméstico, fontanería, electricidad" />
    <link href="EstilosMelo.css" rel="stylesheet" type="text/css" />
</head>
<body background="Fondo.jpg">
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td style="width: 15%;" align="left" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="112px" ImageUrl="~/logoMelo.gif" Width="192px" /></td>
                <td style="width: 70%;">
                    <h1>
                        Grupo Melo</h1>
                    <h4>
                        Servicios a particulares y empresas</h4>
                    <h4>
                        NUESTRA CARTA DE SERVICIOS</h4>
                </td>
                <td style="width: 15%;">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 50px">
                    // <marquee id="Marquesina" class="Marquesina" direction="LEFT" behavior="SCROLL" scrollamount="10"
                        // scrolldelay="200">
                    // BIENVENIDO AL SITIO WEB DE GRUPO MELO * Servicios de LIMPIEZA * Servicio de CONSERJERÍA
                    // * Mantenimiento de PISCINAS y JARDINES * AZAFATAS para EXPOSICIONES y CONGRESOS
                    // * SERVICIO DOMÉSTICO * CATERING * REFORMAS en general * REPARACIONES URGENTES *
                    // FONTANERÍA * ELECTRICIDAD * Atendemos Empresas y Particulares * Si es usted un particular
                    // solicite presupuestos sin compromiso * Contacte con nosotros en los teléfonos 91
                    // 369 92 56 o 630 197 752 * GRACIAS POR VISITAR NUESTRA PÁGINA </>
                </td>
            </tr>
            <tr>
                <td style="width: 15%; height: 339px;" align="center" valign="top">
                    <br />
                    <br />
                    <br />
                    <br />
                    <h2>
                        GRUPO MELO SL<br />
                        Estamos en</h2>
                    <div class="InformaciónContacto">
                        Pilar de Zaragoza, 46, Local A<br />
                        28028 MADRID<br />
                        <br />
                    </div>
                    <div id="Tel" class="InformaciónContacto" style="text-decoration: underline; color: red;">
                        Teléfonos</div>
                    <br />
                    <div class="InformaciónContacto">
                        91 369 92 56<br />
                        630 197 752</div>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="mailto:grupomelo666@hotmail.com"
                        CssClass="InformaciónContacto" Style="color: Red;" ToolTip="Pulse este enlace para enviarnos un e-mail">Correo electrónico</asp:HyperLink><br />
                </td>
                <td style="width: 70%" valign="top">
                    <div>
                        <asp:ContentPlaceHolder ID="ContentPlaceHolder2" runat="server">
                        </asp:ContentPlaceHolder>
                    </div>
                </td>
                <td style="width: 15; height: 339px;" valign="top">
                    <br />
                    <br />
                    <br />
                    <br />
                    Atendemos Empresas y Particulares.<br />
                    <br />
                    Si es un particular, no lo dude;
                    <br />
                    solicite presupuestos sin compromiso.</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <h3>
                        Contacte con nosotros en los teléfonos 91 369 92 56 o 630 197 752</h3>
                </td>
            </tr>
        </table>
    </form>

    <script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
    </script>

    <script type="text/javascript">
_uacct = "UA-3486419-1";
urchinTracker();
    </script>

</body>
</html>
