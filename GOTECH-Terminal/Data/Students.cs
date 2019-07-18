using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTECH.Data
{
    [Table(Name = "Students")]
    public class Students
    {
        [Display(Name = "ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "FatherName", DbType = "VARCHAR")]
        public string FatherName { get; set; }

        [Column(Name = "CNIC", DbType = "VARCHAR")]
        public string CNIC { get; set; }

        [Column(Name = "Email", DbType = "VARCHAR")]
        public string Email { get; set; }

        [Column(Name = "Contact", DbType = "VARCHAR")]
        public string Contact { get; set; }

        [Column(Name = "Course_Id", DbType = "INTEGER")]
        public int Course_Id { get; set; }

        [Column(Name = "Student_Id", DbType = "VARCHAR")]
        public string Student_Id { get; set; }
    }
}
