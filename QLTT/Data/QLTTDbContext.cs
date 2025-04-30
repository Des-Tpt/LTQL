using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class QLTTDbContext : DbContext
    {
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<Idol> Idol { get; set; }
        public DbSet<CongTy> CongTy { get; set; }
        public DbSet<Kenh> Kenh { get; set; }
        public DbSet<Merch> Merch { get; set; }
        public DbSet<SuKien> SuKien { get; set; }
        public DbSet<IdolSuKien> IdolSuKien { get; set; }
        public DbSet<NhaTaiTro> NhaTaiTro { get; set; }
        public DbSet<DanhTinh> DanhTinh { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdolSuKien>().HasKey(isk => new { isk.IdolId, isk.SuKienID });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLTTConnection"].ConnectionString);
        }
    }
}