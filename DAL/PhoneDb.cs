namespace Phone.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhoneDb : DbContext
    {
        public PhoneDb()
            : base("name=PhoneDbConnectionString")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address_line_1)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address_line_2)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Pincode)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.State)
                .IsUnicode(false);
        }
    }
}
