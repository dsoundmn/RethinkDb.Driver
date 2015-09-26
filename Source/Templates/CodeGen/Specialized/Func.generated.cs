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

namespace Templates.CodeGen.Specialized
{
    using System;
    
    #line 2 "..\..\CodeGen\Specialized\Func.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\Specialized\Func.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\CodeGen\Specialized\Func.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\Specialized\Func.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\Specialized\Func.cshtml"
    using Templates;
    
    #line default
    #line hidden
    
    #line 7 "..\..\CodeGen\Specialized\Func.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class Func : AstSubclassTemplate
    {
#line hidden

        #line 79 "..\..\CodeGen\Specialized\Func.cshtml"

    

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







WriteLiteral("\r\n");


WriteLiteral("\r\n");


            
            #line 11 "..\..\CodeGen\Specialized\Func.cshtml"
  
    this.Layout = UseParentLayout(this);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("Add_Imports", () => {

WriteLiteral("\r\n    using System.Threading;\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("Ctors", () => {

WriteLiteral("\r\n    \r\n        protected Func(Arguments args) : base(TermType.FUNC, args, null)\r" +
"\n        {\r\n        }\r\n\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("MemberVars", () => {

WriteLiteral("\r\n        private static int VarId = 0;\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("SpecialMethods", () => {

WriteLiteral("\r\n        private static int NextVarId(){\r\n            return Interlocked.Increme" +
"nt(ref VarId);\r\n        }\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("StaticFactories", () => {

WriteLiteral("\r\n    \r\n    \r\n    public static Func FromLambda(ReqlLambda function){\r\n    \r\n");


            
            #line 42 "..\..\CodeGen\Specialized\Func.cshtml"
         foreach( var n in Enumerable.Range(1, GeneratorForAst.GetMaxArity()) )
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("//Function ");


            
            #line 44 "..\..\CodeGen\Specialized\Func.cshtml"
                    Write(n);

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("            ");

WriteLiteral("var ");


            
            #line 45 "..\..\CodeGen\Specialized\Func.cshtml"
              Write("func"+n);

            
            #line default
            #line hidden
WriteLiteral(" = function as ");


            
            #line 45 "..\..\CodeGen\Specialized\Func.cshtml"
                                        Write("ReqlFunction"+n);

            
            #line default
            #line hidden
WriteLiteral(";\r\n");



WriteLiteral("            ");

WriteLiteral("if( ");


            
            #line 46 "..\..\CodeGen\Specialized\Func.cshtml"
              Write("func"+n);

            
            #line default
            #line hidden
WriteLiteral(" != null){\r\n");


            
            #line 47 "..\..\CodeGen\Specialized\Func.cshtml"
                for( int v = 1; v <= n; v++ )
                {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("int ");


            
            #line 49 "..\..\CodeGen\Specialized\Func.cshtml"
                  Write("var" + v);

            
            #line default
            #line hidden
WriteLiteral(" = NextVarId();\r\n");


            
            #line 50 "..\..\CodeGen\Specialized\Func.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("var varIds = new List<int>{ \r\n");


            
            #line 52 "..\..\CodeGen\Specialized\Func.cshtml"
                for( int v = 1; v <= n; v++ )
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("var");


            
            #line 54 "..\..\CodeGen\Specialized\Func.cshtml"
                     Write(v + ",");

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 55 "..\..\CodeGen\Specialized\Func.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("};\r\n");


            
            #line 57 "..\..\CodeGen\Specialized\Func.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("var appliedFunction = ");


            
            #line 58 "..\..\CodeGen\Specialized\Func.cshtml"
                                    Write("func"+n);

            
            #line default
            #line hidden
WriteLiteral(".apply(\r\n");


            
            #line 59 "..\..\CodeGen\Specialized\Func.cshtml"
                    for (int v = 1; v <= n; v++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("new Var(var");


            
            #line 61 "..\..\CodeGen\Specialized\Func.cshtml"
                             Write(v);

            
            #line default
            #line hidden
WriteLiteral(") ");


            
            #line 61 "..\..\CodeGen\Specialized\Func.cshtml"
                                   Write(v == n ? "" : ",");

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 62 "..\..\CodeGen\Specialized\Func.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral(");\r\n");


            
            #line 64 "..\..\CodeGen\Specialized\Func.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("return new Func(Arguments.Make(\r\n");



WriteLiteral("                        ");

WriteLiteral("new MakeArray(varIds),\r\n");



WriteLiteral("                        ");

WriteLiteral("Util.ToReqlAst(appliedFunction)\r\n");



WriteLiteral("                ");

WriteLiteral("));\r\n");



WriteLiteral("            ");

WriteLiteral("}\r\n");


            
            #line 70 "..\..\CodeGen\Specialized\Func.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    \r\n        throw new ReqlDriverError(\"Arity of ReqlLambda not recognized!\");\r\n" +
"    }\r\n\r\n    \r\n");


});

WriteLiteral("\r\n\r\n\r\n");


WriteLiteral("\r\n       \r\n      ");


        }
    }
}
#pragma warning restore 1591
