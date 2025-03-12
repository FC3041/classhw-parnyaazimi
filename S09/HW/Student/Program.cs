using System.Runtime.Intrinsics.Arm;

namespace Student;

public class Student
{
    public string name;
    public int stdid;
    public ulong natid;
    public int credits;
    public bool active;

    public Student(string name, int stdid, ulong natid, int credits, bool active)
    {
        this.name = name;
        this.stdid = stdid;
        this.natid = natid;
        this.credits = credits;
        this.active = active;
    }

    public static Student Parse(string str)
    {
        string[] tokens = str.Split(',');
        var name = tokens[0];
        var stdid = int.Parse(tokens[1]);
        var natid = ulong.Parse(tokens[2]);
        var credits = int.Parse(tokens[3]);
        var active = bool.Parse(tokens[4]);
        return new Student(name, stdid, natid, credits, active);

    }

    public override string ToString() =>
        $"{name},{stdid},{natid},{credits},{active}";

    public override bool Equals(object obj)
    {
        if (obj is Student) {
            Student other = obj as Student;
            return 
                name.Equals(other.name)  &&
                stdid.Equals(other.stdid)  &&
                natid.Equals(other.natid)  &&
                active.Equals(other.active)  &&
                credits.Equals(other.credits) ;
        }
        return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int count=0;
        while(true)
       { 
            Console.WriteLine("Do You want to register a new student? ");
                if(Console.ReadLine()=="No")
                    break;
            Console.WriteLine("Enter name of student : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter student_id of student : ");
            int student_id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter national_id of student : ");
            ulong national_id=Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Enter creadits of student : ");
            int creadits=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter active of student : ");
            bool active=Convert.ToBoolean(Console.ReadLine());
            Student newStudent=new Student(name,student_id,national_id,creadits,active);
            count++;
            File.AppendAllLines("Student.csv",new string[]{$"{count} : Student",newStudent.ToString()});
        }

    }

    // static void Main(string[] args)
    // {
    //     string name=args[0];
    //     int student_id=Convert.ToInt32(args[1]);
    //     ulong national_id=Convert.ToUInt64(args[2]);
    //     int creadits=Convert.ToInt32(args[3]);
    //     bool active=Convert.ToBoolean(args[4]);
    //     Student newStudent=new Student(name,student_id,national_id,creadits,active);
    //     File.AppendAllLines("Student2.csv",new string[]{newStudent.ToString()});        
    // }

}
