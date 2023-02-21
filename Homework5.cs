namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
      int res = CompareTwo();
      Console.WriteLine("The larger number is "+res);

      int max1 = CompareTwo();
      int max2 = CompareTwo();
      if(max1>max2){
        Console.WriteLine("The largest number is "+max1);
      }
      else{Console.WriteLine("The largest number is "+max2);
      }

        createAccount();
    }


    static int CompareTwo(){
    
        Console.WriteLine("Please enter an integer.");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter another integer.");
        int b = Convert.ToInt32(Console.ReadLine());
        if(a>b){
           return a;
        }
        else{
            return b;
        }  
    }

    

    static bool checkAge(int birth_year){
        int age = (2023-birth_year);
        if(age>=18){return true;}
        else{return false;}
    }


    static void createAccount(){
        Console.WriteLine("Enter your username.");
        string user = Console.ReadLine();
        Console.WriteLine("Enter your password.");
        string pass = Console.ReadLine();
        Console.WriteLine("Enter your password again.");
        string conf = Console.ReadLine();
        Console.WriteLine("Enter your birth year.");
        int birth=Convert.ToInt32(Console.ReadLine());
        bool age = checkAge(birth);
        if(age==true){
            if(pass==conf){
                Console.WriteLine("Account is created Successfully.");
            }
            else{Console.WriteLine("Wrong Password");}
        }
        else{Console.WriteLine("Could not create an account");}
    }







}
