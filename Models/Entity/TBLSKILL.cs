//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CV_MVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLSKILL
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This area can't be empty")]
        public string Skill { get; set; }
        [Required(ErrorMessage = "This area can't be empty")]
        public Nullable<byte> Percentage { get; set; }
    }
}
