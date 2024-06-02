using System;

public class TriPrg
{
    public static void Main(string[] args)
    {
        bool equilateral = false;
        
        
        
        Console.WriteLine ("Enter the first side length:");
        int first = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Enter the second side length:");
        int second = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Enter the third side length:");
        int third = int.Parse(Console.ReadLine());
        
        
        
        if (first == second && second == third){
            equilateral = true;
            Console.WriteLine ("Equilateral");
        }else{
            equilateral= false;
        }
        
        if (first == second | second == third | third == first){
            if (! equilateral ){
                Console.WriteLine ("Isosceles");
            }
        }else{
            Console.WriteLine ("Scalene");
        }
    }
}