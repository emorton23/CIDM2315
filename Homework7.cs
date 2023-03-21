﻿namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(110,"Alice",28);
        Customer c2 = new Customer(111,"Bob",30);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.ChangeID(220);
        c2.ChangeID(221);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.CompareAge(c2);
        
    }

    
}

class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id,string cus_name,int cus_age)
    {
        this.cus_id=cus_id;
        this.cus_name=cus_name;
        this.cus_age=cus_age;
    }

    public void ChangeID(int new_id){
        cus_id=new_id;
    }

    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
        }
    public void CompareAge(Customer objCustomer){
        if(cus_age<=objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else{
            Console.WriteLine($"{cus_name} is older.");
        }    

    }
}
