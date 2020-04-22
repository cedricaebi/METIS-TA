using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCore.Model.Oracle
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Invoiceline> Invoiceline { get; set; }
        public virtual DbSet<Mediatype> Mediatype { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<Playlisttrack> Playlisttrack { get; set; }
        public virtual DbSet<Track> Track { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=chinook;Password=myNiceSQLPassword123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:DefaultSchema", "CHINOOK");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("ALBUM");

                entity.HasIndex(e => e.Albumid)
                    .HasName("PK_ALBUM")
                    .IsUnique();

                entity.Property(e => e.Albumid)
                    .HasColumnName("ALBUMID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Artistid)
                    .HasColumnName("ARTISTID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(160)");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Album)
                    .HasForeignKey(d => d.Artistid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALBUMARTISTID");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("ARTIST");

                entity.HasIndex(e => e.Artistid)
                    .HasName("PK_ARTIST")
                    .IsUnique();

                entity.Property(e => e.Artistid)
                    .HasColumnName("ARTISTID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(120)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.HasIndex(e => e.Customerid)
                    .HasName("PK_CUSTOMER")
                    .IsUnique();

                entity.Property(e => e.Customerid)
                    .HasColumnName("CUSTOMERID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("VARCHAR2(24)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("VARCHAR2(24)");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("POSTALCODE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Supportrepid)
                    .HasColumnName("SUPPORTREPID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Supportrep)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.Supportrepid)
                    .HasConstraintName("FK_CUSTOMERSUPPORTREPID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.HasIndex(e => e.Employeeid)
                    .HasName("PK_EMPLOYEE")
                    .IsUnique();

                entity.Property(e => e.Employeeid)
                    .HasColumnName("EMPLOYEEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("BIRTHDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasColumnType("VARCHAR2(24)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("VARCHAR2(24)");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("POSTALCODE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Reportsto)
                    .HasColumnName("REPORTSTO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(30)");

                entity.HasOne(d => d.ReportstoNavigation)
                    .WithMany(p => p.InverseReportstoNavigation)
                    .HasForeignKey(d => d.Reportsto)
                    .HasConstraintName("FK_EMPLOYEEREPORTSTO");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("GENRE");

                entity.HasIndex(e => e.Genreid)
                    .HasName("PK_GENRE")
                    .IsUnique();

                entity.Property(e => e.Genreid)
                    .HasColumnName("GENREID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(120)");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("INVOICE");

                entity.HasIndex(e => e.Invoiceid)
                    .HasName("PK_INVOICE")
                    .IsUnique();

                entity.Property(e => e.Invoiceid)
                    .HasColumnName("INVOICEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Billingaddress)
                    .HasColumnName("BILLINGADDRESS")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Billingcity)
                    .HasColumnName("BILLINGCITY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Billingcountry)
                    .HasColumnName("BILLINGCOUNTRY")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Billingpostalcode)
                    .HasColumnName("BILLINGPOSTALCODE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Billingstate)
                    .HasColumnName("BILLINGSTATE")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Customerid)
                    .HasColumnName("CUSTOMERID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Invoicedate)
                    .HasColumnName("INVOICEDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("NUMBER(10,2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INVOICECUSTOMERID");
            });

            modelBuilder.Entity<Invoiceline>(entity =>
            {
                entity.ToTable("INVOICELINE");

                entity.HasIndex(e => e.Invoicelineid)
                    .HasName("PK_INVOICELINE")
                    .IsUnique();

                entity.Property(e => e.Invoicelineid)
                    .HasColumnName("INVOICELINEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Invoiceid)
                    .HasColumnName("INVOICEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Trackid)
                    .HasColumnName("TRACKID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("UNITPRICE")
                    .HasColumnType("NUMBER(10,2)");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Invoiceline)
                    .HasForeignKey(d => d.Invoiceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INVOICELINEINVOICEID");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.Invoiceline)
                    .HasForeignKey(d => d.Trackid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INVOICELINETRACKID");
            });

            modelBuilder.Entity<Mediatype>(entity =>
            {
                entity.ToTable("MEDIATYPE");

                entity.HasIndex(e => e.Mediatypeid)
                    .HasName("PK_MEDIATYPE")
                    .IsUnique();

                entity.Property(e => e.Mediatypeid)
                    .HasColumnName("MEDIATYPEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(120)");
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("PLAYLIST");

                entity.HasIndex(e => e.Playlistid)
                    .HasName("PK_PLAYLIST")
                    .IsUnique();

                entity.Property(e => e.Playlistid)
                    .HasColumnName("PLAYLISTID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(120)");
            });

            modelBuilder.Entity<Playlisttrack>(entity =>
            {
                entity.HasKey(e => new { e.Trackid, e.Playlistid });

                entity.ToTable("PLAYLISTTRACK");

                entity.HasIndex(e => new { e.Playlistid, e.Trackid })
                    .HasName("PK_PLAYLISTTRACK")
                    .IsUnique();

                entity.Property(e => e.Trackid)
                    .HasColumnName("TRACKID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Playlistid)
                    .HasColumnName("PLAYLISTID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.Playlisttrack)
                    .HasForeignKey(d => d.Playlistid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PLAYLISTTRACKPLAYLISTID");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.Playlisttrack)
                    .HasForeignKey(d => d.Trackid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PLAYLISTTRACKTRACKID");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable("TRACK");

                entity.HasIndex(e => e.Trackid)
                    .HasName("PK_TRACK")
                    .IsUnique();

                entity.Property(e => e.Trackid)
                    .HasColumnName("TRACKID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Albumid)
                    .HasColumnName("ALBUMID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Bytes)
                    .HasColumnName("BYTES")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Composer)
                    .HasColumnName("COMPOSER")
                    .HasColumnType("VARCHAR2(220)");

                entity.Property(e => e.Genreid)
                    .HasColumnName("GENREID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Mediatypeid)
                    .HasColumnName("MEDIATYPEID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Milliseconds)
                    .HasColumnName("MILLISECONDS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("UNITPRICE")
                    .HasColumnType("NUMBER(10,2)");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.Albumid)
                    .HasConstraintName("FK_TRACKALBUMID");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.Genreid)
                    .HasConstraintName("FK_TRACKGENREID");

                entity.HasOne(d => d.Mediatype)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.Mediatypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRACKMEDIATYPEID");
            });
        }
    }
}
