
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace IptApis.Models.PointRegistration.PointDataAccess
{

using System;
    using System.Collections.Generic;
    
public partial class Route
{

    public int RouteID { get; set; }

    public Nullable<int> PointID { get; set; }

    public string RouteStop { get; set; }

    public System.TimeSpan RouteTime { get; set; }



    public virtual Point Point { get; set; }

}

}
