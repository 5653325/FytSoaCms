#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8498426582be50dcd53a74f517ee8ddcc31a72ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_CodesModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/CodesModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/CodesModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_CodesModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8498426582be50dcd53a74f517ee8ddcc31a72ba", @"/Pages/FytAdmin/Sys/CodesModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_CodesModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
  
    ViewData["Title"] = "编辑修改字典栏目";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 1585, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "714814ee1f334a6194ca8fb3c8e49943", async() => {
                BeginContext(182, 200, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">等级</label>\r\n        <div class=\"layui-input-block\">\r\n            <select name=\"ParentGuid\" lay-search=\"\">\r\n                ");
                EndContext();
                BeginContext(382, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a2794c836e4ad38b63b75c1fce6da2", async() => {
                    BeginContext(399, 2, true);
                    WriteLiteral("父级");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(410, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                 foreach (var item in Model.SelectList.Where(m=>string.IsNullOrEmpty(m.ParentGuid)))
                {
                    if (Model.CodeType.parent == item.Guid)
                    {

#line default
#line hidden
                BeginContext(617, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(641, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cea06a6a13e4d629165900488006276", async() => {
                    BeginContext(689, 9, false);
#line 17 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 17 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                           WriteLiteral(item.Guid);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(707, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(781, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(805, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd95f5cc8a041e08c592d747d7ed8e1", async() => {
                    BeginContext(833, 9, false);
#line 21 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                                              Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                           WriteLiteral(item.Guid);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(851, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
                    }
                }

#line default
#line hidden
                BeginContext(895, 223, true);
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">栏目名称</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1118, "\"", 1146, 1);
#line 30 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
WriteAttributeValue("", 1126, Model.CodeType.name, 1126, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1147, 465, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入名称"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1612, "\"", 1640, 1);
#line 39 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
WriteAttributeValue("", 1620, Model.CodeType.guid, 1620, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1641, 41, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Sort\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1682, "\"", 1710, 1);
#line 40 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\CodesModify.cshtml"
WriteAttributeValue("", 1690, Model.CodeType.sort, 1690, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1711, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1723, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1742, 1003, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common','form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/codetype/add"";
                if ($(""#guid"").val()) {
                    urls = ""api/codetype/edit"";
                }
                os.ajax(urls, data.field, function(res) {
                    if (res.statusCode === 200) {
                        parent.layer.close(index);
                    } else {
                        os.error(res.message);
                    }   
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });

        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytAdmin.Sys.CodesModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytAdmin.Sys.CodesModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytAdmin.Sys.CodesModifyModel>)PageContext?.ViewData;
        public FytAdmin.Sys.CodesModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
