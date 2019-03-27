namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDefaultData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'CÔNG NGHỆ THÔNG TIN')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'DU LỊCH')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'KẾ TOÁN')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'QUẢN TRỊ KINH DOANH')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'ANH NGỮ')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'LUẬT')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'KIẾN TRÚC - MỸ THUẬT')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'XÂY DỰNG')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'HỆ THỐNG THÔNG TIN QUẢN LÝ')");
            Sql("INSERT INTO KHOAS(TenKhoa) VALUES (N'KHXH & NHÂN VĂN')");


            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'LẬP TRÌNH WINDOWS')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'QUẢN TRỊ HỌC')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'QUẢN TRỊ KINH DOANH')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TOÁN CAO CẤP 1')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TOÁN CAO CẤP 2')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TOÁN CAO CẤP 3')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'VẬT LÝ ĐẠI CƯƠNG 1')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'VẬT LÝ ĐẠI CƯƠNG 2')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'LÝ THUYẾT ĐỒ THỊ')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'GIÁO DỤC THỂ CHẤT')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'HÓA ĐẠI CƯƠNG')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TIẾNG ANH 1')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TIẾNG ANH 2')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TIẾNG ANH 3')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TIẾNG ANH 4')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'TIẾNG ANH 5')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'PHƯƠNG PHÁP TÍNH')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'XÁC SUẤT THỐNG KÊ')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'LẬP TRÌNH WEB')");
            Sql("INSERT INTO MONHOCS(TenMonHoc) VALUES (N'THƯƠNG MẠI ĐIỆN TỬ')");


            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH01', 31, 1)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH02', 32, 2)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH03', 33, 3)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH04', 34, 4)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH05', 35, 5)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH06', 36, 6)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH07', 37, 7)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH08', 38, 8)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH09', 39, 9)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH10', 40, 10)");
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH11', 41, 11)");


            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (1, 5, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (2, 4, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (3, 3, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (4, 2, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (5, 1, 3, 45)");
        }
        
        public override void Down()
        {
        }
    }
}
