



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;

namespace RethinkDb.Driver {
    public class ReqlRuntimeError : ReqlError {


        public ReqlRuntimeError () {
        }

        public ReqlRuntimeError (Exception e) : this(e.Message, e) {
        }

        public ReqlRuntimeError (string message) : base(message)
        {
        }

        public ReqlRuntimeError (string message, Exception innerException) : base(message, innerException)
        {
        }
        
        
    }
}
