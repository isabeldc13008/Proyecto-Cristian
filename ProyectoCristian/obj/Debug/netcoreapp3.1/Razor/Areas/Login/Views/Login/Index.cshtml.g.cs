#pragma checksum "C:\Users\RYZEN 5\source\repos\ProyectoCristian\ProyectoCristian\Areas\Login\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fb5e8fed3377526cc81819e74334c5da2848c5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Login_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Login/Views/Login/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb5e8fed3377526cc81819e74334c5da2848c5f", @"/Areas/Login/Views/Login/Index.cshtml")]
    public class Areas_Login_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/google.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb5e8fed3377526cc81819e74334c5da2848c5f3302", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.5.1.min.js\" integrity=\"sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb5e8fed3377526cc81819e74334c5da2848c5f4437", async() => {
                WriteLiteral(@"
    <style>
body{
  font-family: 'Mukta', sans-serif;
	height:100vh;
	min-height:550px;
	background-color: #9E9E9E;
}
.alerta{
    margin-top: -3px;
    margin-bottom: -3px;
}
a{
  text-decoration:none;
  color:#444444;
}
.login-reg-panel{
    position: relative;
    top: 50%;
    transform: translateY(-50%);
	text-align:center;
    width:70%;
	right:0;left:0;
    margin:auto;
    height:400px;
    background-color: rgba(0, 0, 0, 0.9);
}
.white-panel{
    background-color: rgba(255,255, 255, 1);
    height:500px;
    position:absolute;
    top:-50px;
    width:50%;
    right:calc(50% - 50px);
    transition:.3s ease-in-out;
    z-index:0;
    box-shadow: 0 0 15px 9px #00000096;
}
.login-reg-panel input[type=""radio""]{
    position:relative;
    display:none;
}
.login-reg-panel{
    color:#B8B8B8;
}
.login-reg-panel #label-login,
.login-reg-panel #label-register{
    border:1px solid #9E9E9E;
    padding:5px 5px;
    width:150px;
    display:block;
    text-al");
                WriteLiteral(@"ign:center;
    border-radius:10px;
    cursor:pointer;
    font-weight: 600;
    font-size: 18px;
}
.login-info-box{
    width:30%;
    padding:0 50px;
    top:20%;
    left:0;
    position:absolute;
    text-align:left;
}
.register-info-box{
    width:30%;
    padding:0 50px;
    top:20%;
    right:0;
    position:absolute;
    text-align:left;

}
.right-log{right:50px !important;}

.login-show,
.register-show{
    z-index: 1;
    display:none;
    opacity:0;
    transition:0.3s ease-in-out;
    color:#242424;
    text-align:left;
    padding:50px;
}
.show-log-panel{
    display:block;
    opacity:0.9;
}
.login-show input[type=""text""], .login-show input[type=""password""]{
    width: 100%;
    display: block;
    margin:20px 0;
    padding: 15px;
    border: 1px solid #b5b5b5;
    outline: none;
}
.login-show .btn {
    max-width: 150px;
    margin-top: 5px;
    width: 100%;
    background: #444444;
    color: #f9f9f9;
    border: none;
    padding: 10px;");
                WriteLiteral(@"
    border-radius: 2px;
    float: left;
    cursor:pointer;
    border-radius: 5px;
}
.google{
    max-width: 150px;
    margin-top: 5px;
   width: 100%;
   background-color: #D43012;
   color: #f9f9f9;
   border: none;
   padding: 10px;
   margin-left: 8px;
   border-radius: 5px;

}
.login-show a{
    display:inline-block;
    padding:10px 0;
    float: left;
    text-decoration: none;
    margin-top: 10px;
}
.login-show a:hover{
    color: #8C8B89;
}

.register-show input[type=""text""], .register-show input[type=""password""]{
    width: 100%;
    display: block;
    margin:20px 0;
    padding: 15px;
    border: 1px solid #b5b5b5;
    outline: none;
}
.register-show input[type=""button""] {
    max-width: 150px;
    width: 100%;
    background: #444444;
    color: #f9f9f9;
    border: none;
    padding: 10px;
    border-radius: 2px;
    float:right;
    cursor:pointer;
    border-radius: 5px;
}
.credit {
    position:absolute;
    bottom:10px;
    left:10px;
");
                WriteLiteral(@"    color: #3B3B25;
    margin: 0;
    padding: 0;
    font-family: Arial,sans-serif;
    text-transform: uppercase;
    font-size: 12px;
    font-weight: bold;
    letter-spacing: 1px;
    z-index: 99;
}
a{
  text-decoration:none;
  color:#444444;
}

    </style> 
<div class=""login-reg-panel"">
    <div class=""login-info-box"">
        <h2>Ya tienes cuenta?</h2>
        <p>Inicia sesion para poder ingresar</p>
        <label id=""label-register"" for=""log-reg-show"">Inicio de sesion</label>
        <input type=""radio"" name=""active-log-panel"" id=""log-reg-show"" checked=""checked"">
    </div>
    -
    <div class=""register-info-box"">
        <h2>No tienes cuenta?</h2>
        <p>Registrate es gratis</p>
        <label id=""label-login"" for=""log-login-show"">Registro</label>
        <input type=""radio"" name=""active-log-panel"" id=""log-login-show"">
    </div>

    <div class=""white-panel"">
        <div class=""login-show"">
            <form method=""POST"" id=""f_login"">
                <h2>I");
                WriteLiteral(@"nicio de sesion</h2>
                <div class=""form-group"" id=""input_correo"">
                    <input type=""text"" name=""correo"" placeholder=""Correo Electronico"">
                </div>
                <div class=""form-group"" id=""input_pass"">
                    <input type=""password"" name=""clave"" placeholder=""Contraseña"">
                </div>
                <button class=""btn"" type=""button"" id=""enviar"">Enviar</button>
                <input class=""google"" type=""button"" id=""google"" value=""Google"">
                <a");
                BeginWriteAttribute("href", " href=\"", 4852, "\"", 4859, 0);
                EndWriteAttribute();
                WriteLiteral(@">Olvidaste tu contraseña?</a>
            </form>
        </div>
        <div class=""register-show"">
            <form method=""POST"" id=""f_registro"">
                <h2>Registro</h2>
                <div id=""r_correo"">
                    <input type=""text"" name=""correoR"" placeholder=""Correo Electronico"">
                </div>
                <div id=""r_clave"">
                    <input type=""password"" name=""clave2"" placeholder=""Contraseña"">
                </div>
                <div id=""r_clave2"">
                    <input type=""password"" name=""claveconfir"" placeholder=""Confirmacion de contraseña"">
                </div>
                <input type=""button"" id=""registro"" value=""Guardar"">
            </form>
        </div>
    </div>
</div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb5e8fed3377526cc81819e74334c5da2848c5f10520", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('.login-info-box').fadeOut();
        $('.login-show').addClass('show-log-panel');
    });


    $('.login-reg-panel input[type=""radio""]').on('change', function () {
        if ($('#log-login-show').is(':checked')) {
            $('.register-info-box').fadeOut();
            $('.login-info-box').fadeIn();

            $('.white-panel').addClass('right-log');
            $('.register-show').addClass('show-log-panel');
            $('.login-show').removeClass('show-log-panel');

        }
        else if ($('#log-reg-show').is(':checked')) {
            $('.register-info-box').fadeIn();
            $('.login-info-box').fadeOut();

            $('.white-panel').removeClass('right-log');

            $('.login-show').addClass('show-log-panel');
            $('.register-show').removeClass('show-log-panel');
        }
    });

</script>
<script src=""https://www.gstatic.com/firebasejs/8.0.1/firebase-app.js""></script>
<script src=""");
            WriteLiteral(@"https://www.gstatic.com/firebasejs/7.19.1/firebase-auth.js""></script>

<!--TODO: Add SDKs for Firebase products that you want to use
     https://firebase.google.com/docs/web/setup#available-libraries -->
<script>

    // Your web app's Firebase configuration
    var firebaseConfig = {
        apiKey: ""AIzaSyCHZcTDnb-csRv2GKs8PFJ7Ng-X2pr4wn4"",
        authDomain: ""proyectonet-fadd3.firebaseapp.com"",
        databaseURL: ""https://proyectonet-fadd3.firebaseio.com"",
        projectId: ""proyectonet-fadd3"",
        storageBucket: ""proyectonet-fadd3.appspot.com"",
        messagingSenderId: ""750431764480"",
        appId: ""1:750431764480:web:72908b33cdbeace18b58e5""
    };
    // Initialize Firebase
    firebase.initializeApp(firebaseConfig);
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
