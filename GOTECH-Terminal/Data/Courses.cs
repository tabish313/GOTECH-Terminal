using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTECH.Data
{
    [Table(Name = "Courses")]
   public class Courses
    {
        [Display(Name = "ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "CourseCode", DbType = "VARCHAR")]
        public string CourseCode { get; set; }

        [Column(Name = "CourseName", DbType = "VARCHAR")]
        public string CourseName { get; set; }

        [Column(Name = "Duration", DbType = "VARCHAR")]
        public string Duration { get; set; }

        [Column(Name = "Trainer", DbType = "VARCHAR")]
        public string Trainer { get; set; }

        [Column(Name = "EntryDate", DbType = "VARCHAR")]
        public string EntryDate { get; set; }

        [Column(Name = "Status", DbType = "VARCHAR")]
        public string Status { get; set; }

        [Column(Name = "Outline", DbType = "BINARY")]
        public byte[] Outline { get; set; }

        [Column(Name = "Mode", DbType = "VARCHAR")]
        public string Mode { get; set; }

        [Column(Name = "outline_file_type", DbType = "VARCHAR")]
        public string outline_file_type { get; set; }

        [Column(Name = "Revenue", DbType = "INTEGER")]
        public int Revenue { get; set; }
    }
}
