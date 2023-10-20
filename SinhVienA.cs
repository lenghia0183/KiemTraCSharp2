using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KienTraC_2
{
    internal class SinhVienA : Person
    {
        public string ID {set; get;}

        public string DiaChi{set; get;}

        public float Toan {set; get;}

        public float Ly {set; get;}

        public float Hoa {set; get;}

        public float Tong {
            get {
                return this.Toan + this.Ly + this.Hoa;
            }
        }

        public SinhVienA():base(){
            this.ID = "";
            this.DiaChi = "";
            this.Toan = 0;
            this.Ly = 0;
            this.Hoa = 0;
        }

        public SinhVienA(string Ten,string Ho, string DiaChi,int Tuoi,string ID, float Toan, float Ly,float Hoa):base(Ten,Ho,Tuoi){
            this.ID = ID;
            this.DiaChi = DiaChi;
            this.Toan = Toan;
            this.Ly = Ly;
            this.Hoa = Hoa;
        }

        public override void Nhap(){
           try{
             base.Nhap();
            Console.Write("Nhap vao ID: ");
            this.ID = Console.ReadLine()!;

            Console.Write("Nhap vao Dia Chi: ");
            this.DiaChi = Console.ReadLine()!;

            Console.Write("Nhap vao Diem Toan: ");
            this.Toan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao Diem Ly: ");
            this.Ly = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao Diem Hoa: ");
            this.Hoa = Convert.ToInt32(Console.ReadLine());
           } catch(Exception){
                Console.WriteLine("Du lieu ban nhap chua hop le!");
           }

        }

        public override void Xuat(){
             Console.WriteLine($"{this.ID,5} {this.Ten,15} {this.Ho,10} {this.Tuoi,5} {this.DiaChi,10} {this.Toan,5} {this.Ly,5} {this.Hoa,5} {this.Tong,5}");
        }

    }
}
