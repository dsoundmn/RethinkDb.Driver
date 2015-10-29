



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;

namespace RethinkDb.Driver {
    public class ReqlServerCompileError : ReqlCompileError {


        public ReqlServerCompileError () {
        }

        public ReqlServerCompileError (Exception e) : this(e.Message, e) {
        }

        public ReqlServerCompileError (string message) : base(message)
        {
        }

        public ReqlServerCompileError (string message, Exception innerException) : base(message, innerException)
        {
        }
        
        
    }
}
