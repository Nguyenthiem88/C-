using BaiTap6;

static void Main(string[] args)
{
    PhoneBook pb = new PhoneBook();
    pb.InsertPhone("Nam", "0977087101");
    pb.InsertPhone("Minh", "0988668866");
    pb.InsertPhone("Dung", "098856789");
    pb.InsertPhone("Nam", "0915468879");
    pb.InsertPhone("Name", "0985888999");

    pb.Sort();

    foreach(PhoneNumber p in pb.PhoneList)
    {
        Console.WriteLine(p.ToString);
    }
}