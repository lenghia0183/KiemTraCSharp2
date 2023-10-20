using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KienTraC_2
{

    
    internal class Program
    {
        static List<SinhVienA> StudentsList = new List<SinhVienA>();

        static bool isEmpty(){
            if(StudentsList.Count == 0){
                return true;
            } else {
                return false;
            }
        }

        static void AddStudent(){
            SinhVienA x = new SinhVienA();
            x.Nhap();
            StudentsList.Add(x);
        }

        static void Title(){
             Console.WriteLine($"{"ID",5} {"Ten",15} {"Ho",10} {"Tuoi",5} {"DiaChi",10} {"Toan",5} {"Ly",5} {"Hoa",5} {"Tong",5}");
        }

        static void ShowList(){
            Console.WriteLine("\t\t=====Danh Sach======");
            Title();
            foreach(var item in StudentsList){
                item.Xuat();
            }
        }

        static void SearchByKey(string key,string DiaChi,float TongDiem){
           
            bool isContain = false;
            if(key == "DiaChi"){
                foreach(var item in StudentsList){
                    if(item.DiaChi == DiaChi){
                        isContain = true;
                    }
                }
            } else if(key == "TongDiem"){
                foreach(var item in StudentsList){
                    if(item.Tong == TongDiem){
                        isContain = true;
                    }
                }
            } 

            if(isContain){
                Title();
                if(key == "DiaChi"){
                   foreach(var item in StudentsList){
                        if(item.DiaChi == DiaChi){
                         item.Xuat();
                        }
                    }
                } else if(key == "TongDiem"){
                        foreach(var item in StudentsList){
                            if(item.Tong == TongDiem){
                                item.Xuat();
                             }
                        }
                } 

            } else {
                Console.WriteLine($"{key} vua nhap vao khong ton tai");
            }


        }

        static void ShortByName(){
            StudentsList.Sort((x,y)=> x.Ten.CompareTo(y.Ten) != 0 ? x.Ten.CompareTo(y.Ten) : x.Ho.CompareTo(y.Ho));

            ShowList();
        }

        static void RemoveByName(string Ten){
            bool isRemove = false;
            for(int i=0;i<StudentsList.Count;i++){
                if(StudentsList[i].Ten == Ten){
                    StudentsList.Remove(StudentsList[i]);
                    isRemove = true;
                    i--;
                }
            }

            if(isRemove){
                if(isEmpty()){
                    Console.WriteLine("Danh sach rong");
                } else {
                    ShowList();
                }
            } else {
                Console.WriteLine("Ten ban vua nhap vao khong ton tai trong danh sach");
            }
        }
        static void Menu(){

            while(true){
                Console.WriteLine("\t\t=======MENU=======");
                Console.WriteLine("1.Them 1 sinh vien vao danh sach");
                Console.WriteLine("2.Hien thi danh sach sinh vien");
                Console.WriteLine("3.Tim Kiem theo Dia Chi");
                Console.WriteLine("4.Tim Kiem theo Tuoi");
                Console.WriteLine("5.Sap xep theo ho va ten");
                Console.WriteLine("6.Xoa Sinh vien theo ten");
                Console.WriteLine("7.Thoat");
                Console.WriteLine("\t\t=======END=======");
                Console.Write("Nhap vao lua chon: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if(n==1){
                  AddStudent();
                } 
                else if(n==2){
                    if(isEmpty()){
                        Console.WriteLine("Danh sach chua co sinh vien");
                    } else {
                        ShowList();
                    }
                }
                else if(n==3){
                    if(isEmpty()){
                        Console.WriteLine("Danh sach chua co sinh vien");
                    } else {
                        Console.Write("Nhap vao Dia chi can tim kiem: ");
                        string DiaChi = Console.ReadLine()!;
                        SearchByKey("DiaChi",DiaChi,0);
                    }
                }
                else if(n==4){
                    if(isEmpty()){
                        Console.WriteLine("Danh sach chua co sinh vien");
                    } else {
                        Console.Write("Nhap vao Tong can tim kiem: ");
                        float TongDiem = Convert.ToInt32(Console.ReadLine());
                        SearchByKey("TongDiem","",TongDiem);
                    }
                }
                else if(n==5){
                    if(isEmpty()){
                        Console.WriteLine("Danh sach chua co sinh vien");
                    } else {
                        ShortByName();
                    }
                }
                else if(n==6){
                    if(isEmpty()){
                        Console.WriteLine("Danh sach chua co sinh vien");
                    } else {
                        Console.Write("Nhap vao ten can xoa: ");
                        string Ten = Console.ReadLine()!;
                        RemoveByName(Ten);
                    }
                } else if(n==7){
                    Console.WriteLine("Da thoat");
                    break;
                } else {
                    Console.WriteLine("Lua Chon ban Nhap vao khong dung: ");
                }
                
            }
        }
        static void Main(){
            Menu();   
        }
    }
}