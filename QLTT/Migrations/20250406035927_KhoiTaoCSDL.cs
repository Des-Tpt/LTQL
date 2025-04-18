﻿using System;
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
                    TaiKhoang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.NguoiDungID);
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
                    IdolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuKien", x => x.SukienId);
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
                    DangHoatDong = table.Column<bool>(type: "bit", nullable: false),
                    CongTyId = table.Column<int>(type: "int", nullable: false),
                    DanhTinhId = table.Column<int>(type: "int", nullable: false),
                    KenhId = table.Column<int>(type: "int", nullable: false)
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
                name: "NhaTaiTro",
                columns: table => new
                {
                    NhaTaiTroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaTaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuKienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaTaiTro", x => x.NhaTaiTroId);
                    table.ForeignKey(
                        name: "FK_NhaTaiTro_SuKien_SuKienId",
                        column: x => x.SuKienId,
                        principalTable: "SuKien",
                        principalColumn: "SukienId",
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

            migrationBuilder.CreateTable(
                name: "Kenh",
                columns: table => new
                {
                    KenhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NenTang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlKenh = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTonKho = table.Column<int>(type: "int", nullable: false),
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
                name: "BuoiPhatSong",
                columns: table => new
                {
                    BuoiPhatSongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LuotXem = table.Column<int>(type: "int", nullable: false),
                    KenhId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuoiPhatSong", x => x.BuoiPhatSongId);
                    table.ForeignKey(
                        name: "FK_BuoiPhatSong_Kenh_KenhId",
                        column: x => x.KenhId,
                        principalTable: "Kenh",
                        principalColumn: "KenhId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuoiPhatSong_KenhId",
                table: "BuoiPhatSong",
                column: "KenhId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhTinh_IdolId",
                table: "DanhTinh",
                column: "IdolId",
                unique: true);

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
                column: "IdolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Merch_IdolId",
                table: "Merch",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_NhaTaiTro_SuKienId",
                table: "NhaTaiTro",
                column: "SuKienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuoiPhatSong");

            migrationBuilder.DropTable(
                name: "DanhTinh");

            migrationBuilder.DropTable(
                name: "IdolSuKien");

            migrationBuilder.DropTable(
                name: "Merch");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "NhaTaiTro");

            migrationBuilder.DropTable(
                name: "Kenh");

            migrationBuilder.DropTable(
                name: "SuKien");

            migrationBuilder.DropTable(
                name: "Idol");

            migrationBuilder.DropTable(
                name: "CongTy");
        }
    }
}
