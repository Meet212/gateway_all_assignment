//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnnotationCrud.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Emp
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [DisplayName("Employee Age")]
        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 60, ErrorMessage = "Please enter range between 18-60.")]
        public int Age { get; set; }

        [DisplayName("Employee Date-Of-Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "DOB is Required")]
        [DataType(DataType.Date)]

        public System.DateTime DOB { get; set; }

        [DisplayName("Employee Gender")]
        [Required(ErrorMessage = "Gender is Required")]

        public string Gender { get; set; }

        [DisplayName("Employee Mobile-No")]
        [Required(ErrorMessage = "Mobile-No is Required")]
        [DataType(DataType.PhoneNumber)]

        public long Mobile_No { get; set; }

        [DisplayName("Employee Email")]
        [Required(ErrorMessage = "Email is Required")]

        public string Email { get; set; }

        [DisplayName("Employee Password")]
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Employee Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password",ErrorMessage ="Password Is Mis-Match")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Employee Designation")]
        [Required(ErrorMessage = "Designation is Required")]

        public string Designation { get; set; }

        [DisplayName("Employee Address")]
        [Required(ErrorMessage = "Address is Required")]
        [DataType(DataType.MultilineText)]

        public string Address { get; set; }

        [DisplayName("Employee Image")]

        public string Image_path { get; set; }


        public HttpPostedFileBase ImageFile { get; set; }
    }
}
