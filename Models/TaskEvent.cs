using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models
{
    public class TaskEvent
    {
        [Key]
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public int ProjectId { get; set; }
        public int ActivitiesId { get; set; }
        public decimal Effort { get; set; }
        public String Remark { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CrtDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String CrtUser { get; set; }

    }
}
