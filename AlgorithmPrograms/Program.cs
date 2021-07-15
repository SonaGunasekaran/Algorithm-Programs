using System;
using System.IO;

namespace AlgorithmPrograms
{
    class Program
    {
       public static void Main()
       {
            Console.WriteLine("1.Permutation of string\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    String str = "ABC";
                    int n = str.Length;
                    Permutation.Permute(str, 0, n - 1);
                    break;
                case 2:
                    string filepath = @"C:\Users\Sona G\source\repos\AlgorithmPrograms\AlgorithmPrograms\wordFile.txt";
                    string text = File.ReadAllText(filepath);
                    string[] textArray = text.Split(" ");
                    BinarySearch binarySearch = new BinarySearch(textArray);
                    Console.WriteLine("Enter a word to search:");
                    string word = Console.ReadLine();
                    int found = binarySearch.FindWord(word, 0, textArray.Length - 1);
                    if (found == 1)
                    {
                        Console.WriteLine("The word {0} is found", word);
                    }
                    else
                    {
                        Console.WriteLine("the word {0} is not found", word);
                    }
                    break;
                case 3:
                    string filepathins = @"C:\Users\Sona G\source\repos\AlgorithmPrograms\AlgorithmPrograms\wordFile.txt";
                    string sort = File.ReadAllText(filepathins);
                    string[] sortArray = sort.Split(" ");
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort(sortArray);
                    insertionSort.Display(sortArray);
                    break;
                case 4:
                    int[] arr = { 77,7,17,34,56,12,68 };
                    BubbleSort bubbleSort = new BubbleSort();
                    arr = bubbleSort.Sort(arr);
                    bubbleSort.Display(arr);
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;
            }
             
            Console.Read();
       }
    }
        
}

