#pragma checksum "C:\Users\SANSHUIYA\Desktop\Asp\Asp\Asp\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bfeb77284884d0e256f732ce95094c45aa84f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Users\SANSHUIYA\Desktop\Asp\Asp\Asp\Views\_ViewImports.cshtml"
using Asp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SANSHUIYA\Desktop\Asp\Asp\Asp\Views\_ViewImports.cshtml"
using Asp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfeb77284884d0e256f732ce95094c45aa84f5c", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295d2cd633e2455ff8e9ca4d687726e87f1b2d0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SANSHUIYA\Desktop\Asp\Asp\Asp\Views\Home\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bfeb77284884d0e256f732ce95094c45aa84f5c3407", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"UTF-8\">\r\n\r\n    <!-- import CSS -->\r\n\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bfeb77284884d0e256f732ce95094c45aa84f5c4549", async() => {
                WriteLiteral(@"

    <div id=""app"">



        <el-container style=""height:1000px; background-color: rgb(183, 190, 190);"">

            <el-main>

                <el-row>

                    <el-col :span=""12"" :offset=""8"">

                        <el-card class=""box-card"" style=height:700px;>

                            <el-form model=""user"" label-width=""auto"">

                                <el-header>注册</el-header>

                                <el-form-item label=""用户名"">

                                    <el-input v-model=""user.userName"" placeholder=""请输入用户名""></el-input>



                                </el-form-item>

                                <el-form-item label=""密码"">

                                    <el-input v-model=""user.password"" :show-password=true placeholder=""请输入密码""></el-input>



                                </el-form-item>

                                <el-form-item label=""邮箱"">

                                    <el-input v-model=""user.email""");
                WriteLiteral(@" placeholder=""请输入邮箱""></el-input>



                                    <el-form-item label=""性别"">

                                        <el-radio v-model=""user.radio"" label=""1"" border>男</el-radio>

                                        <el-radio v-model=""user.radio"" label=""2"" border>女</el-radio>

                                    </el-form-item>

                                    <el-form-item label=""所在城市"">

                                        <el-input v-model=""user.city"" placeholder=""请输入当前城市""></el-input>

                                    </el-form-item>

                                    <el-form-item label=""生日"">

                                        <el-date-picker v-model=""user.birthday"" align=""right"" type=""date"" placeholder=""选择日期"" :picker-options=""pickerOptions"">

                                        </el-date-picker>

                                    </el-form-item>

                                    <el-form-item label=""爱好"">



                ");
                WriteLiteral(@"                        <el-checkbox-group v-model=""user.check"">



                                            <el-checkbox label=""读书""></el-checkbox>

                                            <el-checkbox label=""踢足球""></el-checkbox>

                                            <el-checkbox label=""画画""></el-checkbox>

                                            <el-checkbox label=""唱歌""></el-checkbox>

                                            <el-checkbox label=""弹琴""></el-checkbox>

                                        </el-checkbox-group>



                                    </el-form-item>



                                    <el-form-item style=""text-align: center;"">



                                        <el-button>注册</el-button>

                                    </el-form-item>

                            </el-form>



                        </el-card>

                    </el-col>

                </el-row>



            </el-main>

        ");
                WriteLiteral("</el-container>\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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

<!-- import Vue before Element -->

<script src=""https://unpkg.com/vue/dist/vue.js""></script>

<!-- import JavaScript -->

<script src=""https://unpkg.com/element-ui/lib/index.js""></script>

<script>

   const app = new Vue({

      el: '#app',

      data:  {

        buttonText:""OK按钮"",

        user:{

            userName:"""",

            password:"""",

            email:"""",

            city:"""",

            birthday:"""",

            hobby:"""",

            check: ['','','','']

        },

      },

    })

</script>

</html>");
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