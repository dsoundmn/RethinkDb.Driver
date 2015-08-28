﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Templates.CodeGen
{
    using System;
    
    #line 1 "..\..\CodeGen\EnumTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 2 "..\..\CodeGen\EnumTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 3 "..\..\CodeGen\EnumTemplate.cshtml"
    using RazorGenerator.Templating;
    
    #line default
    #line hidden
    
    #line 4 "..\..\CodeGen\EnumTemplate.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EnumTemplate : Templates.BaseTemplate
    {
#line hidden

        #line 6 "..\..\CodeGen\EnumTemplate.cshtml"

    public string EnumName { get; set; }
    public Dictionary<string, object> Enums { get; set; }

    public override RazorTemplateBase UseParentLayout(RazorTemplateBase child)
    {
        return new EnumTemplate()
            {
                EnumName = this.EnumName,
                Enums = this.Enums,
                ChildTemplate = child
            };
    }


        #line default
        #line hidden

        public override void Execute()
        {




WriteLiteral("\r\n");


WriteLiteral("\r\n");


WriteLiteral("\r\n//AUTOGENERATED, DO NOTMODIFY.\r\n//Do not edit this file directly.\r\n\r\n// ReSharp" +
"er disable CheckNamespace\r\n\r\nnamespace RethinkDb.Driver.Proto {\r\n    public enum" +
" ");


            
            #line 29 "..\..\CodeGen\EnumTemplate.cshtml"
           Write(EnumName);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n");


            
            #line 30 "..\..\CodeGen\EnumTemplate.cshtml"
     foreach( var kvp in this.Enums )
    {

            
            #line default
            #line hidden
WriteLiteral("        ");


            
            #line 32 "..\..\CodeGen\EnumTemplate.cshtml"
     Write(kvp.Key);

            
            #line default
            #line hidden
WriteLiteral(" = ");


            
            #line 32 "..\..\CodeGen\EnumTemplate.cshtml"
                Write(kvp.Value);

            
            #line default
            #line hidden
WriteLiteral(",\r\n");


            
            #line 33 "..\..\CodeGen\EnumTemplate.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    }\r\n\r\n    ");


            
            #line 36 "..\..\CodeGen\EnumTemplate.cshtml"
Write(RenderSection("CustomMethods"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n}\r\n");


        }
    }
}
#pragma warning restore 1591