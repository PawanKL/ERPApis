
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
    
public partial class Programme
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Programme()
    {

        this.Students = new HashSet<Student>();

    }


    public int ProgrammeID { get; set; }

    public string ProgrammeName { get; set; }

    public int DepartmentID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Student> Students { get; set; }

}

}
