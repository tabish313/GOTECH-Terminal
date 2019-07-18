using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Data
{
    public class DbEntities : DbContext
    {
        public DbEntities() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = Application.StartupPath + @"\Database\database.data", ForeignKeys = true }.ConnectionString

            }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Trainers> Trainers { get; set; }

        public DbSet<Students> Students { get; set; }

        public DbSet<BusinessPlans> BusinessPlans { get; set; }

        public DbSet<Goals> Goals { get; set; }

        public DbSet<GoalsInfo> GoalsInfo { get; set; }
    }
}
