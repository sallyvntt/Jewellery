using EP_Jewellery.Areas;
using EP_Jewellery.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EP_Jewellery.Db
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BrandMst> BrandMsts { get; set; }
        public DbSet<CardMst> CardMsts { get; set; }
        public DbSet<CertifyMst> CertifyMsts { get; set; }
        public DbSet<DimInfoMst> DimInfoMsts { get; set; }
        public DbSet<DimMst> DimMsts { get; set; }
        public DbSet<DimQltySubMst> DimQltySubMsts { get; set; }
        public DbSet<DimQltyMst> DimQtyMsts { get; set; }
        public DbSet<GoldKrtMst> GoldKrtMsts { get; set; }
        public DbSet<ItemMst> ItemMsts { get; set; }
        public DbSet<JewelTypeMst> JewelTypeMsts { get; set; }
        public DbSet<ProdMst> ProdMsts { get; set; }
        public DbSet<StoneMst> StoneMsts { get; set; }
        public DbSet<StoneQltyMst> StoneQltyMsts { get; set; }


    }
}
