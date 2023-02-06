namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Assign an int value to N:");
        int i = Convert.ToInt16(Console.ReadLine());
                for(int j=1;j<=i;j++){
                    for(int k=1;k<=i;k++){
                        if(j>=k)
                            Console.Write(j);

                        
                    }
                Console.WriteLine("");
                 }


    }

}



