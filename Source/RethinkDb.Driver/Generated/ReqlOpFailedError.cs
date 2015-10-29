



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;

namespace RethinkDb.Driver {
    public class ReqlOpFailedError : ReqlAvailabilityError {


        public ReqlOpFailedError () {
        }

        public ReqlOpFailedError (Exception e) : this(e.Message, e) {
        }

        public ReqlOpFailedError (string message) : base(message)
        {
        }

        public ReqlOpFailedError (string message, Exception innerException) : base(message, innerException)
        {
        }
        
        
    }
}
