using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kyrsach
{
    public partial class TaskMgrADO : DbContext
    {
        public TaskMgrADO()
            : base("name=TaskMgrADO")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Employees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Employees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Positions>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Positions)
                .WillCascadeOnDelete(false);
        }
    }
}
