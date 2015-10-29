




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests of conversion to and from the RQL bool type

    [TestFixture]
    public class DatumBool : GeneratedTest {

        public DatumBool (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #3
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(True) */
                 var obtained = runOrCatch( r.expr(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #10
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(False) */
                 var obtained = runOrCatch( r.expr(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #17
                 /* ExpectedOriginal: BOOL */
                 var expected_ = "BOOL";
                 
                 /* Original: r.expr(False).type_of() */
                 var obtained = runOrCatch( r.expr(false).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #21
                 /* ExpectedOriginal: true */
                 var expected_ = "true";
                 
                 /* Original: r.expr(True).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(true).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/bool.yaml, #24
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(True).coerce_to('bool') */
                 var obtained = runOrCatch( r.expr(true).coerceTo("bool") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
