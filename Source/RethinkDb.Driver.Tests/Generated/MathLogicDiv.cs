




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

    // Tests for the basic usage of the division operation

    [TestFixture]
    public class MathLogicDiv : GeneratedTest {

        public MathLogicDiv (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #6
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(4) / 2 */
                 var obtained = runOrCatch( r.expr(4L).div(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #7
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: 4 / r.expr(2) */
                 var obtained = runOrCatch( r.div(4L, r.expr(2L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #8
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(4).div(2) */
                 var obtained = runOrCatch( r.expr(4L).div(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #15
                 /* ExpectedOriginal: 0.5 */
                 var expected_ = 0.5;
                 
                 /* Original: r.expr(-1) / -2 */
                 var obtained = runOrCatch( r.expr(-1L).div(-2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #20
                 /* ExpectedOriginal: 4.9 / 0.7 */
                 var expected_ = 4.9 / 0.7;
                 
                 /* Original: r.expr(4.9) / 0.7 */
                 var obtained = runOrCatch( r.expr(4.9).div(0.7) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #25
                 /* ExpectedOriginal: 1.0/120 */
                 var expected_ = 1.0 / 120L;
                 
                 /* Original: r.expr(1).div(2,3,4,5) */
                 var obtained = runOrCatch( r.expr(1L).div(2L, 3L, 4L, 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #37
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(1) / 0 */
                 var obtained = runOrCatch( r.expr(1L).div(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #38
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(2.0) / 0 */
                 var obtained = runOrCatch( r.expr(2.0).div(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #39
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(3) / 0.0 */
                 var obtained = runOrCatch( r.expr(3L).div(0.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #40
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(4.0) / 0.0 */
                 var obtained = runOrCatch( r.expr(4.0).div(0.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #41
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(0) / 0 */
                 var obtained = runOrCatch( r.expr(0L).div(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #42
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot divide by zero.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot divide by zero.", r.array(1L));
                 
                 /* Original: r.expr(0.0) / 0.0 */
                 var obtained = runOrCatch( r.expr(0.0).div(0.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #46
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('a') / 0.8 */
                 var obtained = runOrCatch( r.expr("a").div(0.8) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/div.yaml, #50
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(1) / 'a' */
                 var obtained = runOrCatch( r.expr(1L).div("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
