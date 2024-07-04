<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DevProjectLocal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

     <!--boostrap elementos necesarios local y cdn-->
 <!-- Incluye los estilos de Bootstrap -->
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
 <!-- Agrega los scripts de Bootstrap -->
 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    
    
    <script src="Content/CustomContent/CustomJS/global.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@10"></script>
    <link href="Content/CustomContent/CustomCSS/login/login.css" rel="stylesheet" />
    
    
    <title>Login</title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div class="contenedor card shadow">
        <section>
            <div class="contenedor py-5 card-body">
                <div class="row d-flex align-items-center justify-content-center h-100">
                    <div class="col-md-8 col-lg-7 col-xl-6 imagenLogin">
                        <img src="Content/Images/logosPrecredit/PRECREDIT%20LOGO%202.png" 
                             class="img-fluid" alt="Phone image" />
                    </div>
                    <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                        <div data-mdb-input-init class="form-outline mb-4">
                             <!-- HTML Input para la usuario -->
                            <input type="text" id="usuario" class="form-control form-control-lg" placeholder="Usuario" runat="server" required />
                        </div>
                        <!-- HTML Input para la contraseña -->
                        
                        <input id="contrasena" runat="server" type="password" class="form-control form-control-lg" placeholder="Contraseña" required/>
                        <!-- ASP.NET Button -->
                        <br /> 
                        <br /> 
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="Ingresar_Click" CssClass="btn btn-primary btn-lg btn-block" />
                    </div>
                </div>
            </div>
        </section>
    </div>
</form>



    <script src="Content/CustomContent/CustomJS/global.js"></script>
</body>
</html>
