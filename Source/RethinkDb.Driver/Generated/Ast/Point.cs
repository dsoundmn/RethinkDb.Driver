








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Point : ReqlQuery {
    
    
        public Point (object arg) : this(new Arguments(arg), null) {
        }
        public Point (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Point (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.POINT, args, optargs) {
        }

    protected Point (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Point FromArgs(params object[] args){
         return new Point (new Arguments(args), null);
        }


    

    


    
    }
}