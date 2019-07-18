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
    [Table(Name = "Trainers")]
    public class Trainers
    {
        [Display(Name = "ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "CV", DbType = "BINARY")]
        public byte[] CV { get; set; }

        [Column(Name = "Profile", DbType = "BINARY")]
        public byte[] Profile { get; set; }

        [Column(Name = "Role", DbType = "VARCHAR")]
        public string Role { get; set; }

        [Column(Name = "Mode", DbType = "VARCHAR")]
        public string Mode { get; set; }

        [Column(Name = "ModeValue", DbType = "VARCHAR")]
        public string ModeValue { get; set; }

        [Column(Name = "cv_file_type", DbType = "VARCHAR")]
        public string cv_file_type { get; set; }

    }
}
