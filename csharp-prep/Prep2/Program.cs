using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userIpunt = Console.ReadLine();
        int grade = int.Parse(userIpunt);

        string letter = "";

        if (grade >= 90)
        {
            if (grade >= 94)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
            
        }
        else if(grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade <= 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if(grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade <= 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if(grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade <= 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else if(grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed in this course");
        }
        else
        {
            Console.WriteLine("I am sorry, but you did not pass in this course. Plase try again next time.");
        }        
    }
}