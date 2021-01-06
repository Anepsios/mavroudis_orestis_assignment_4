using mavroudis_orestis_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace mavroudis_orestis_assignment_4.Models
{
    enum Color
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Violet
    }
    enum Size
    {
        XS, S, M, L, XL, XXL, XXXL
    }
    enum Fabric
    {
        Wool, Cotton, Polyester, Rayon, Linen, Cashmere, Silk
    }
    class Tshirt
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        private Tshirt(Color Color, Size Size, Fabric Fabric)
        {
            this.Color = Color;
            this.Size = Size;
            this.Fabric = Fabric;
        }

        private static List<Tshirt> GetTshirts(int amount)
        {
            List<Tshirt> tshirts = new List<Tshirt>();
            var rand = new Random();
            for (int i = 0; i < amount; i++)
                tshirts.Add(new Tshirt((Color)rand.Next(0, 7), (Size)rand.Next(0, 7), (Fabric)rand.Next(0, 7)));
            return (tshirts);
        }

        private static void CompareSorts(List<Tshirt> tshirts)
        {

            ISortStrategy strategy = new QuickSortStrategy();
            long ms1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            strategy.SortColorAscending(tshirts);
            long ms2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine($"Time elapsed for QuickSort: {ms2 - ms1}ms");


            strategy = new BubbleSortStrategy();
            ms1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            strategy.SortColorAscending(tshirts);
            ms2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine($"Time elapsed for BubbleSort: {ms2 - ms1}ms");


            strategy = new BucketSortStrategy();
            ms1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            strategy.SortColorAscending(tshirts);
            ms2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine($"Time elapsed for BucketSort: {ms2 - ms1}ms\n");
        }

        public static void SortProgram()
        {
            List<Tshirt> tshirts = Tshirt.GetTshirts(5000);


            ISortStrategy strategy = new QuickSortStrategy();
            string answer;
            Console.WriteLine("Choose an option (default sorting method is quicksort\n");
            do
            {
                Console.WriteLine("1)Compare Sorts in miliseconds\n" +
                                  "2)Pick a sorting Algorithm\n" +
                                  "3)Sort with method\n" +
                                  "4)Print tshirt list\n" +
                                  "5)Exit\n");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        CompareSorts(tshirts);
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("\nPick one\n" +
                                              "1)Quicksort\n" +
                                              "2)Bubblesort\n" +
                                              "3)Bucketsort\n" +
                                              "4)Back\n");
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "1":
                                    strategy = new QuickSortStrategy();
                                    Console.WriteLine("Strategy set\n");
                                    break;
                                case "2":
                                    strategy = new BubbleSortStrategy();
                                    Console.WriteLine("Strategy set\n");
                                    break;
                                case "3":
                                    strategy = new BucketSortStrategy();
                                    Console.WriteLine("Strategy set\n");
                                    break;
                            }
                        } while (answer != "4");
                        answer = "";
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("\nPick one\n" +
                                              "1)Size Ascending\n" +
                                              "2)Size Descending\n" +
                                              "3)Color Ascending\n" +
                                              "4)Color Descending\n" +
                                              "5)Fabric Ascending\n" +
                                              "6)Fabric Descending\n" +
                                              "7)Size-Color-Fabric Ascending\n" +
                                              "8)Size-Color-Fabric Descending\n" +
                                              "9)Back\n");
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "1":
                                    strategy.SortSizeAscending(tshirts);
                                    break;
                                case "2":
                                    strategy.SortSizeDescending(tshirts);
                                    break;
                                case "3":
                                    strategy.SortColorAscending(tshirts);
                                    break;
                                case "4":
                                    strategy.SortColorDescending(tshirts);
                                    break;
                                case "5":
                                    strategy.SortFabricAscending(tshirts);
                                    break;
                                case "6":
                                    strategy.SortFabricDescending(tshirts);
                                    break;
                                case "7":
                                    strategy.SortTshirtAscending(tshirts);
                                    break;
                                case "8":
                                    strategy.SortTshirtDescending(tshirts);
                                    break;
                            }
                        } while (answer != "9");
                        answer = "";
                        break;
                    case "4":
                        PrintList(tshirts);
                        break;
                }
            } while (answer != "5");
        }

        private static void PrintList(List<Tshirt> tshirts)
        {
            foreach (var item in tshirts)
            {
                Console.WriteLine($"{item.Color,10}{item.Size,7}{item.Fabric,12}");
            }
        }
    }
}