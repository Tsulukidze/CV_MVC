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

    public partial class TBLEDUCATION
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This area can't be empty")]
        public string Header { get; set; }
        public string SubHeader1 { get; set; }
        public string SubHeader2 { get; set; }
        public string GPA { get; set; }
        public string Date { get; set; }
    }
}
