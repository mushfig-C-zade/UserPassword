using System.Threading.Channels;
using UserPassword.Models;
using static UserPassword.Models.User;

//Student stu1=new Student("Mushfig",86);
//Student stu2=new Student("Niyaz",96);
//Student stu3=new Student("Vugar",89);
//Student stu4=new Student("Esqin",99);

//Group group=new Group("AP103",7);
//group.AddStudent(stu1);
//group.AddStudent(stu2);    
//group.AddStudent(stu3);
//group.AddStudent(stu4);

//foreach(Student student in group.GetAllStudents())
//{
//    student.StudentInfo();    
//    //Console.WriteLine(student);
//}




Console.WriteLine("Fullname: ");
string fullname = Console.ReadLine();
Console.WriteLine("Email: ");
string email = Console.ReadLine();
string password;
do
{
    Console.WriteLine("Password: ");
    password = Console.ReadLine();
} while (!PasswordChecker(password));

User user = new User(email, password)
{
    Fullname = fullname
};
Console.WriteLine("====== User Menu ======");
Console.WriteLine("1. Show Info");
Console.WriteLine("2. Create new Group");
string choice = Console.ReadLine();
Group group = default;
switch (choice)
{
    case "1":
        user.ShowInfo();
        break;
    case "2":
        string groupNo;
        do
        {
            Console.WriteLine("Group NO daxil edin");
            groupNo = Console.ReadLine();
        } while (!Group.CheckGroupNo(groupNo));
        int studentLimit;
        bool isNum;
        do
        {
            Console.WriteLine("Group no:");
            string studentLimitStr = Console.ReadLine();
            isNum = int.TryParse(studentLimitStr, out studentLimit);
        } while (isNum == false || studentLimit < 2 || studentLimit > 18);
        group = new Group(groupNo, studentLimit);
        break;
    default:
        break;
}

bool chec = true;
while (chec)
{
    Console.WriteLine("======Group Menu======");
    Console.WriteLine("1. Show all students");
    Console.WriteLine("2. Get student by id");
    Console.WriteLine("3. Add student");
    Console.WriteLine("0. Quit");
    int choose = int.Parse(Console.ReadLine());



    switch (choose)
    {
        case 1:
            group?.GetAllStudents();
            break;
        case 2:
            int id = int.Parse(Console.ReadLine());
            group.GetStudent(id);
            break;
        case 3:
            Console.WriteLine("Fullname daxil edin");
            string fulname = Console.ReadLine();
            Console.WriteLine("Pointi daxil edin");
            int point=int.Parse(Console.ReadLine());
            Student stu1 = new Student(fullname,point);
            group.AddStudent(stu1);
            break;
        case 0:
            chec = false;
            break;
        default:
            break;
    }
}









