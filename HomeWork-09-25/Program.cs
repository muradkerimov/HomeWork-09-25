using System;

namespace HomeWork_09_25
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Balınızı daxil edin: ");
            //        int score = Convert.ToInt32(Console.ReadLine());
            //        if (score <= 100 && score > 90)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        else if (score <= 90 && score > 80)
            //        {
            //            Console.WriteLine("B");
            //        }
            //        else if (score <= 80 && score > 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else if (score <= 70 && score > 60)
            //        {
            //            Console.WriteLine("D");
            //        }
            //        else if (score <= 60 && score > 50)
            //        {
            //            Console.WriteLine("E");
            //        }
            //        else if (score <= 50 && score > 0)
            //        {
            //            Console.WriteLine("kesr");
            //        }
            //        else
            //        {
            //            Console.WriteLine("1 ile 100 arasinda eded daxil edin");
            //        }
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("1 ile 100 arasinda eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-2
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        int i = 1;
            //        while (i <= number)
            //        {
            //            if (number % i != 0)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                Console.WriteLine(i);
            //                i++;
            //            }
            //        }
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-3
            //while (true)
            //{
            //    try
            //    {
            //        int result = 0;
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        while (number>=1)
            //        {
            //            number /= 10;
            //            result++;
            //        }
            //        Console.WriteLine(result);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-4
            //while (true)
            //{
            //    try
            //    {
            //        int result = 0;
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        while (number >= 1)
            //        {
            //            result += number % 10;
            //            number = (number-(number%10))/10;
            //        }
            //        Console.WriteLine(result);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-5
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        int i = 2;
            //        string[] dvide_numbers = new string[dvide_numbers.Length + 1];
            //        while (i <= number)
            //        {
            //            if (number % i != 0)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                dvide_numbers.Add(i);
            //                i++;
            //            }
            //        }
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}




            //while (true)
            //{
            //    try
            //    {
            //        int i = 2;
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        while (i < number)
            //        {
            //            if (number % 2 != 0)
            //            {
            //                Console.WriteLine(true);
            //            }
            //            else
            //            {
            //                Console.WriteLine(false);
            //            }
            //            i++;
            //        }
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-6
            //while (true)
            //{
            //    try
            //    {
            //        int result = 1;
            //        Console.Write("Reqem daxil edin: ");
            //        int number = Convert.ToInt32(Console.ReadLine());
            //        while (number >= 1)
            //        {
            //            result *= number ;
            //            number--;
            //        }
            //        Console.WriteLine(result);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("eded daxil edin");
            //    }
            //}
            #endregion

            #region Task-7
            //int[] arr = { 10, 15, 20, 35, 45, 20, 15 };
            //int resultMin = arr[0];
            //int resultMax = arr[0];
            //foreach (int item in arr)
            //{
            //    if (resultMin > item)
            //    {
            //        resultMin = item;
            //    }
            //}
            //foreach (int item in arr)
            //{
            //    if (resultMax < item)
            //    {
            //        resultMax = item;
            //    }
            //}

            //Console.WriteLine(resultMax + resultMin);
            #endregion

            #region Task-8
            //Console.Write("reqem daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("winter");
            //        break;
            //    case 2:
            //        Console.WriteLine("spring");
            //        break;
            //    case 3:
            //        Console.WriteLine("summer");
            //        break;
            //    case 4:
            //        Console.WriteLine("autom");
            //        break;
            //    default:
            //        Console.WriteLine("1 ile 4 arasinda reqem daxil edin");
            //        break;
            //}
            #endregion

            #region Task-9
            //string[] arr = { "Murad", "Zulfuqar", "Elgun", "Kamran", "Nicat" };
            //string result = arr[0];
            //foreach (string item in arr)
            //{
            //    if (result.Length < item.Length)
            //    {
            //        result = item;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion

            #region Task-10
            //int yield = 0;
            //int[] number_1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] number_2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int i in number_1)
            //{
            //    foreach (int j in number_2)
            //    {
            //        yield = i * j;
            //        Console.Write(yield + "=" + i + "*" + j + "     ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
