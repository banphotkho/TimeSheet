using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String ProjectCode { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public String Descriptions { get; set; }
        public int ProjectTypeId  { get; set; } //Type of Proejct Enhance, Project, Service
        [Column(TypeName = "nvarchar(100)")]
        public String ReferenceNo { get; set; }
        public int ChannelId { get; set; }
        public int DepartmentId { get; set; } //Owner from
        public DateTime CrtDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String CrtUser { get; set; }
    }
}
