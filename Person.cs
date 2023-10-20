using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KienTraC_2
{
    internal class Person
    {

        public string Ten {set; get;}
        public string Ho {set; get;}
        protected int Tuoi {set; get;}

        public Person(){
            this.Ten = "";
            this.Ho = "";
            this.Tuoi = 0;
        }

        public Person(string Ten, string Ho, int Tuoi){
            this.Ten = Ten;
            this.Ho = Ho;
            this.Tuoi = Tuoi;
        }

        public virtual void Nhap(){
            Console.Write("Nhap vao Ten: ");
            this.Ten = Console.ReadLine()!;

            Console.Write("Nhap vao Ho: ");
            this.Ho = Console.ReadLine()!;

            Console.Write("Nhap vao Tuoi: ");
            this.Tuoi = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Xuat(){
            Console.WriteLine($"{this.Ten,15} {this.Ho,10} {this.Tuoi,5}");
        }


    }
}
