namespace BB206Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] numbers = new int[5]; // {0,0,0,0,0}
            //int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] numbers4 = { 1, 2, 3, 4, 5 };

            //int[] numbers3 = new int[5] { 1, 2, 3, 4, 5 };
            //numbers3[numbers3.Length - 1] = 25;

            //Console.WriteLine(numbers3[^1]);


            //string[] names = { "Elsever", "Niyaz", "Tanzila", "Reqsane", "Yusif" };

            //for (int i = 1; i <=names.Length ; i++)
            //{
            //    Console.WriteLine(names[^i]);
            //}

            //for (int i = 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine("Arrayin icerisindeki adlar: " + names[i]);
            //    Console.WriteLine("Arrayin indexleri: " + i);
            //}

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //    if (names[i] == "Tanzila")
            //    {
            //        Console.WriteLine("Tapdim");
            //        break;
            //    }
            //}

            //double[] doubles = { 3, 4, 5.0, 6 };
            #endregion

            #region Task
            //10 uzunluqlu int arrayi yaradin.Arrayin icerisindeki tek ve cut ededlerin cemini(ayri-ayriliqda) tapan alqoritm yazin;
            //Tek ededlerin ceminin cut ededlerin cemine olan nisbetini tapin

            //int[] numbersArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double sumOfEvens = 0;
            //double sumOfOdds = 0;

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    if (numbersArray[i] % 2 == 0)
            //        sumOfEvens += numbersArray[i];
            //    else
            //        sumOfOdds += numbersArray[i];
            //}

            //Console.WriteLine($"Cutlerin cemi {sumOfEvens} , Teklerin cemi {sumOfOdds}, Nisbeti: {sumOfOdds / sumOfEvens} ");
            #endregion

            #region Array.Rank
            //int[] numbers1 = new int[] { 1, 2, 3 };
            ////Console.WriteLine(numbers1.Rank);
            //int[,] numbers2 = new int[2, 2]
            //{
            //    {1,3},
            //    { 1,2}
            //};
            ////Console.WriteLine(numbers2[0,1]);

            //int[,,] numbers3 = new int[2, 3, 3]
            //{
            //    {
            //        {1,3,1},
            //        { 1,2,1},
            //        { 1,3,5},
            //    },
            //    {
            //        {1,3,5},
            //        { 1,1,2},
            //        { 1,1,3},
            //    }

            //};
            //Console.WriteLine(numbers3.Rank);
            #endregion

            #region BigO Notation
            //var num = 25;
            //bool check = true;
            //int counter = 0;
            //if (num == 0 || num == 1) Console.WriteLine("Ne sade ne murekkebdir");

            //for (int i = 2; i * i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine("Murekkebdir");
            //        check = false;
            //        break;
            //    }
            //    counter++;
            //}

            //if (check == true) Console.WriteLine("Sadedir");

            //Console.WriteLine($"Dongu sayi {counter}");
            #endregion
        }
    }
}