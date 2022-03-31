using System;
namespace ConsoleApp1
{
    internal class Program
    {
       static string[] bubbleSort(string[] arr)
        {
            for(int i =0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                    if(arr[j].Length < arr[j+1].Length)
                    {
                        string tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent vitae purus vitae neque fringilla aliquam non non sapien. " +
                "Fusce et varius quam. Quisque non dui id tellus pulvinar ultricies eu eu sem. Aenean eget ex diam. Duis sollicitudin eget augue a tincidunt. " +
                "Integer aliquet rutrum orci, in sagittis urna laoreet a. Aliquam dapibus libero eu metus condimentum, eget luctus lectus bibendum. Praesent lorem dui, " +
                "blandit auctor tristique at, consectetur ut leo. Nulla ac rhoncus ex. Nunc vel dolor eget orci pellentesque elementum. Duis dapibus augue id vehicula ullamcorper. " +
                "Sed non tincidunt ex. Duis eu vehicula quam. Cras purus enim, egestas eget turpis et, pharetra ornare urna. In commodo sit amet augue id tincidunt. Sed aliquet " +
                "et purus vitae pellentesque.";

            string[] secretArr = lorem.Split(" ");

            //secret
            for(int i = 0; i< secretArr.Length; i++)
            {
                if(secretArr[i].Length <= 3)
                    secretArr[i] = "secret";
            }
            foreach(string s in secretArr) Console.Write($"{s} ");
            Console.WriteLine("\n\n");

            //sort
            string[] sortedArr = bubbleSort(lorem.Split(" "));
            foreach (string s in sortedArr) Console.Write($"{s} ");
            Console.WriteLine("\n\n");

            //z,s,c to uppercase
            string uppercaseLorem = lorem;
            uppercaseLorem = uppercaseLorem.Replace('z', 'C');
            uppercaseLorem = uppercaseLorem.Replace('s', 'S');
            uppercaseLorem = uppercaseLorem.Replace('c', 'C');
            Console.WriteLine(uppercaseLorem);
            Console.WriteLine("\n\n");

            //I to same
            string sameLorem = lorem;
            while(sameLorem.IndexOf("i") != -1)
            {
                sameLorem = sameLorem.Insert(sameLorem.IndexOf("i"), "same");
                sameLorem = sameLorem.Remove(sameLorem.IndexOf("i"), 1);
            }
            Console.WriteLine(sameLorem);
        }
    }
}