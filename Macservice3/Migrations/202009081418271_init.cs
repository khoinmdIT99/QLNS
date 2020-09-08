namespace Macservice3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bangchamcong",
                c => new
                    {
                        Mabangcong = c.String(nullable: false, maxLength: 50),
                        Maphongban = c.String(maxLength: 50),
                        Thangchamcong = c.Int(),
                        Nam = c.Int(),
                    })
                .PrimaryKey(t => t.Mabangcong)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .Index(t => t.Maphongban);
            
            CreateTable(
                "dbo.Chitietbangcong",
                c => new
                    {
                        Machitietbangcong = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Mabangcong = c.String(maxLength: 50),
                        Sogiolam = c.Double(),
                        Sogiolamthemngaythuong = c.Double(),
                        Sogiolamthemngaynghi = c.Double(),
                        Sogiolamthemngayle = c.Double(),
                        Songaynghiphep = c.Double(),
                        Maphongban = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Machitietbangcong)
                .ForeignKey("dbo.Bangchamcong", t => t.Mabangcong)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Mabangcong)
                .Index(t => t.Maphongban);
            
            CreateTable(
                "dbo.Phongban",
                c => new
                    {
                        Maphongban = c.String(nullable: false, maxLength: 50),
                        Tenphongban = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Maphongban);
            
            CreateTable(
                "dbo.Chitietphongban",
                c => new
                    {
                        Machitietphongban = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Maphongban = c.String(maxLength: 50),
                        Tungay = c.DateTime(storeType: "date"),
                        Denngay = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Machitietphongban)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Maphongban);
            
            CreateTable(
                "dbo.Thongtinnhansu",
                c => new
                    {
                        Manv = c.String(nullable: false, maxLength: 50),
                        Hoten = c.String(maxLength: 50),
                        Ngaysinh = c.DateTime(storeType: "date"),
                        SDT = c.String(maxLength: 10),
                        Gioitinh = c.String(maxLength: 50),
                        Email = c.String(maxLength: 100),
                        Dantoc = c.String(maxLength: 50),
                        Noisinh = c.String(maxLength: 250),
                        Hokhauthuongtru = c.String(maxLength: 250),
                        Noiohientai = c.String(maxLength: 250),
                        CMND = c.Int(),
                        Ngaycap = c.DateTime(storeType: "date"),
                        Noicap = c.String(maxLength: 50),
                        Maphongban = c.String(maxLength: 50),
                        Machucvu = c.String(maxLength: 50),
                        Matrinhdochuyenmon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Manv)
                .ForeignKey("dbo.Trinhdo_chuyenmon", t => t.Matrinhdochuyenmon)
                .ForeignKey("dbo.Chucvu", t => t.Machucvu)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .Index(t => t.Maphongban)
                .Index(t => t.Machucvu)
                .Index(t => t.Matrinhdochuyenmon);
            
            CreateTable(
                "dbo.Chitietbaohiem",
                c => new
                    {
                        Machitietbaohiem = c.String(nullable: false, maxLength: 50),
                        Mabaohiem = c.String(maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Tungay = c.DateTime(storeType: "date"),
                        Denngay = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Machitietbaohiem)
                .ForeignKey("dbo.Baohiem", t => t.Mabaohiem)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Mabaohiem)
                .Index(t => t.Manv);
            
            CreateTable(
                "dbo.Baohiem",
                c => new
                    {
                        Mabaohiem = c.String(nullable: false, maxLength: 50),
                        Tenbaohiem = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Mabaohiem);
            
            CreateTable(
                "dbo.Chitietchucvu",
                c => new
                    {
                        Machitietchucvu = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Machucvu = c.String(maxLength: 50),
                        Tungay = c.DateTime(storeType: "date"),
                        Denngay = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Machitietchucvu)
                .ForeignKey("dbo.Chucvu", t => t.Machucvu)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Machucvu);
            
            CreateTable(
                "dbo.Chucvu",
                c => new
                    {
                        Machucvu = c.String(nullable: false, maxLength: 50),
                        Tenchucvu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Machucvu);
            
            CreateTable(
                "dbo.Dieudongcongtac",
                c => new
                    {
                        Malichtrinhcongtac = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Maphongban = c.String(maxLength: 50),
                        Machucvu = c.String(maxLength: 50),
                        Matrinhdochuyenmon = c.String(maxLength: 50),
                        Tungay = c.DateTime(storeType: "date"),
                        Denngay = c.DateTime(storeType: "date"),
                        Noicongtac = c.String(maxLength: 50),
                        Noidungcongtac = c.String(maxLength: 250),
                        Trocap = c.Int(),
                    })
                .PrimaryKey(t => t.Malichtrinhcongtac)
                .ForeignKey("dbo.Chucvu", t => t.Machucvu)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .ForeignKey("dbo.Trinhdo_chuyenmon", t => t.Matrinhdochuyenmon)
                .Index(t => t.Manv)
                .Index(t => t.Maphongban)
                .Index(t => t.Machucvu)
                .Index(t => t.Matrinhdochuyenmon);
            
            CreateTable(
                "dbo.Trinhdo_chuyenmon",
                c => new
                    {
                        Matrinhdochuyenmon = c.String(nullable: false, maxLength: 50),
                        Tentrinhdochuyenmon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Matrinhdochuyenmon);
            
            CreateTable(
                "dbo.Chitiettrinhdochuyenmon",
                c => new
                    {
                        Machitiettrinhdochuyenmon = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Matrinhdochuyenmon = c.String(maxLength: 50),
                        Tungay = c.DateTime(storeType: "date"),
                        Denngay = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Machitiettrinhdochuyenmon)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .ForeignKey("dbo.Trinhdo_chuyenmon", t => t.Matrinhdochuyenmon)
                .Index(t => t.Manv)
                .Index(t => t.Matrinhdochuyenmon);
            
            CreateTable(
                "dbo.Quatrinhluong",
                c => new
                    {
                        Maquatrinhluong = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Maphongban = c.String(maxLength: 50),
                        Machucvu = c.String(maxLength: 50),
                        Thoigian = c.DateTime(storeType: "date"),
                        Luongcoban = c.Int(),
                        Trocapchucvu = c.Int(),
                        Phucapkhac = c.Int(),
                        Noidung = c.String(maxLength: 50),
                        Luongdoanhso = c.Int(),
                    })
                .PrimaryKey(t => t.Maquatrinhluong)
                .ForeignKey("dbo.Chucvu", t => t.Machucvu)
                .ForeignKey("dbo.Phongban", t => t.Maphongban)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Maphongban)
                .Index(t => t.Machucvu);
            
            CreateTable(
                "dbo.Chitietkyluat",
                c => new
                    {
                        Machitietkyluat = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Makyluat = c.String(maxLength: 50),
                        Lydokyluat = c.String(maxLength: 250),
                        Tienphat = c.Int(),
                    })
                .PrimaryKey(t => t.Machitietkyluat)
                .ForeignKey("dbo.Kyluat", t => t.Makyluat)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Makyluat);
            
            CreateTable(
                "dbo.Kyluat",
                c => new
                    {
                        Makyluat = c.String(nullable: false, maxLength: 50),
                        Tenkyluat = c.String(maxLength: 50),
                        Quyetdinh = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Makyluat);
            
            CreateTable(
                "dbo.Chitietkhenthuong",
                c => new
                    {
                        Machitietkhenthuong = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Makhenthuong = c.String(maxLength: 50),
                        Lydokhenthuong = c.String(maxLength: 250),
                        Tienthuong = c.Int(),
                    })
                .PrimaryKey(t => t.Machitietkhenthuong)
                .ForeignKey("dbo.Khenthuong", t => t.Makhenthuong)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Makhenthuong);
            
            CreateTable(
                "dbo.Khenthuong",
                c => new
                    {
                        Makhenthuong = c.String(nullable: false, maxLength: 50),
                        Tenkhenthuong = c.String(nullable: false, maxLength: 50),
                        Quyetdinh = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Makhenthuong);
            
            CreateTable(
                "dbo.Hopdong",
                c => new
                    {
                        Mahopdong = c.String(nullable: false, maxLength: 50),
                        Manv = c.String(maxLength: 50),
                        Maloaihopdong = c.String(maxLength: 50),
                        Ngaykyket = c.DateTime(storeType: "date"),
                        Ngayketthuc = c.DateTime(storeType: "date"),
                        Luongcoban = c.Int(),
                    })
                .PrimaryKey(t => t.Mahopdong)
                .ForeignKey("dbo.Loaihopdong", t => t.Maloaihopdong)
                .ForeignKey("dbo.Thongtinnhansu", t => t.Manv)
                .Index(t => t.Manv)
                .Index(t => t.Maloaihopdong);
            
            CreateTable(
                "dbo.Loaihopdong",
                c => new
                    {
                        Maloaihopdong = c.String(nullable: false, maxLength: 50),
                        Tenloaihopdong = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Maloaihopdong);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Role_id = c.String(nullable: false, maxLength: 50),
                        Role_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Role_id);
            
            CreateTable(
                "dbo.Taikhoan",
                c => new
                    {
                        Mataikhoan = c.String(nullable: false, maxLength: 50),
                        Tendangnhap = c.String(maxLength: 50),
                        Matkhau = c.String(maxLength: 50),
                        Role_id = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Mataikhoan)
                .ForeignKey("dbo.Role", t => t.Role_id)
                .Index(t => t.Role_id);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taikhoan", "Role_id", "dbo.Role");
            DropForeignKey("dbo.Thongtinnhansu", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Hopdong", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Hopdong", "Maloaihopdong", "dbo.Loaihopdong");
            DropForeignKey("dbo.Chitietphongban", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Chitietkhenthuong", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Chitietkhenthuong", "Makhenthuong", "dbo.Khenthuong");
            DropForeignKey("dbo.Chitietkyluat", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Chitietkyluat", "Makyluat", "dbo.Kyluat");
            DropForeignKey("dbo.Chitietchucvu", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Thongtinnhansu", "Machucvu", "dbo.Chucvu");
            DropForeignKey("dbo.Quatrinhluong", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Quatrinhluong", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Quatrinhluong", "Machucvu", "dbo.Chucvu");
            DropForeignKey("dbo.Thongtinnhansu", "Matrinhdochuyenmon", "dbo.Trinhdo_chuyenmon");
            DropForeignKey("dbo.Dieudongcongtac", "Matrinhdochuyenmon", "dbo.Trinhdo_chuyenmon");
            DropForeignKey("dbo.Chitiettrinhdochuyenmon", "Matrinhdochuyenmon", "dbo.Trinhdo_chuyenmon");
            DropForeignKey("dbo.Chitiettrinhdochuyenmon", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Dieudongcongtac", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Dieudongcongtac", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Dieudongcongtac", "Machucvu", "dbo.Chucvu");
            DropForeignKey("dbo.Chitietchucvu", "Machucvu", "dbo.Chucvu");
            DropForeignKey("dbo.Chitietbaohiem", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Chitietbaohiem", "Mabaohiem", "dbo.Baohiem");
            DropForeignKey("dbo.Chitietbangcong", "Manv", "dbo.Thongtinnhansu");
            DropForeignKey("dbo.Chitietphongban", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Chitietbangcong", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Bangchamcong", "Maphongban", "dbo.Phongban");
            DropForeignKey("dbo.Chitietbangcong", "Mabangcong", "dbo.Bangchamcong");
            DropIndex("dbo.Taikhoan", new[] { "Role_id" });
            DropIndex("dbo.Hopdong", new[] { "Maloaihopdong" });
            DropIndex("dbo.Hopdong", new[] { "Manv" });
            DropIndex("dbo.Chitietkhenthuong", new[] { "Makhenthuong" });
            DropIndex("dbo.Chitietkhenthuong", new[] { "Manv" });
            DropIndex("dbo.Chitietkyluat", new[] { "Makyluat" });
            DropIndex("dbo.Chitietkyluat", new[] { "Manv" });
            DropIndex("dbo.Quatrinhluong", new[] { "Machucvu" });
            DropIndex("dbo.Quatrinhluong", new[] { "Maphongban" });
            DropIndex("dbo.Quatrinhluong", new[] { "Manv" });
            DropIndex("dbo.Chitiettrinhdochuyenmon", new[] { "Matrinhdochuyenmon" });
            DropIndex("dbo.Chitiettrinhdochuyenmon", new[] { "Manv" });
            DropIndex("dbo.Dieudongcongtac", new[] { "Matrinhdochuyenmon" });
            DropIndex("dbo.Dieudongcongtac", new[] { "Machucvu" });
            DropIndex("dbo.Dieudongcongtac", new[] { "Maphongban" });
            DropIndex("dbo.Dieudongcongtac", new[] { "Manv" });
            DropIndex("dbo.Chitietchucvu", new[] { "Machucvu" });
            DropIndex("dbo.Chitietchucvu", new[] { "Manv" });
            DropIndex("dbo.Chitietbaohiem", new[] { "Manv" });
            DropIndex("dbo.Chitietbaohiem", new[] { "Mabaohiem" });
            DropIndex("dbo.Thongtinnhansu", new[] { "Matrinhdochuyenmon" });
            DropIndex("dbo.Thongtinnhansu", new[] { "Machucvu" });
            DropIndex("dbo.Thongtinnhansu", new[] { "Maphongban" });
            DropIndex("dbo.Chitietphongban", new[] { "Maphongban" });
            DropIndex("dbo.Chitietphongban", new[] { "Manv" });
            DropIndex("dbo.Chitietbangcong", new[] { "Maphongban" });
            DropIndex("dbo.Chitietbangcong", new[] { "Mabangcong" });
            DropIndex("dbo.Chitietbangcong", new[] { "Manv" });
            DropIndex("dbo.Bangchamcong", new[] { "Maphongban" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Taikhoan");
            DropTable("dbo.Role");
            DropTable("dbo.Loaihopdong");
            DropTable("dbo.Hopdong");
            DropTable("dbo.Khenthuong");
            DropTable("dbo.Chitietkhenthuong");
            DropTable("dbo.Kyluat");
            DropTable("dbo.Chitietkyluat");
            DropTable("dbo.Quatrinhluong");
            DropTable("dbo.Chitiettrinhdochuyenmon");
            DropTable("dbo.Trinhdo_chuyenmon");
            DropTable("dbo.Dieudongcongtac");
            DropTable("dbo.Chucvu");
            DropTable("dbo.Chitietchucvu");
            DropTable("dbo.Baohiem");
            DropTable("dbo.Chitietbaohiem");
            DropTable("dbo.Thongtinnhansu");
            DropTable("dbo.Chitietphongban");
            DropTable("dbo.Phongban");
            DropTable("dbo.Chitietbangcong");
            DropTable("dbo.Bangchamcong");
        }
    }
}
