
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
    
public partial class daysofweek
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public daysofweek()
    {

        this.Timetables = new HashSet<Timetable>();

    }


    public int dayID { get; set; }

    public Nullable<int> dayvalue { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Timetable> Timetables { get; set; }

}

}