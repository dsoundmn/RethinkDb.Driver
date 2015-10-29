




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

    // Test basic time arithmetic

    [TestFixture]
    public class TimesConstructors : GeneratedTest {

        public TimesConstructors (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #5
                 /* ExpectedOriginal: datetime.fromtimestamp(896571240, r.ast.RqlTzinfo('00:00')) */
                 var expected_ = datetime.fromtimestamp(896571240L, ast.rqlTzinfo("00:00"));
                 
                 /* Original: r.expr(r.epoch_time(896571240)) */
                 var obtained = runOrCatch( r.expr(r.epochTime(896571240L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #11
                 /* ExpectedOriginal: {'stuff':datetime.fromtimestamp(896571240, r.ast.RqlTzinfo('00:00')), 'more':[datetime.fromtimestamp(996571240, r.ast.RqlTzinfo('00:00'))]} */
                 var expected_ = r.hashMap("stuff", datetime.fromtimestamp(896571240L, ast.rqlTzinfo("00:00"))).with("more", r.array(datetime.fromtimestamp(996571240L, ast.rqlTzinfo("00:00"))));
                 
                 /* Original: r.expr({'stuff':r.epoch_time(896571240), 'more':[r.epoch_time(996571240)]}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("stuff", r.epochTime(896571240L)).with("more", r.array(r.epochTime(996571240L)))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #17
                 /* ExpectedOriginal: [datetime.fromtimestamp(796571240, r.ast.RqlTzinfo('00:00')), datetime.fromtimestamp(896571240, r.ast.RqlTzinfo('00:00')), {'stuff':datetime.fromtimestamp(996571240, r.ast.RqlTzinfo('00:00'))}] */
                 var expected_ = r.array(datetime.fromtimestamp(796571240L, ast.rqlTzinfo("00:00")), datetime.fromtimestamp(896571240L, ast.rqlTzinfo("00:00")), r.hashMap("stuff", datetime.fromtimestamp(996571240L, ast.rqlTzinfo("00:00"))));
                 
                 /* Original: r.expr([r.epoch_time(796571240), r.epoch_time(896571240), {'stuff':r.epoch_time(996571240)}]) */
                 var obtained = runOrCatch( r.expr(r.array(r.epochTime(796571240L), r.epochTime(896571240L), r.hashMap("stuff", r.epochTime(996571240L)))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #23
                 /* ExpectedOriginal: {'nested':{'time':datetime.fromtimestamp(896571240, r.ast.RqlTzinfo('00:00'))}} */
                 var expected_ = r.hashMap("nested", r.hashMap("time", datetime.fromtimestamp(896571240L, ast.rqlTzinfo("00:00"))));
                 
                 /* Original: r.expr({'nested':{'time':r.epoch_time(896571240)}}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("nested", r.hashMap("time", r.epochTime(896571240L)))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #29
                 /* ExpectedOriginal: [1, "two", ["a", datetime.fromtimestamp(896571240, r.ast.RqlTzinfo('00:00')), 3]] */
                 var expected_ = r.array(1L, "two", r.array("a", datetime.fromtimestamp(896571240L, ast.rqlTzinfo("00:00")), 3L));
                 
                 /* Original: r.expr([1, "two", ["a", r.epoch_time(896571240), 3]]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, "two", r.array("a", r.epochTime(896571240L), 3L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #35
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.epoch_time(1).to_epoch_time() */
                 var obtained = runOrCatch( r.epochTime(1L).toEpochTime() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #37
                 /* ExpectedOriginal: -1 */
                 var expected_ = -1L;
                 
                 /* Original: r.epoch_time(-1).to_epoch_time() */
                 var obtained = runOrCatch( r.epochTime(-1L).toEpochTime() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #39
                 /* ExpectedOriginal: 1.444 */
                 var expected_ = 1.444;
                 
                 /* Original: r.epoch_time(1.4444445).to_epoch_time() */
                 var obtained = runOrCatch( r.epochTime(1.4444445).toEpochTime() ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #42
                 /* ExpectedOriginal: "1970-01-01T00:00:01.444+00:00" */
                 var expected_ = "1970-01-01T00:00:01.444+00:00";
                 
                 /* Original: r.epoch_time(1.4444445).to_iso8601() */
                 var obtained = runOrCatch( r.epochTime(1.4444445).toIso8601() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #45
                 /* ExpectedOriginal: 1.444 */
                 var expected_ = 1.444;
                 
                 /* Original: r.epoch_time(1.4444445).seconds() */
                 var obtained = runOrCatch( r.epochTime(1.4444445).seconds() ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #48
                 /* ExpectedOriginal: 10000 */
                 var expected_ = 10000L;
                 
                 /* Original: r.epoch_time(253430000000).year() */
                 var obtained = runOrCatch( r.epochTime(253430000000L).year() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #50
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Year `10000` out of valid ISO 8601 range [0, 9999].", []) */
                 var expected_ = err("ReqlQueryLogicError", "Year `10000` out of valid ISO 8601 range [0, 9999].", r.array());
                 
                 /* Original: r.epoch_time(253430000000).to_iso8601() */
                 var obtained = runOrCatch( r.epochTime(253430000000L).toIso8601() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #53
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Error in time logic: Year is out of valid range: 1400..10000.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Error in time logic: Year is out of valid range: 1400..10000.", r.array());
                 
                 /* Original: r.epoch_time(253440000000).year() */
                 var obtained = runOrCatch( r.epochTime(253440000000L).year() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #55
                 /* ExpectedOriginal: 253440000000 */
                 var expected_ = 253440000000L;
                 
                 /* Original: r.epoch_time(253440000000).to_epoch_time() */
                 var obtained = runOrCatch( r.epochTime(253440000000L).toEpochTime() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #57
                 /* ExpectedOriginal: 1400 */
                 var expected_ = 1400L;
                 
                 /* Original: r.epoch_time(-17980000000).year() */
                 var obtained = runOrCatch( r.epochTime(-17980000000L).year() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #59
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Error in time logic: Year is out of valid range: 1400..10000.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Error in time logic: Year is out of valid range: 1400..10000.", r.array());
                 
                 /* Original: r.epoch_time(-17990000000).year() */
                 var obtained = runOrCatch( r.epochTime(-17990000000L).year() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/constructors.yaml, #61
                 /* ExpectedOriginal: -17990000000 */
                 var expected_ = -17990000000L;
                 
                 /* Original: r.epoch_time(-17990000000).to_epoch_time() */
                 var obtained = runOrCatch( r.epochTime(-17990000000L).toEpochTime() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, times/constructors.yaml, #65
             //Original: cdate = "2013-01-01"
             
                 var cdate = (String) ("2013-01-01");
             
             
             //JavaDef, times/constructors.yaml, #66
             //Original: dates = ["2013", "2013-01", "2013-01-01", "20130101", "2013-001", "2013001"]
             
                 var dates = (IList) (r.array("2013", "2013-01", "2013-01-01", "20130101", "2013-001", "2013001"));
             
             
             //JavaDef, times/constructors.yaml, #67
             //Original: ctime = "13:00:00"
             
                 var ctime = (String) ("13:00:00");
             
             
             //JavaDef, times/constructors.yaml, #68
             //Original: times = ["13", "13:00", "1300", "13:00:00", "13:00:00.000000", "130000.000000"]
             
                 var times = (IList) (r.array("13", "13:00", "1300", "13:00:00", "13:00:00.000000", "130000.000000"));
             
             
             //JavaDef, times/constructors.yaml, #69
             //Original: ctz = "+00:00"
             
                 var ctz = (String) ("+00:00");
             
             
             //JavaDef, times/constructors.yaml, #70
             //Original: tzs = ["Z", "+00", "+0000", "+00:00"]
             
                 var tzs = (IList) (r.array("Z", "+00", "+0000", "+00:00"));
             
             
             //JavaDef, times/constructors.yaml, #71
             //Original: cdt = [cdate+"T"+ctime+ctz]
             
                 var cdt = (IList) (r.array(cdate + "T" + ctime + ctz));
             
             
             //JavaDef, times/constructors.yaml, #81
             //Original: bad_dates = ["201301", "2013-0101", "2a13", "2013+01", "2013-01-01.1"]
             
                 var bad_dates = (IList) (r.array("201301", "2013-0101", "2a13", "2013+01", "2013-01-01.1"));
             
             
             //JavaDef, times/constructors.yaml, #82
             //Original: bad_times = ["a3", "13:0000", "13:000", "13:00.00", "130000.00000000a"]
             
                 var bad_times = (IList) (r.array("a3", "13:0000", "13:000", "13:00.00", "130000.00000000a"));
             
             
             //JavaDef, times/constructors.yaml, #83
             //Original: bad_tzs = ["X", "-7", "-07:-1", "+07+01", "PST", "UTC", "Z+00"]
             
                 var bad_tzs = (IList) (r.array("X", "-7", "-07:-1", "+07+01", "PST", "UTC", "Z+00"));
             

        }
    }
}
