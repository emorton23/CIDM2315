namespace Homework9;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111,"Alice");
        Student Bob = new Student(222,"Bob");
        Student Cathy = new Student(333,"Cathy");
        Student David = new Student(444,"David"); 
        
        Dictionary<string,double> gradebook = new Dictionary<string,double>();
            gradebook.Add("Alice",4.0);
            gradebook.Add("Bob",3.6);
            gradebook.Add("Cathy",2.5);
            gradebook.Add("David",1.8);
            bool tom = gradebook.ContainsKey("Tom");
            if(tom==false){
                gradebook.Add("Tom",3.3);   
            }
            foreach(var x in gradebook){
                Console.WriteLine($"Student Name: {x.Key} Student GPA: {x.Value}");
            }
            double sum = 0;
            int length = 0;
            double average = 0;
            foreach(var y in gradebook){
                sum += y.Value;
                length = gradebook.Count;
                average = sum/length;
            }
            Console.WriteLine($"The average GPA is: {average}");

    }
}

class Student
{
    private int studentID;
    private string studentName;
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    public static List<string>studentList = new List<string>(){"Alice","Bob","Cathy","David","null"};
    public Student(int studentID, string studentName){
        this.studentID=studentID;
        this.studentName=studentName;
    }
    
}
