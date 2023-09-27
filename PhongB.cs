using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongTro
{
    internal class PhongB:PhongTro
    {
        int Giatui;
        int SoMay;
        public PhongB()
        {
            Giatui=SoMay=0; 
        }
        public PhongB(int Giatui, int SoMay,string MaSoPHong,int SoNguoi,int SoDien,int SoNuoc):base(MaSoPHong, SoNguoi, SoDien, SoNuoc)
        {
            this.Giatui=Giatui;
            this.SoMay=SoMay;
        }
        public override int TienPhong()
        {
            return 2000+2*SoDien+8*SoNuoc+5*Giatui+100*SoMay;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap khoi luong giat ui:");
            Giatui=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so may su dung internet:");
            SoMay=int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma Phong\tSo nguoi\tSo Dien\tSo Nuoc\tGiat ui\t So May\t\tTien Phong");
            base.Xuat();
            Console.WriteLine("\t{0}\t{1}\t\t\t{2}",Giatui, SoMay, TienPhong());
        }
    }
}
