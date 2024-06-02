using System;

public class TicketPrg
{
    public static void Main(string[] args)
    {
        int price = 10;
        int discounted_price = 7;
        
        Console.WriteLine ("Enter age:");
        int age = int.Parse(Console.ReadLine());
        
        if (age > 64 | age < 13){
            Console.WriteLine (discounted_price);
        }else{
            Console.WriteLine (price);
        }
        
    }
}