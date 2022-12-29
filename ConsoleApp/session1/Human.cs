using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.session1
{
    internal class Human
    {
        private string name;
        private int age;
        public static int xyz;
        private int id; // Lớp Student vẫn kế thừa 


        public Human() 
        {
            
        }

        public int Id
        {
            get { return id; }
            set { this.id = value;}
        }
        public string Name 
        {
            get => name;
            set => name = value;
        }
        public int Age 
        {
            get => age;
            set => age = value;
        }
        public string Email { get; set; }
        public Human(string s) 
        {
            this.name = s;
        }
        public void Run()
        {
            Console.WriteLine("Running......");
            this.name = "Nguyen Van Thiem";
        }
        public void Run(string x)
        {
            // ví dụ hàm nạp chồng
        }
        public static void ScreenShot()
        {

        }
        public virtual void Eat() // virtual hàm có thể ghi đè được
        {

        }
        public sealed void Eat1() // không ghi đè
        {

        }
    }
        
}
