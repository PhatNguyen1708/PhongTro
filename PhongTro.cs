using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongTro
{
    abstract class PhongTro
    {
        protected string MaSoPhong;
        protected int SoNguoi;
        protected int SoDien;
        protected int SoNuoc;
        public abstract int TienPhong();
        public PhongTro()
        {
            MaSoPhong = string.Empty;
            SoNguoi = SoDien = SoNuoc = 0; 
        }
        public PhongTro(string MaSoPhong, int SoNguoi, int SoDien, int SoNuoc)
        {
            this.MaSoPhong=MaSoPhong;
            this.SoNguoi=SoNguoi;
            this.SoDien=SoDien;
            this.SoNuoc=SoNuoc;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma phong:");
            MaSoPhong= Console.ReadLine();
            Console.WriteLine("Nhap so nguoi:");
            SoNguoi=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dien:");
            SoDien=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nuoc:");
            SoNuoc=int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("{0}\t\t{1}\t\t{2}\t{3}",MaSoPhong,SoNguoi,SoDien,SoNuoc);
        }
    }
}
