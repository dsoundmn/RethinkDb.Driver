












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Datum : ReqlExpr {

    
    
    
    public Datum(object arg) : base(TermType.DATUM, null, null) {
            datum = arg;
        }


    
    


    


    









       
        internal object datum;



    
    
        protected internal override object Build() {
            // Overridden because Datums are leaf-nodes and therefore
            // don't contain lower ReqlAst objects.
            return datum;
        }



    
    }
}
