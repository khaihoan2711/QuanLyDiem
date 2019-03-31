namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhoiTaoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KetQuas",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false),
                        MonHocId = c.Int(nullable: false),
                        LanThi = c.Int(nullable: false),
                        DiemThi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SinhVienId, t.MonHocId, t.LanThi })
                .ForeignKey("dbo.MonHocs", t => t.MonHocId, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.SinhVienId, cascadeDelete: true)
                .Index(t => t.SinhVienId)
                .Index(t => t.MonHocId);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ho = c.String(),
                        Ten = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        DiaChi = c.String(),
                        DienThoai = c.String(),
                        GioiTinh = c.Int(nullable: false),
                        NienKhoa = c.Int(nullable: false),
                        LopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lops", t => t.LopId, cascadeDelete: true)
                .Index(t => t.LopId);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                        SiSo = c.Int(nullable: false),
                        KhoaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KhoaMons",
                c => new
                    {
                        KhoaId = c.Int(nullable: false),
                        MonHocId = c.Int(nullable: false),
                        TinChi = c.Int(nullable: false),
                        TongSoTietHoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KhoaId, t.MonHocId })
                .ForeignKey("dbo.Khoas", t => t.KhoaId, cascadeDelete: true)
                .ForeignKey("dbo.MonHocs", t => t.MonHocId, cascadeDelete: true)
                .Index(t => t.KhoaId)
                .Index(t => t.MonHocId);
            
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KhoaMonViewModels",
                c => new
                    {
                        Khoa = c.Int(nullable: false),
                        MonHoc = c.Int(nullable: false),
                        TinChi = c.Int(nullable: false),
                        TongSoTietHoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Khoa, t.MonHoc });
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.KhoaMons", "MonHocId", "dbo.MonHocs");
            DropForeignKey("dbo.KhoaMons", "KhoaId", "dbo.Khoas");
            DropForeignKey("dbo.KetQuas", "SinhVienId", "dbo.SinhViens");
            DropForeignKey("dbo.SinhViens", "LopId", "dbo.Lops");
            DropForeignKey("dbo.KetQuas", "MonHocId", "dbo.MonHocs");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.KhoaMons", new[] { "MonHocId" });
            DropIndex("dbo.KhoaMons", new[] { "KhoaId" });
            DropIndex("dbo.SinhViens", new[] { "LopId" });
            DropIndex("dbo.KetQuas", new[] { "MonHocId" });
            DropIndex("dbo.KetQuas", new[] { "SinhVienId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.KhoaMonViewModels");
            DropTable("dbo.Khoas");
            DropTable("dbo.KhoaMons");
            DropTable("dbo.Lops");
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.KetQuas");
        }
    }
}
