namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        Largest();
        Shape();
    }


static void Largest()
    {
        Console.WriteLine("Please Enter First Number.");
        int a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter Second Number.");
        int b =Convert.ToInt32(Console.ReadLine());
        if(a>b)
            Console.WriteLine("The largest number is: "+a);
        else
            Console.WriteLine("The largest number is: "+b);
        return;
    }

static void Shape()
    {
        Console.WriteLine("Please enter a number.");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a shape (left or right).");
        string input = Console.ReadLine();
        string d = input.ToLower();
        Console.WriteLine("N is: "+c+"; Shape is: "+d);
        if(d=="left"){
                for(int e=0;e<c;e++){
                    for(int f=0;f<c;f++){
                        if(e>=f)
                            Console.Write("#");
                            
                    }
                    Console.WriteLine("");
                 }
        }

        else if(d=="right"){
                for(int e=0;e<c;e++){
                    for(int f=0;f<c-e;f++){
                        Console.Write(" ");
                    }
                    for(int g=0;g<=e;g++){    
                            Console.Write("#");     
                    }
                    Console.WriteLine("");
                 }            
        }

        else{Console.WriteLine("Please enter a valid Shape");}         
    }
}
