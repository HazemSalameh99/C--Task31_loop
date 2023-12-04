using System;

namespace Task_3Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1- Correct the syntax error:
            //string[] ARR = { "Str", "alex", "moh" };
            //int []arr2 = { 1, 7, 9, 45 };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };



            //// 2- What the index of "Banana","Tomato"?
            //string[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.WriteLine(Array.IndexOf(fruits, "Banana"));//out: 1
            //Console.WriteLine(Array.IndexOf(fruits, "Tomato"));// out: 0



            ////3- Create an multiple arrays that represents your:
            //string[] favoriteFood = { "Pizza", "Sushi", "Chocolate", "Burgers", "Ice Cream" };
            //string[] favoriteSport = { "Soccer", "Basketball", "Tennis" };
            //string[] favoriteMovie = { "The Shawshank Redemption", "Inception", "The Dark Knight", "Pulp Fiction" };
            //Console.WriteLine("Favorite Food: forLoop");
            //for(int i=0;i< favoriteFood.Length; i++)
            //{
            //    Console.Write(favoriteFood[i] + " ");
            //}
            //Console.WriteLine("\nFavorite Food: forEach");
            //foreach(string food in favoriteFood)
            //{
            //    Console.Write(food + " ");
            //}
            //Console.WriteLine("\nFavorite Sport: forLoop");
            //for (int i = 0; i < favoriteSport.Length; i++)
            //{
            //    Console.Write(favoriteSport[i] + " ");
            //}
            //Console.WriteLine("\nFavorite Sport: forEach");
            //foreach (string sport in favoriteSport)
            //{
            //    Console.Write(sport + " ");
            //}
            //Console.WriteLine("\nFavorite Movie: forLoop");
            //for (int i = 0; i < favoriteMovie.Length; i++)
            //{
            //    Console.Write(favoriteMovie[i] + " ");
            //}
            //Console.WriteLine("\nFavorite Movie: forEach");
            //foreach (string movie in favoriteMovie)
            //{
            //    Console.Write(movie + " ");
            //}




            ////4- Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //Console.WriteLine("input Numbers in one line separated by a comma: ");
            //string input = Console.ReadLine();
            //int sum = 0;
            //string[] arr = input.Split(',');
            //for(int i=0;i<arr.Length;i++)
            //{
            //    sum+=Convert.ToInt32(arr[i]);
            //}
            //Console.WriteLine($"The Sum : {sum}");



            ////5- Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //Console.Write("The odd numbers are: ");
            //int sum = 0;
            //for (int i=1;i<100;i++)
            //{
            //    if(i%2==1)
            //    {
            //        Console.Write(i + " ");
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"\nThe Sum of odd Numbers is: {sum}");



            //// 6- Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3-i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            





            //// 7- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //int n = 4;
            //int count = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(count.ToString().PadLeft(2) + " ");
            //        count++;
            //    }

            //    Console.WriteLine();
            //}


        }
    }
}
