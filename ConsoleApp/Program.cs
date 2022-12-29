using ConsoleApp.session_4;
using ConsoleApp.session1;
using ConsoleApp.session2;
using ConsoleApp.session3;
using System.Security.Cryptography.X509Certificates;

public class Program
{

    static void Mani(string[] args)
    {
        //Thread t1 = new Thread(ThreadRun);
        //Thread t2 = new Thread(ThreadRunParam);
        //t2.IsBackground= true;
        //t1.Start();
        //t2.Start();

        Number num = new Number() { X = 0, Y = 0};
        Thread n1 = new Thread(ThreadLock);
        Thread n2 = new Thread(ThreadLock);
        n1.Start(num);
        n2.Start(num);
    }

    static void ThreadRun()
    {
        for(int i = 0; i<20; i++)
        {
            Console.WriteLine("i=" + i);
            try
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }    
    }

    static void ThreadRunParam(object msg) // lớp object lớp cha của tất cả các lớp khác
    {
        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine("i=" + i + "Msg"+msg);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }

    static void ThreadLock(object o) 
    {
        Number n = (Number)o;
        for(int i=0;i<20;i++)
        {
            lock(n)
            {
                n.ChangeXY();
                n.PrintXY();
            }
            
            try
            {
                Thread.Sleep(1000);
            }
            catch(Exception e) { }
        }
    }   














    static void ShowMessage(string asg)
    {
        Console.WriteLine(asg);
    }




    static void Main(string[] args) 
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception(" Y bang 0 mat roi");
            float z = x / y;
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {

        }


        Human h = new Human();
        h.Run();
        h.Age = 20;
        h.Email = "123@gmail.com";
        Student s = new Student();
        s.telephone[0] = "0977087101";
        s[0] = "0977087101";
        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world");
        ls.Add("aoring");
        
        for(int i = 0; i<ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }    

        foreach(string l in ls) 
        {
            Console.WriteLine(l);
        }
    }
}