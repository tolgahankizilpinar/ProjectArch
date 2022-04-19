using Arch.Core.Entities.Access;
using Arch.Core.Entities.Common;
using Arch.Core.Entities.Docs;
using Arch.Core.Entities.Log;
using Arch.Core.Entities.SysProj;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Data.Context
{
    public class ArchContext : DbContext
    {
        private readonly ArchContext _context;
        DbContextTransaction _transaction;

        public ArchContext() : base("name=ArchEntities")
        {

        }

        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; } 
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; } 
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLog { get; set; }
        public virtual DbSet<RequestDetailLog> RequestDetailLog { get; set; }
        public virtual DbSet<RequestLog> RequestLog { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Lookup> Lookup { get; set; }
        public virtual DbSet<LookupList> LookupList { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().ToTable("Permission", "access");
            modelBuilder.Entity<Role>().ToTable("Role", "access");
            modelBuilder.Entity<RolePermission>().ToTable("RolePermission", "access");
            modelBuilder.Entity<User>().ToTable("User", "access");
            modelBuilder.Entity<UserRole>().ToTable("UserRole", "access");

            modelBuilder.Entity<Person>().ToTable("Person", "common");
            modelBuilder.Entity<Unit>().ToTable("Unit", "common");

            modelBuilder.Entity<Media>().ToTable("Media", "docs");

            modelBuilder.Entity<ExceptionLog>().ToTable("ExceptionLog", "log");
            modelBuilder.Entity<RequestDetailLog>().ToTable("RequestDetailLog", "log");
            modelBuilder.Entity<RequestLog>().ToTable("RequestLog", "log");

            modelBuilder.Entity<Language>().ToTable("Language", "sysproj");
            modelBuilder.Entity<Lookup>().ToTable("Lookup", "sysproj");
            modelBuilder.Entity<LookupList>().ToTable("LookupList", "sysproj");
            modelBuilder.Entity<Parameter>().ToTable("Parameter", "sysproj");
            modelBuilder.Entity<Resource>().ToTable("Resource", "sysproj");


            base.OnModelCreating(modelBuilder);
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }
    }
}
