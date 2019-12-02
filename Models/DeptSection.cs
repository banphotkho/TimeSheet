using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models
{
    public class DeptSection
    {
        [Key]
		public int Id { get; set; }
        [Column(TypeName ="nvarchar(200)")]
        public String SectionName { get; set; }
        public DateTime CrtDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String CrtUser { get; set; }
    }
}
