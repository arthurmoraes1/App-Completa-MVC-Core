#pragma checksum "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5f58abeee2cfb5f7ec162c47ca6f66c6e12261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco), @"mvc.1.0.view", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/_DetalhesEndereco.cshtml", typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco))]
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
#line 1 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 2 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5f58abeee2cfb5f7ec162c47ca6f66c6e12261", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298a476511c62f8b16609d0811a1582d3185ce3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__DetalhesEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.FornecedorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("supress-by-action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit,ObterEndereco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 103, true);
            WriteLiteral("\r\n<div style=\"padding-top: 20px\">\r\n    <div>\r\n        <hr />\r\n        <h4>Endereço</h4>\r\n    </div>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(184, 155, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(340, 55, false);
#line 15 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(395, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(475, 51, false);
#line 18 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(526, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(606, 56, false);
#line 21 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(662, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(742, 51, false);
#line 24 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(793, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(873, 48, false);
#line 27 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(921, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1001, 51, false);
#line 30 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1132, 51, false);
#line 33 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 167, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1351, 51, false);
#line 41 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1470, 47, false);
#line 44 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1585, 52, false);
#line 47 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1705, 47, false);
#line 50 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1820, 44, false);
#line 53 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1932, 47, false);
#line 56 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2047, 47, false);
#line 59 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2161, 238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5f58abeee2cfb5f7ec162c47ca6f66c6e1226111732", async() => {
                BeginContext(2294, 101, true);
                WriteLiteral("\r\n                        <span title=\"Editar\" class=\"fa fa-pencil-alt\"></span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-modal", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2399, 62, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 68 "C:\Users\arthu\source\repos\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
    }

#line default
#line hidden
            BeginContext(2468, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
