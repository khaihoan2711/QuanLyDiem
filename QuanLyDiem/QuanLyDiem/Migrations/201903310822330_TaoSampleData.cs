namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoSampleData : DbMigration
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
            Sql("INSERT INTO LOPS(TenLop, SiSo, KhoaID) VALUES ('16HTH11', 41, 1)");


            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (1, 5, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (2, 4, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (3, 3, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (4, 2, 3, 45)");
            Sql("INSERT INTO KHOAMONS(KhoaID, MonHocID, TinChi, TongSoTietHoc) VALUES (5, 1, 3, 45)");


            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Lê Khải', N'Hoàn', '11/27/1991', N'Đồng Nai', '0129821897',1, '2016', 1)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Trần Ngọc', N'Thủy', '11/27/1992', N'Bình Dương', '0987613452',1, '2015', 1)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Võ Thị', N'Loan', '11/27/1993', N'Vĩnh Long', '0192837465',1, '2014', 1)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Chu Hoàng', N'Nhật', '11/27/1994', N'Trà Vinh', '0495867264',1, '2013', 1)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Nguyễn Hoàng', N'Tuyên', '11/27/1995', N'TP.HCM', '0678356109',1, '2012', 2)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Nguyễn Thị', N'Thùy', '11/27/1996', N'Tây Ninh', '0465772615',1, '2011', 2)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Phạm Đào Anh', N'Hương', '11/27/1997', N'Long An', '0350095678',1, '2010', 3)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Dương Công', N'Hải', '11/27/1998', N'Cần Thơ', '0357564388',1, '2009', 3)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Lê Vương', N'Thái', '11/27/1999', N'Sóc Trăng', '0355436456',1, '2008', 3)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Nguyễn Hoài', N'Nam', '11/27/2000', N'Hà Nội', '0350647118',1, '2007', 4)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Đỗ Bùi', N'Quý', '11/27/2001', N'Hà Nam', '0358473567',1, '2016', 4)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Trần Hoàng', N'Mai', '11/27/2002', N'Cao Bằng', '0357534854',1, '2015', 4)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Đồng Hữu', N'Quân', '11/27/2003', N'Lào Cai', '0357183746',1, '2013', 5)");
            Sql("INSERT INTO SINHVIENS(Ho, Ten, NgaySinh, DiaChi, DienThoai, GioiTinh, NienKhoa, LopId) VALUES(N'Phạm Đào Anh', N'Hương', '11/27/2004', N'Sơn La', '0357375616',1, '2015', 5)");

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

        }
    }
}
