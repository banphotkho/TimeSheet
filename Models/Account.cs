using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public String EmployeeCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String Username { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public String Fullname { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public String Passwords { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int RoleId { get; set; }
        public DateTime CrtDate { get; set; }
        public String CrtUser { get; set; }

    }
}

