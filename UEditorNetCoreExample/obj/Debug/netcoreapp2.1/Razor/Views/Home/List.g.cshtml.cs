#pragma checksum "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44bd98229b22ee1774bb9fa8d3efa0afce7d2af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\_ViewImports.cshtml"
using UEditorNetCoreExample;

#line default
#line hidden
#line 2 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\_ViewImports.cshtml"
using UEditorNetCoreExample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44bd98229b22ee1774bb9fa8d3efa0afce7d2af7", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce786072c53d4f770a6f68e9011aa3907244952", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UEditorNetCore.Model.Entity.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/layer/layer.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-2.1.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/layer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(113, 402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73875347a9684a90bfcffaeb33094ba9", async() => {
                BeginContext(119, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>List</title>\r\n    ");
                EndContext();
                BeginContext(209, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b79542b3f2854a43b99bfe2753069379", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(279, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(285, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9554c89cd3db4672a217a8e119ac1877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(347, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(353, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c74942e309e641d4ac41ac193b1d22ee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(426, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(432, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47cf5fee15024153ad7dfa1760704dd0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(500, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(515, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(517, 4315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9f9807b99940a882138c379ec5579e", async() => {
                BeginContext(523, 219, true);
                WriteLiteral("\r\n    <div class=\"col-sm-9 col-sm-offset-3 col-md-10 col-lg-10 col-md-offset-1\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-10 col-md-10\">\r\n                <h1 class=\"page-header\">管理 <span class=\"badge\">");
                EndContext();
                BeginContext(743, 17, false);
#line 22 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                                                          Write(ViewBag.DataCount);

#line default
#line hidden
                EndContext();
                BeginContext(760, 939, true);
                WriteLiteral(@"</span></h1>
                <div class=""table-responsive"">
                    <table class=""table table-striped table-hover"">
                        <thead>
                            <tr>
                                <th><span class=""glyphicon glyphicon-paperclip""></span> <span class=""visible-lg"">ID</span></th>
                                <th><span class=""glyphicon glyphicon-file""></span> <span class=""visible-lg"">标题</span></th>
                                <th><span class=""glyphicon glyphicon-list-alt""></span> <span class=""visible-lg"">创建日期</span></th>
                                <th><span class=""glyphicon glyphicon-list-alt""></span> <span class=""visible-lg"">更新日期</span></th>
                                <th><span class=""glyphicon glyphicon-pencil""></span> <span class=""visible-lg"">操作</span></th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 35 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(1788, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1909, 37, false);
#line 39 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1946, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2074, 40, false);
#line 42 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(2114, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2242, 45, false);
#line 45 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CreateTime));

#line default
#line hidden
                EndContext();
                BeginContext(2287, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2415, 45, false);
#line 48 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UpdateTime));

#line default
#line hidden
                EndContext();
                BeginContext(2460, 151, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"DetailArticle\"");
                EndContext();
                BeginWriteAttribute("href", " href=", 2611, "", 2653, 1);
#line 51 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
WriteAttributeValue("", 2617, Html.Raw("/Home/Show?id="+@item.Id), 2617, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2653, 71, true);
                WriteLiteral(">查看</a>\r\n                                        <a class=\"editArticle\"");
                EndContext();
                BeginWriteAttribute("href", " href=", 2724, "", 2768, 1);
#line 52 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
WriteAttributeValue("", 2730, Html.Raw("/Home/Detail?id="+@item.Id), 2730, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2768, 82, true);
                WriteLiteral(">修改</a>\r\n                                        <a class=\"deleteArticle\" href=\"#\"");
                EndContext();
                BeginWriteAttribute("rel", " rel=", 2850, "", 2874, 1);
#line 53 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
WriteAttributeValue("", 2855, Html.Raw(@item.Id), 2855, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2874, 91, true);
                WriteLiteral(">删除</a>\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 56 "C:\Users\Xmap00\Desktop\个人网站前端界面系列\编辑器\UEditorNetCore-master\UEditorNetCore-master\UEditorNetCoreExample\Views\Home\List.cshtml"
                            }

#line default
#line hidden
                BeginContext(2996, 285, true);
                WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <a class=""editArticle"" href=""/Home/index"">添加</a>
        <a class=""editArticle"" href=""/Home/Demo"">UEditor 的功能Demo</a>
       
    </div>


        ");
                EndContext();
                BeginContext(3281, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fdab2879c23412392e0706efd9d2418", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3329, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3339, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c06223377474f13b805c164021e4a04", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3384, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3394, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf85cdfa42a743c6b5caf41b8d0e060b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3431, 1394, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $("".deleteArticle"").click(function () {
                var name = $(this);
                var id = name.attr(""rel""); //对应id
                if (event.srcElement.outerText === ""删除"") {
                    layer.confirm('此操作不可逆，是否确认？', {
                        btn: ['删除', '取消'] //按钮
                    }, function () {
                        $.ajax({
                            type: ""POST"",
                            url: ""Home/Delete"",
                            data: ""id="" +id,
                            cache: false, //不缓存此页面
                            success: function (result) {
                                if (result.status == ""success"") {
                                    layer.msg('删除成功！！', {
                                        time: 2000,
                                        end: function () {
                                            window.location.reload();
                                        }
        ");
                WriteLiteral(@"                            });

                                } else {
                                    layer.msg(errorMsg);
                                }
                            }
                        });
                    }, function () {

                    });

                };
            });


        });
    </script>


");
                EndContext();
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
            EndContext();
            BeginContext(4832, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UEditorNetCore.Model.Entity.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
