using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BooksAPI.Models
{
    public partial class BooksDBContext : DbContext
    {
        //public BooksDBContext()
        //{
        //}

        public BooksDBContext(DbContextOptions<BooksDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }


        //on peux supprimer OnConfiguring
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("server=.\\SQLSERVER; database=BooksDB; integrated security=true");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>(entity =>
        //    {
        //        entity.Property(e => e.Author).HasMaxLength(50);

        //        entity.Property(e => e.PublishedAt).HasColumnType("datetime");

        //        entity.Property(e => e.Title).HasMaxLength(50);
        //    });
        //}
    }
}
