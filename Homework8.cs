namespace Homework8;
class Program
{
  public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Test Q2.1
        PrintAllOddNumber(array_2d);

        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }

        
    }
  
    public static void ArraySum(int[] int_array){
        int sum=0;
        foreach(int num in int_array){
            sum+=num;
        }
        Console.WriteLine($"The sum of int_array is: {sum}");
    }

    public static void PrintAllOddNumber(int[,] array_2d){
        foreach(int i in array_2d){if(i%2 != 0){Console.Write(i + " ");}}
        }
    
    public static int ElementSum(int[,] array_2d){
        int sum=0;
        foreach(int num in array_2d){
            sum+=num;
        }
        return sum;
    }

   public static int [,] DoubleArray(int[,] array_2d){
        for(int row = 0; row<array_2d.GetLength(0);row++){
            for(int col=0;col<array_2d.GetLength(1);col++){
                int x =array_2d[row,col];
                array_2d[row,col]=x*2;
            } 
            }
        return array_2d;
    }

}
