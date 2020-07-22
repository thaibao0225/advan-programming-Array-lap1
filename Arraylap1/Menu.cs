using System;
namespace Arraylap1
{
    public class Menu
    {
        public Menu()
        {
            PrintMenu();

        }

        public void PrintMenu()
        {
            bool block = false;
            Array arr1 = new Array(10);

            do
            {
                Console.Clear();

                Console.WriteLine("-----------Menu array------------------");

                Console.WriteLine("1. Print array:");
                Console.WriteLine("2. Sum array:");
                Console.WriteLine("3. Average array:");
                Console.WriteLine("4. Find array:");
                Console.WriteLine("5. Min array:");
                Console.WriteLine("6. Max array:");

                Console.WriteLine("7. Sort the array in ascending order:");
                Console.WriteLine("8. Sort the array in descending order:");
                Console.WriteLine("9. Add a new element at the beginning of the array:");
                Console.WriteLine("10. Add a new element at the end of the array:");
                Console.WriteLine("11. Add a new element at specific position of the array:");

                Console.WriteLine("12. Stop");

                Console.WriteLine("Choose function:");

                int choice = int.Parse(Console.ReadLine());

                

                arr1.Input();

                switch (choice)
                {
                    case 1:
                        arr1.Output();
                        break;

                    case 2:
                        Console.WriteLine("Sum = {0}", arr1.Sum());
                        break;

                    case 3:
                        Console.WriteLine("Average =  {0}" ,arr1.Average());
                        break;

                    case 4:
                        Console.WriteLine(" arr[i] = {0} ", arr1.FindArr(Findarr())); 
                        break;

                    case 5:
                        arr1.MinArr();
                        break;

                    case 6:
                        arr1.Max();
                        break;

                    case 7:
                        arr1.SortAscending();
                        arr1.Output();
                        break;

                    case 8:
                        arr1.SortDescending();
                        arr1.Output();
                        break;

                    case 9:
                        Console.WriteLine("Add Number to Bengin array = {0} " ,arr1.AddBeginArray(Findarr()));
                        arr1.Output();

                        break;

                    case 10:
                        Console.WriteLine("Add Number to End array =  {0} " ,arr1.AddEndArray(Findarr()));
                        arr1.Output();
                        break;

                    case 11:
                        Console.WriteLine("Add Number to Position array = {0}" ,arr1.AddPositionArray(Findarr(), Findarr()));
                        arr1.Output();
                        break;

                    case 12:
                        block = true;
                        break;

                    default:
                        break;

                }

                Console.ReadLine();

                Console.Clear();

            } while (block != true);

            
            
        }


        public int Findarr()
        {
            int index = int.Parse(Console.ReadLine());

            return index;
        }
        


    }
}
