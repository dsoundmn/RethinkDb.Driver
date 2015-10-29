












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

    public class InnerJoin : ReqlExpr {

    
    
    
/// <summary>
/// <para>Returns an inner join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all matchups between Marvel and DC heroes in which the DC hero could beat the Marvel hero in a fight.</para>
/// <code>r.table('marvel').innerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).zip().run(conn, callback)
/// </code></example>
        public InnerJoin (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Returns an inner join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all matchups between Marvel and DC heroes in which the DC hero could beat the Marvel hero in a fight.</para>
/// <code>r.table('marvel').innerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).zip().run(conn, callback)
/// </code></example>
        public InnerJoin (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Returns an inner join of two sequences.</para>
/// </summary>
/// <example><para>Example: Return a list of all matchups between Marvel and DC heroes in which the DC hero could beat the Marvel hero in a fight.</para>
/// <code>r.table('marvel').innerJoin(r.table('dc'), function(marvelRow, dcRow) {
///     return marvelRow('strength').lt(dcRow('strength'))
/// }).zip().run(conn, callback)
/// </code></example>
        public InnerJoin (Arguments args, OptArgs optargs)
         : base(TermType.INNER_JOIN, args, optargs) {
        }


    



    


    

    


    
    }
}
