//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Attendance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class byinterval
    {
        public string pin2 { get; set; }
        public string pin { get; set; }
        public Nullable<System.TimeSpan> thetime1 { get; set; }
        public Nullable<System.TimeSpan> thetime2 { get; set; }
        public string device_name1 { get; set; }
        public string device_name2 { get; set; }
        public string DEPTNAME { get; set; }
        public string Name { get; set; }
        public long id { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [System.ComponentModel.DataAnnotations.DataType(DataType.Date)]
        public DateTime? thedate1 { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [System.ComponentModel.DataAnnotations.DataType(DataType.Date)]
        public DateTime? thedate2 { get; set; }
    }
}
