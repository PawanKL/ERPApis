
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
    
public partial class Attendance
{

    public int AttendanceID { get; set; }

    public System.DateTime AttendanceDate { get; set; }

    public string AttendanceStatus { get; set; }

    public int ClassDuration { get; set; }

    public int EnrollmentID { get; set; }



    public virtual CourseEnrollment CourseEnrollment { get; set; }

}

}
