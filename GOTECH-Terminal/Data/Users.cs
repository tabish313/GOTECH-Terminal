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
    [Table(Name = "Users")]
    public class Users
    {
        [Display(Name ="ID")]
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Display(Name = "UserId")]
        [Column(Name = "UserId", DbType = "VARCHAR")]
        public string UserId { get; set; }

        [Display(Name = "Password")]
        [Column(Name = "Password", DbType = "VARCHAR")]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Column(Name = "Email", DbType = "VARCHAR")]
        public string Email { get; set; }
    }
}
