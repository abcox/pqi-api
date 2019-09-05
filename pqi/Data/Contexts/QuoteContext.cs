using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pqi.Data.Contexts
{
    public partial class QuoteContext : DbContext
    {
        public QuoteContext()
        {
        }

        public QuoteContext(DbContextOptions<QuoteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblPriceBookMain> TblPriceBookMain { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local)\\sqldev_12;Database=pqi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<TblPriceBookMain>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("TblPriceBook_Main");

                entity.Property(e => e.PartId).HasColumnName("Part_ID");

                entity.Property(e => e.AltPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[RCost]')");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Expense).HasDefaultValueSql("((0))");

                entity.Property(e => e.Features)
                    .HasColumnName("features")
                    .HasColumnType("text");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemDiscountRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LandedCost)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[RLandedCost]')");

                entity.Property(e => e.Lbcode)
                    .HasColumnName("LBCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcost)
                    .HasColumnName("LBCost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lbdiscount)
                    .HasColumnName("LBDiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lbprice)
                    .HasColumnName("LBPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lbquantity)
                    .HasColumnName("LBQuantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LongDescription).HasColumnType("text");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[RPrice]')");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SellPrice)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.ShowInBom)
                    .HasColumnName("ShowInBOM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowInQuote).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartingMargin).HasDefaultValueSql("((0.33))");

                entity.Property(e => e.SupplierCurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CDN')");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Units)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.ViewInWeb)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.XlabourHrs)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });
        }
    }
}
