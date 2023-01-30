namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        string a="4",b="3",c="2",d="1",f="0";

            Console.WriteLine("Please input a letter grade:");
                string user_in=Console.ReadLine();
                string user=user_in.ToLower();
                    if(user=="a"){
                        Console.WriteLine("GPA Point: "+a);
                    }
                    else if(user=="b"){
                        Console.WriteLine("GPA Point: "+b);
                    }
                    else if(user=="c"){
                        Console.WriteLine("GPA Point: "+c);
                    }
                    else if(user=="d"){
                        Console.WriteLine("GPA Point: "+d);
                    }
                    else if(user=="f"){
                        Console.WriteLine("GPA Point: "+f);
                    }
                    else{
                        Console.WriteLine("Wrong Letter Grade!");
                    }


            Console.WriteLine("Please input the first num:");
                string num1in=Console.ReadLine();
                int num1=Convert.ToInt16(num1in);
            Console.WriteLine("Please input the second num:");
                string num2in=Console.ReadLine();
                int num2=Convert.ToInt16(num2in);
            Console.WriteLine("Please input the second num:");
                string num3in=Console.ReadLine();
                int num3=Convert.ToInt16(num3in);
                    if(num1<num2 && num1<num3){
                        Console.WriteLine("The smallest value is "+num1);
                    }
                    else if(num2<num1 && num2<num3){
                        Console.WriteLine("The smallest value is "+num2);
                    }
                    else if(num3<num1 && num3<num2){
                        Console.WriteLine("The smallest value is "+num3);
                    }
    }

            
}
