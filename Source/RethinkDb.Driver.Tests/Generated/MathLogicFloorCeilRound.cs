




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

    // tests for `floor`, `ceil`, and `round`, tests inspired by the Python test suite

    [TestFixture]
    public class MathLogicFloorCeilRound : GeneratedTest {

        public MathLogicFloorCeilRound (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #3
                 /* ExpectedOriginal: "NUMBER" */
                 var expected_ = "NUMBER";
                 
                 /* Original: r.floor(1.0).type_of() */
                 var obtained = runOrCatch( r.floor(1.0).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #5
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.floor(1.0) */
                 var obtained = runOrCatch( r.floor(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #7
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.expr(1.0).floor() */
                 var obtained = runOrCatch( r.expr(1.0).floor() ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #10
                 /* ExpectedOriginal: 0.0 */
                 var expected_ = 0.0;
                 
                 /* Original: r.floor(0.5) */
                 var obtained = runOrCatch( r.floor(0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #12
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.floor(1.0) */
                 var obtained = runOrCatch( r.floor(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #14
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.floor(1.5) */
                 var obtained = runOrCatch( r.floor(1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #16
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.floor(-0.5) */
                 var obtained = runOrCatch( r.floor(-0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #18
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.floor(-1.0) */
                 var obtained = runOrCatch( r.floor(-1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #20
                 /* ExpectedOriginal: -2.0 */
                 var expected_ = -2.0;
                 
                 /* Original: r.floor(-1.5) */
                 var obtained = runOrCatch( r.floor(-1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #23
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array());
                 
                 /* Original: r.expr('X').floor() */
                 var obtained = runOrCatch( r.expr("X").floor() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #27
                 /* ExpectedOriginal: "NUMBER" */
                 var expected_ = "NUMBER";
                 
                 /* Original: r.ceil(1.0).type_of() */
                 var obtained = runOrCatch( r.ceil(1.0).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #29
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.ceil(1.0) */
                 var obtained = runOrCatch( r.ceil(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #31
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.expr(1.0).ceil() */
                 var obtained = runOrCatch( r.expr(1.0).ceil() ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #34
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.ceil(0.5) */
                 var obtained = runOrCatch( r.ceil(0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #36
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.ceil(1.0) */
                 var obtained = runOrCatch( r.ceil(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #38
                 /* ExpectedOriginal: 2.0 */
                 var expected_ = 2.0;
                 
                 /* Original: r.ceil(1.5) */
                 var obtained = runOrCatch( r.ceil(1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #40
                 /* ExpectedOriginal: 0.0 */
                 var expected_ = 0.0;
                 
                 /* Original: r.ceil(-0.5) */
                 var obtained = runOrCatch( r.ceil(-0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #42
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.ceil(-1.0) */
                 var obtained = runOrCatch( r.ceil(-1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #44
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.ceil(-1.5) */
                 var obtained = runOrCatch( r.ceil(-1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #47
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array());
                 
                 /* Original: r.expr('X').ceil() */
                 var obtained = runOrCatch( r.expr("X").ceil() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #51
                 /* ExpectedOriginal: "NUMBER" */
                 var expected_ = "NUMBER";
                 
                 /* Original: r.round(1.0).type_of() */
                 var obtained = runOrCatch( r.round(1.0).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #53
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.round(1.0) */
                 var obtained = runOrCatch( r.round(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #55
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.expr(1.0).round() */
                 var obtained = runOrCatch( r.expr(1.0).round() ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #58
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.round(0.5) */
                 var obtained = runOrCatch( r.round(0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #60
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.round(-0.5) */
                 var obtained = runOrCatch( r.round(-0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #63
                 /* ExpectedOriginal: 0.0 */
                 var expected_ = 0.0;
                 
                 /* Original: r.round(0.0) */
                 var obtained = runOrCatch( r.round(0.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #65
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.round(1.0) */
                 var obtained = runOrCatch( r.round(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #67
                 /* ExpectedOriginal: 10.0 */
                 var expected_ = 10.0;
                 
                 /* Original: r.round(10.0) */
                 var obtained = runOrCatch( r.round(10.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #69
                 /* ExpectedOriginal: 1000000000.0 */
                 var expected_ = 1000000000.0;
                 
                 /* Original: r.round(1000000000.0) */
                 var obtained = runOrCatch( r.round(1000000000.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #71
                 /* ExpectedOriginal: 1e20 */
                 var expected_ = 1e+20;
                 
                 /* Original: r.round(1e20) */
                 var obtained = runOrCatch( r.round(1e+20) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #74
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.round(-1.0) */
                 var obtained = runOrCatch( r.round(-1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #76
                 /* ExpectedOriginal: -10.0 */
                 var expected_ = -10.0;
                 
                 /* Original: r.round(-10.0) */
                 var obtained = runOrCatch( r.round(-10.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #78
                 /* ExpectedOriginal: -1000000000.0 */
                 var expected_ = -1000000000.0;
                 
                 /* Original: r.round(-1000000000.0) */
                 var obtained = runOrCatch( r.round(-1000000000.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #80
                 /* ExpectedOriginal: -1e20 */
                 var expected_ = -1e+20;
                 
                 /* Original: r.round(-1e20) */
                 var obtained = runOrCatch( r.round(-1e+20) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #83
                 /* ExpectedOriginal: 0.0 */
                 var expected_ = 0.0;
                 
                 /* Original: r.round(0.1) */
                 var obtained = runOrCatch( r.round(0.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #85
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.round(1.1) */
                 var obtained = runOrCatch( r.round(1.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #87
                 /* ExpectedOriginal: 10.0 */
                 var expected_ = 10.0;
                 
                 /* Original: r.round(10.1) */
                 var obtained = runOrCatch( r.round(10.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #89
                 /* ExpectedOriginal: 1000000000.0 */
                 var expected_ = 1000000000.0;
                 
                 /* Original: r.round(1000000000.1) */
                 var obtained = runOrCatch( r.round(1000000000.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #92
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.round(-1.1) */
                 var obtained = runOrCatch( r.round(-1.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #94
                 /* ExpectedOriginal: -10.0 */
                 var expected_ = -10.0;
                 
                 /* Original: r.round(-10.1) */
                 var obtained = runOrCatch( r.round(-10.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #96
                 /* ExpectedOriginal: -1000000000.0 */
                 var expected_ = -1000000000.0;
                 
                 /* Original: r.round(-1000000000.1) */
                 var obtained = runOrCatch( r.round(-1000000000.1) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #99
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.round(0.9) */
                 var obtained = runOrCatch( r.round(0.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #101
                 /* ExpectedOriginal: 10.0 */
                 var expected_ = 10.0;
                 
                 /* Original: r.round(9.9) */
                 var obtained = runOrCatch( r.round(9.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #103
                 /* ExpectedOriginal: 1000000000.0 */
                 var expected_ = 1000000000.0;
                 
                 /* Original: r.round(999999999.9) */
                 var obtained = runOrCatch( r.round(999999999.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #106
                 /* ExpectedOriginal: -1.0 */
                 var expected_ = -1.0;
                 
                 /* Original: r.round(-0.9) */
                 var obtained = runOrCatch( r.round(-0.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #108
                 /* ExpectedOriginal: -10.0 */
                 var expected_ = -10.0;
                 
                 /* Original: r.round(-9.9) */
                 var obtained = runOrCatch( r.round(-9.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #110
                 /* ExpectedOriginal: -1000000000.0 */
                 var expected_ = -1000000000.0;
                 
                 /* Original: r.round(-999999999.9) */
                 var obtained = runOrCatch( r.round(-999999999.9) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/floor_ceil_round.yaml, #113
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array());
                 
                 /* Original: r.expr('X').round() */
                 var obtained = runOrCatch( r.expr("X").round() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
