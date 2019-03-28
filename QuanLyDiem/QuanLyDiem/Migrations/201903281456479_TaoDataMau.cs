namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoDataMau : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (1, N'CÔNG NGHỆ THÔNG TIN')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (2, N'DU LỊCH')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (3, N'KẾ TOÁN')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (4, N'QUẢN TRỊ KINH DOANH')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (5, N'ANH NGỮ')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (6, N'LUẬT')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (7, N'KIẾN TRÚC - MỸ THUẬT')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (8, N'XÂY DỰNG')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (9, N'HỆ THỐNG THÔNG TIN QUẢN LÝ')");
            Sql("INSERT INTO KHOAS(Id, TenKhoa) VALUES (10, N'KHXH & NHÂN VĂN')");


            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (1, N'CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (2, N'LẬP TRÌNH WINDOWS')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (3, N'LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (4, N'QUẢN TRỊ HỌC')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (5, N'QUẢN TRỊ KINH DOANH')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (6, N'TOÁN CAO CẤP 1')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (7, N'TOÁN CAO CẤP 2')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (8, N'TOÁN CAO CẤP 3')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (9, N'VẬT LÝ ĐẠI CƯƠNG 1')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (10, N'VẬT LÝ ĐẠI CƯƠNG 2')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (11, N'LÝ THUYẾT ĐỒ THỊ')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (12, N'GIÁO DỤC THỂ CHẤT')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (13, N'HÓA ĐẠI CƯƠNG')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (14, N'TIẾNG ANH 1')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (15, N'TIẾNG ANH 2')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (16, N'TIẾNG ANH 3')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (17, N'TIẾNG ANH 4')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (18, N'TIẾNG ANH 5')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (19, N'PHƯƠNG PHÁP TÍNH')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (20, N'XÁC SUẤT THỐNG KÊ')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (21, N'LẬP TRÌNH WEB')");
            Sql("INSERT INTO MONHOCS(Id, TenMonHoc) VALUES (22, N'THƯƠNG MẠI ĐIỆN TỬ')");


            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (1, '16HTH01', 31, 1)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (2, '16HTH02', 32, 2)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (3, '16HTH03', 33, 3)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (4, '16HTH04', 34, 4)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (5, '16HTH05', 35, 5)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (6, '16HTH06', 36, 6)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (7, '16HTH07', 37, 7)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (8, '16HTH08', 38, 8)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (9, '16HTH09', 39, 9)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (10, '16HTH10', 40, 10)");
            Sql("INSERT INTO LOPS(Id, TenLop, SiSo, KhoaID) VALUES (11, '16HTH11', 41, 1)");


            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (1, 5, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (2, 4, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (3, 3, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (4, 2, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (5, 1, 3, 45)");


            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(1, N'Lê Khải', N'Hoàn', '11/27/1991', N'Đồng Nai', '0129821897',1, '2016', 1)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(2, N'Trần Ngọc', N'Thủy', '11/27/1992', N'Bình Dương', '0987613452',1, '2015', 1)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(3, N'Võ Thị', N'Loan', '11/27/1993', N'Vĩnh Long', '0192837465',1, '2014', 1)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(4, N'Chu Hoàng', N'Nhật', '11/27/1994', N'Trà Vinh', '0495867264',1, '2013', 1)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(5, N'Nguyễn Hoàng', N'Tuyên', '11/27/1995', N'TP.HCM', '0678356109',1, '2012', 2)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(6, N'Nguyễn Thị', N'Thùy', '11/27/1996', N'Tây Ninh', '0465772615',1, '2011', 2)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(7, N'Phạm Đào Anh', N'Hương', '11/27/1997', N'Long An', '0350095678',1, '2010', 3)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(8, N'Dương Công', N'Hải', '11/27/1998', N'Cần Thơ', '0357564388',1, '2009', 3)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(9, N'Lê Vương', N'Thái', '11/27/1999', N'Sóc Trăng', '0355436456',1, '2008', 3)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(10, N'Nguyễn Hoài', N'Nam', '11/27/2000', N'Hà Nội', '0350647118',1, '2007', 4)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(11, N'Đỗ Bùi', N'Quý', '11/27/2001', N'Hà Nam', '0358473567',1, '2016', 4)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(12, N'Trần Hoàng', N'Mai', '11/27/2002', N'Cao Bằng', '0357534854',1, '2015', 4)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(13, N'Đồng Hữu', N'Quân', '11/27/2003', N'Lào Cai', '0357183746',1, '2013', 5)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(14, N'Phạm Đào Anh', N'Hương', '11/27/2004', N'Sơn La', '0357375616',1, '2015', 5)");
            Sql("INSERT INTO SINHVIENS(Id, Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(15, N'Phạm Đào Anh', N'Hương', '11/27/2005', N'Đà Lạt', '0357254616',1, '2015', 5)");

            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (1, 1, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (2, 2, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (3, 3, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (4, 4, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (5, 5, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (1, 2, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (2, 3, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (3, 4, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (4, 5, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (5, 6, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (1, 3, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (2, 4, 1, 1)");
            Sql("INSERT INTO KETQUAS(SinhVienId, MonHocId, LanThi, DiemThi) VALUES (3, 5, 1, 1)");
        }


        public override void Down()
        {
            Sql("DELETE KETQUAS");
            Sql("DELETE SINHVIENS");
            Sql("DELETE KHOAMONS");
            Sql("DELETE LOPS");
            Sql("DELETE MONHOCS");
            Sql("DELETE KHOAS");
        }
    }
}
