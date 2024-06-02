using System;

public class GradePrg
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the score 0-100:");
        int score = int.Parse(Console.ReadLine());
        
        if (score > 90){
            Console.WriteLine ("A");
        }
        if (score > 70 && score < 79){
            Console.WriteLine ("C");
        }
        if (score > 80 && score< 89){
            Console.WriteLine ("B");
        }if (score > 60 && score < 69){
            Console.WriteLine ("D");
        }
        if (score < 60){
            Console.WriteLine ("F");
        }
    }
}