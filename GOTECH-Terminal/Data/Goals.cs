using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTECH.Data
{
     [Table(Name = "Goals")]
    public class Goals
    {
        [Display(Name = "ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "Percentage", DbType = "INTEGER")]
        public int Percentage { get; set; }

        [Column(Name = "Duration", DbType = "VARCHAR")]
        public string Duration { get; set; }

        [Column(Name = "StartDate", DbType = "DATETIME")]
        public DateTime StartDate { get; set; }

        [Column(Name = "EndDate", DbType = "DATETIME")]
        public DateTime EndDate { get; set; }
    }
}
