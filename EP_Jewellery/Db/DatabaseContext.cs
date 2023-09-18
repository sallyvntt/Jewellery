using EP_Jewellery.Models;
using Microsoft.EntityFrameworkCore;
namespace EP_Jewellery.Db
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<BrandMst> BrandMsts { get; set; }
        public DbSet<CatMst> CatMsts { get; set; }
        public DbSet<CertifyMst> CertifyMsts { get; set; }
        public DbSet<DimMst> DimMsts { get; set; }
        public DbSet<DimQltyMst> DimQltyMsts { get; set; }
        public DbSet<GoldKrtMst> GoldKrtMsts { get; set; }
        public DbSet<ProdMst> ProdMsts { get; set; }
        public DbSet<StoneMst> StoneMsts { get; set; }
        public DbSet<StoneQltyMst> StoneQltyMsts { get; set; }
        public DbSet<ItemMst> Items { get; set; }
        public DbSet<DimInfoMst> DimInfos { get; set; }
        public DbSet<JewelTypeMst> JewelTypes { get; set; }
        public DbSet<DimQltySubMst> DimQltySubMsts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemMst>()
              .HasKey(i => i.Style_Code);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Brand)
                .WithMany()
                .HasForeignKey(i => i.Brand_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Category)
                .WithMany()
                .HasForeignKey(i => i.Cat_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Certify)
                .WithMany()
                .HasForeignKey(i => i.Certify_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.Prod_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.GoldCarat)
                .WithMany()
                .HasForeignKey(i => i.GoldType_ID);
            modelBuilder.Entity<DimMst>()
                .HasOne(d => d.Item)
                .WithMany(i => i.Dimensions)
                .HasForeignKey(d => d.Style_Code);


            modelBuilder.Entity<DimInfoMst>()
                .HasKey(d => d.DimID);

            // Thêm các quan hệ và cấu hình khóa ngoại khác tại đây

            base.OnModelCreating(modelBuilder);
        }
    }
}