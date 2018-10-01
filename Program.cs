using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Three Basic Arrays
            //1
            // int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            // System.Console.WriteLine(numArray);

            //2
            string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
            // System.Console.WriteLine(strArray);

            //3
            // Random rand = new Random();

            // for (int i = 0; i < 11; i++)
            // {
            //     int val = rand.Next(1,10);
                
            //     if(val < 6){
            //         System.Console.WriteLine("True");
            //     }else{
            //         System.Console.WriteLine("False");
            //     }
            // }

            //List
            List<string> IceCream = new List<string>();
            IceCream.Add("Chocolate");
            IceCream.Add("Vanilla");
            IceCream.Add("Motcha");
            IceCream.Add("Coffee");
            IceCream.Add("Peanut Butter");
            // for (int i = 0; i < IceCream.Count; i++)
            // {
            //     System.Console.WriteLine(IceCream[i]);
            // }
            // System.Console.WriteLine(IceCream.Count);
            // System.Console.WriteLine(IceCream[3]);
            // IceCream.RemoveAt(3);
            // System.Console.WriteLine(IceCream.Count);

            // Dictionary
            Random rand = new Random();
            for (int i = 0; i < strArray.Length; i++)
            {
                Dictionary<string, string> Info = new Dictionary<string, string>();
                Info.Add("Name", strArray[i]);
                Info.Add("Ice Cream flavor", IceCream[rand.Next(IceCream.Count)]);
                foreach (var entry in Info)
                {
                    System.Console.WriteLine(entry.Key + " - "+ entry.Value);
                }
            }
        }
    }
}
