using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTECH.Data
{
     [Table(Name = "GoalsInfo")]
    public class GoalsInfo
    {
        [Display(Name = "ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "Info", DbType = "VARCHAR")]
        public string Info { get; set; }

        [Column(Name = "Completed", DbType = "BOOL")]
        public bool Completed { get; set; }

        [Column(Name = "Goal_Id", DbType = "INTEGER")]
        public int Goal_Id { get; set; }
    }
}
