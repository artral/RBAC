namespace RBAC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RBAC : DbContext
    {
        public RBAC()
            : base("name=RBAC_Model")
        {
        }

        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>()
                .Property(e => e.Permission_Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Role>()
                .Property(e => e.Role_Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.User_Id)
                .HasPrecision(18, 0);
        }

        
    }
}
