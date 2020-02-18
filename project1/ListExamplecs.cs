using System;
using System.Collections.Generic;
using System.Text;

class Program
    {
//        static void Main(string[] args)
//        {
//		//playerId
//            //Two dimensional array
//            double[,] price = {
//                                 {350, 390, 435},
//                                 {400, 440, 480},
//                                 {475, 530, 575}
//                              };
//		//salary requirement
//            string[,] selection = {
//                                     {"Snickers", "Twix", "Mars"},
//                                     {"Skittles", "Starburst", "Sour Patch Kids"},
//                                     {"Big Red", "Winter fresh", "Trident"}
//                                  };
//		//Player objects declaring and initializing all in one step
//		List<Candy> candyList = new List<Candy>();

//            //Iterate through the multi-Array and populate the list
//            for (var i = 0; i < 3; i++) //outer loop control rows
//            {
//                for (var x = 0; x < 3; x++) //inner loop controls columns, creating object instances by passing to constructor and
//				//adding object to a list, and outputting the objects
//                {
//                    Candy aCandy = new Candy(selection[i, x], price[i, x]);
//                    candyList.Add(aCandy);
//                    Console.WriteLine("{0} goes for {1}", selection[i, x], price[i, x].ToString("c"));
//                }
//            }
            
//            //Decrement through the list and find the object with value "Snickers" for the name property
//            for(var i = candyList.Count -1; i >= 0; i--)
//            {
//                if (candyList[i].name.Contains("Snickers"))
//                {
//                    candyList.RemoveAt(i);    
//                }     
//            }
//            //Output the list using lambda Expression
//            candyList.ForEach(x => Console.WriteLine(x.ToString()));
//        }
//    }
////Player
//public class Candy
//    {
//        public string name { get; set; }
//        public double price { get; set; }

//        public Candy(string name, double price)
//        {
//            this.name = name;
//            this.price = price;
//        }

//        public override string ToString()
//        {
//            return String.Format("The name of the candy is " + name + " the price for this candy " + price);
//        }

    }