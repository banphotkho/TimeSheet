#pragma checksum "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\Activities\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf80302d6e5513185c65c6cbf8234181f74f6056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_Create), @"mvc.1.0.view", @"/Views/Activities/Create.cshtml")]
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
#line 1 "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\_ViewImports.cshtml"
using ASPNET_Core_3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf80302d6e5513185c65c6cbf8234181f74f6056", @"/Views/Activities/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f8273389c73ee67b936bf8b94df025c2d5af05", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\Activities\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Activities</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 303, 1);
#nullable restore
#line 11 "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\Activities\Create.cshtml"
WriteAttributeValue("", 263, Url.Action("Dashboard_1", "Dashboards"), 263, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Activities</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Create</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""ibox "">
            <div class=""ibox-title"">
                <h5>Create <small>Activities data Master</small></h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 1</a>
                  ");
            WriteLiteral(@"      </li>
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 2</a>
                        </li>
                    </ul>
                    <a class=""close-link"">
                        <i class=""fa fa-times""></i>
                    </a>
                </div>
            </div>
            <div class=""ibox-content"">
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group row"">
                        <label class=""col-sm-2 col-form-label"">Activities :</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" id=""ActivityName"" class=""form-control""> <span class=""form-text m-b-none"">Example Develop,Analysis and Design..</span>
                        </div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2""");
            WriteLiteral(@">
                            <button class=""btn btn-white btn-sm"" type=""submit"">Cancel</button>
                            <button class=""btn btn-primary btn-sm"" id=""btnSave"" type=""submit"">Save changes</button>
                        </div>
                    </div>
            </div>
        </div>
    </div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"  
    <script type=""text/javascript"">  
    $(function () {

        $(""#btnSave"").click(function () {

            var fullDate = new Date();
            var twoDigitMonth = fullDate.getMonth() + """"; if (twoDigitMonth.length == 1) twoDigitMonth = ""0"" + twoDigitMonth;
            var twoDigitDate = fullDate.getDate() + """"; if (twoDigitDate.length == 1) twoDigitDate = ""0"" + twoDigitDate;
            var currentDate = twoDigitDate + ""/"" + twoDigitMonth + ""/"" + fullDate.getFullYear(); console.log(currentDate);
      
            var param = {
                 
                ActivityName: $(""#ActivityName"").val(),
                CrtUser: ""Banphotkho"",
                CrtDate: fullDate
            }
            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 91 "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\Activities\Create.cshtml"
                 Write(Url.Action("SaveData", "Activities"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                contentType: 'application/json; charset=utf-8',
                dataType: ""json"",
                data: JSON.stringify(param),
                success: function () {
                    alert(""Data has been added successfully."");
                    //LoadData();  
                },
                error: function () {
                    alert(""Error while inserting data"");
                }
            });
            return false;
        });
    });

    function LoadData() {
        $(""#tblStudent tbody tr"").remove();
        $.ajax({
            type: 'POST',
            url: '");
#nullable restore
#line 111 "D:\Projects\TMLTH-Projects\Projects\TimeSheet\Views\Activities\Create.cshtml"
             Write(Url.Action("getStudent"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            dataType: 'json',
            data: { id: '' },
            success: function (data) {
                var items = '';
                $.each(data, function (i, item) {
                    var rows = ""<tr>""
                        + ""<td class='prtoducttd'>"" + item.studentID + ""</td>""
                        + ""<td class='prtoducttd'>"" + item.studentName + ""</td>""
                        + ""<td class='prtoducttd'>"" + item.studentAddress + ""</td>""
                        + ""</tr>"";
                    $('#tblStudent tbody').append(rows);
                });
            },
            error: function (ex) {
                var r = jQuery.parseJSON(response.responseText);
                alert(""Message: "" + r.Message);
                alert(""StackTrace: "" + r.StackTrace);
                alert(""ExceptionType: "" + r.ExceptionType);
            }
        });
        return false;
    }
    </script>  
");
            }
            );
            WriteLiteral("\r\n");
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
