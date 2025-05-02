using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTT.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CongTy",
                columns: table => new
                {
                    CongTyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTy", x => x.CongTyId);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    NguoiDungID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.NguoiDungID);
                });

            migrationBuilder.CreateTable(
                name: "NhaTaiTro",
                columns: table => new
                {
                    NhaTaiTroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaTaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaTaiTro", x => x.NhaTaiTroId);
                });

            migrationBuilder.CreateTable(
                name: "Idol",
                columns: table => new
                {
                    IdolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenIdol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayRaMat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DangHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongTyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idol", x => x.IdolId);
                    table.ForeignKey(
                        name: "FK_Idol_CongTy_CongTyId",
                        column: x => x.CongTyId,
                        principalTable: "CongTy",
                        principalColumn: "CongTyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuKien",
                columns: table => new
                {
                    SukienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSukien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayToChuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhaTaiTroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuKien", x => x.SukienId);
                    table.ForeignKey(
                        name: "FK_SuKien_NhaTaiTro_NhaTaiTroId",
                        column: x => x.NhaTaiTroId,
                        principalTable: "NhaTaiTro",
                        principalColumn: "NhaTaiTroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhTinh",
                columns: table => new
                {
                    DanhTinhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenThat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhTinh", x => x.DanhTinhId);
                    table.ForeignKey(
                        name: "FK_DanhTinh_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "IdolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kenh",
                columns: table => new
                {
                    KenhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKenh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NenTang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlKenh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrangKenh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongNguoiDangKy = table.Column<int>(type: "int", nullable: false),
                    TongLuotXem = table.Column<int>(type: "int", nullable: false),
                    IdolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kenh", x => x.KenhId);
                    table.ForeignKey(
                        name: "FK_Kenh_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "IdolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Merch",
                columns: table => new
                {
                    MerchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMerch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayPhatHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merch", x => x.MerchId);
                    table.ForeignKey(
                        name: "FK_Merch_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "IdolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdolSuKien",
                columns: table => new
                {
                    IdolId = table.Column<int>(type: "int", nullable: false),
                    SuKienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdolSuKien", x => new { x.IdolId, x.SuKienID });
                    table.ForeignKey(
                        name: "FK_IdolSuKien_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "IdolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdolSuKien_SuKien_SuKienID",
                        column: x => x.SuKienID,
                        principalTable: "SuKien",
                        principalColumn: "SukienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhTinh_IdolId",
                table: "DanhTinh",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_Idol_CongTyId",
                table: "Idol",
                column: "CongTyId");

            migrationBuilder.CreateIndex(
                name: "IX_IdolSuKien_SuKienID",
                table: "IdolSuKien",
                column: "SuKienID");

            migrationBuilder.CreateIndex(
                name: "IX_Kenh_IdolId",
                table: "Kenh",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_Merch_IdolId",
                table: "Merch",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_SuKien_NhaTaiTroId",
                table: "SuKien",
                column: "NhaTaiTroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhTinh");

            migrationBuilder.DropTable(
                name: "IdolSuKien");

            migrationBuilder.DropTable(
                name: "Kenh");

            migrationBuilder.DropTable(
                name: "Merch");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "SuKien");

            migrationBuilder.DropTable(
                name: "Idol");

            migrationBuilder.DropTable(
                name: "NhaTaiTro");

            migrationBuilder.DropTable(
                name: "CongTy");
        }
    }
}
