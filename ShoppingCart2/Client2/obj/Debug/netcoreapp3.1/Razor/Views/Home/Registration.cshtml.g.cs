#pragma checksum "C:\Users\Administrator\Desktop\csharpthinh\ShoppingCart2\Client2\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a6faf0e7ffcf09b7af9cfe32f63e7a2c3103e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\csharpthinh\ShoppingCart2\Client2\Views\_ViewImports.cshtml"
using Client2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\csharpthinh\ShoppingCart2\Client2\Views\_ViewImports.cshtml"
using Client2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a6faf0e7ffcf09b7af9cfe32f63e7a2c3103e6", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653343828976611e526bcbbfaa596f51f6cd9101", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a6faf0e7ffcf09b7af9cfe32f63e7a2c3103e63304", async() => {
                WriteLiteral(@"
    <title>FlixOneStore Registration</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

    <script type=""text/javascript"">$(document).ready(function () {
            $('#btnRegister').click(function () {
                // Check password and confirm password.
                var password = $('#txtPassword').val(),
                    confirmPassword = $('#txtConfirmPassword').val();
                if (password !== confirmPassword) {
                    alert(""Password and Confirm Password don't match!"");
                    return;
                }

                // Make a customer object.
                var customer = {
                    ""gender"": $(""in");
                WriteLiteral(@"put[name='gender']:checked"").val(),
                    ""firstname"": $('#txtFirstName').val(),
                    ""lastname"": $('#txtLastName').val(),
                    ""dob"": $('#txtDob').val(),
                    ""email"": $('#txtEmail').val(),
                    ""telephone"": $('#txtMobile').val(),
                    ""fax"": $('#txtFax').val(),
                    ""password"": $('#txtPassword').val(),
                    ""newsletteropted"": false
                };

                $.ajax({
                    url: 'https://localhost:44354/api/Customers',
                    type: ""POST"",
                    contentType: ""application/json"",
                    data: JSON.stringify(customer),
                    dataType: ""json"",
                    success: function (result) {
                        alert(""A customer record created for: ""
                            + result.firstname + "" "" + result.lastname);
                    },
                    error: function (err) {
                   ");
                WriteLiteral("     alert(err.responseText);\n                    }\n                });\n            });\n        });</script>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a6faf0e7ffcf09b7af9cfe32f63e7a2c3103e66546", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <h2>Register for FlixOneStore</h2>
        <div style=""margin-bottom: 100px"" class=""form-horizontal"">
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtFirstName"">First Name:</label>
                <div class=""col-sm-3"">
                    <input type=""text"" class=""form-control"" id=""txtFirstName"" placeholder=""Enter first name"" name=""firstname"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtLastName"">Last Name:</label>
                <div class=""col-sm-3"">
                    <input type=""text"" class=""form-control"" id=""txtLastName"" placeholder=""Enter last name"" name=""lastname"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtEmail"">Email:</label>
                <div class=""col-sm-3"">
                    <input type=""email"" class=""form-co");
                WriteLiteral(@"ntrol"" id=""txtEmail"" placeholder=""Enter email"" name=""email"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""gender"">Gender:</label>
                <div class=""col-sm-3"">
                    <label class=""radio-inline""><input type=""radio"" value=""M"" name=""gender"">Male</label>
                    <lable class=""radio-inline""><input type=""radio"" value=""F"" name=""gender"">Female</lable>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtDob"">Date of Birth:</label>
                <div class=""col-sm-3"">
                    <input type=""date"" class=""form-control"" id=""txtDob"" />
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtMobile"">Mobile Number:</label>
                <div class=""col-sm-3"">
                    <input type=""text"" class=""form-contr");
                WriteLiteral(@"ol"" id=""txtMobile"" placeholder=""Enter mobile number"" />
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtFax"">Fax:</label>
                <div class=""col-sm-3"">
                    <input type=""text"" class=""form-control"" id=""txtFax"" placeholder=""Enter fax"" />
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtPassword"">Password:</label>
                <div class=""col-sm-3"">
                    <input type=""password"" class=""form-control"" id=""txtPassword"" placeholder=""Enter password"" name=""pwd"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-sm-2"" for=""txtConfirmPassword"">Confirm Password:</label>
                <div class=""col-sm-3"">
                    <input type=""password"" class=""form-control"" id=""txtConfirmPassword"" placeholder=""Enter password ag");
                WriteLiteral(@"ain"" name=""confirmpwd"">
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <button type=""button"" class=""btn btn-success"" id=""btnRegister"">Register</button>
                </div>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\n</html>");
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