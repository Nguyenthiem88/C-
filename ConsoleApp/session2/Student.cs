using ConsoleApp.session1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.session2
{
    internal class Student : Human // kế thừa lớp Human (chỉ kế thừa một lớp duy nhất)
    {
        public string[] telephone = new string[3];

        public void Study()
        {
            base.Run(); // đối tượng ngầm định của lớp cha bên trong lớp con

        }
        public string this[int index] // indexer
        {
            get => telephone[index];
            set=> telephone[index] = value;
        }


        public Student( string s, int a): base(s) 
        {
            
            this.Age = a;
        }
        public override void Eat() // ghi đè từ lớp cha
        {
            base.Eat();
        }
        
    }

}
