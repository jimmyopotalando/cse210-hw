using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        
        string letterGrade = "";
        string gradeSign = "";

        
        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        
        if (letterGrade != "F")
        {
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit < 3)
            {
                gradeSign = "-";
            }
        }

        
        if (letterGrade == "A" && gradeSign == "+")
        {
            gradeSign = "-";  
        }

        
        if (letterGrade == "F")
        {
            gradeSign = ""; 
        }

        Console.WriteLine($"Your grade is: {letterGrade}{gradeSign}");

        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Better luck next time!");
        }
    }
}
