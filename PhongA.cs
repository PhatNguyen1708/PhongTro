using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongTro
{
    internal class PhongA:PhongTro
    {
        int SoNguoiThan;
        public PhongA()
        {
            SoNguoiThan = 0;
        }
        public PhongA(int SoNguoiThan,string MaSoPHong,int SoNguoi,int SoDien,int SoNuoc):base(MaSoPHong,SoNguoi,SoDien,SoNuoc)
        {
            this.SoNguoiThan=SoNguoiThan;
        }

        public  override int TienPhong()
        {
            return 1400+2*SoDien+8*SoNuoc+50*SoNguoiThan;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so lan nguoi than o lai qua dem:");
            SoNguoiThan=int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma Phong\tSo nguoi\tSo Dien\tSo Nuoc\tSo nguoi than\t Tien Phong");
            base.Xuat();
            Console.WriteLine("\t{0}\t\t{1}", SoNguoiThan,TienPhong());
        }
    }
}
