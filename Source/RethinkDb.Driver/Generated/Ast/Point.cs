












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

    public class Point : ReqlExpr {

    
    
    
/// <summary>
/// <para>Construct a geometry object of type Point. The point is specified by two floating point numbers, the longitude (&minus;180 to 180) and the latitude (&minus;90 to 90) of the point on a perfect sphere.</para>
/// </summary>
/// <example><para>Example: Define a point.</para>
/// <code>r.table('geo').insert({
///     id: 1,
///     name: 'San Francisco',
///     location: r.point(-122.423246,37.779388)
/// }).run(conn, callback);
/// </code></example>
        public Point (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Point. The point is specified by two floating point numbers, the longitude (&minus;180 to 180) and the latitude (&minus;90 to 90) of the point on a perfect sphere.</para>
/// </summary>
/// <example><para>Example: Define a point.</para>
/// <code>r.table('geo').insert({
///     id: 1,
///     name: 'San Francisco',
///     location: r.point(-122.423246,37.779388)
/// }).run(conn, callback);
/// </code></example>
        public Point (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Point. The point is specified by two floating point numbers, the longitude (&minus;180 to 180) and the latitude (&minus;90 to 90) of the point on a perfect sphere.</para>
/// </summary>
/// <example><para>Example: Define a point.</para>
/// <code>r.table('geo').insert({
///     id: 1,
///     name: 'San Francisco',
///     location: r.point(-122.423246,37.779388)
/// }).run(conn, callback);
/// </code></example>
        public Point (Arguments args, OptArgs optargs)
         : base(TermType.POINT, args, optargs) {
        }


    



    


    

    


    
    }
}
