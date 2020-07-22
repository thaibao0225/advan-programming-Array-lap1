using System;
namespace Arraylap1
{
    public class Array
    {
        int [] arr;
        int n;

        public Array(int n)
        {
            this.n = n;
            this.arr = new int[n];
        }

        public void Input()
        {
            //input
            Random r = new Random();

            for(int i = 0; i < n; i++)
            {
                arr[i] = r.Next(1, 40);
            }
        }

        public void Output()
        {
            //Out

            for(int i = 0; i < n; i++ )
            {
                Console.Write("\t {0} ", arr[i]);
            }
        }

        public int Sum()
        {
            int s = 0;

            //Sum

            for (int i = 0; i < n; i++)
            {
                s = s + arr[i];
            }

            return s;

        }

         public double Average()
        {

            //average

            return Sum()/n;
        }

        public int FindArr(int i)
        {
            //Find

            return arr[i];

        }

        public int MinArr()
        {
            int min = arr[0];

            for(int i = 0; i < n; i++)
            {
                if(min >= arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public int Max()
        {
            int max = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (max <= arr[i])
                {
                    max = arr[i];
                }
            }

            return max; 
        }


        public void SortAscending()
        {
            //ascending
            int valueB;
            int valueE;

            int indexB = 0;
            int indexE = 0;


            for(int i = 0; i < n; i++)
            {
                valueB = arr[i];

                for (int j = i; j < n; j ++)
                {
                    if (valueB >= arr[j])
                    {
                        valueB = arr[j];
                        indexE = j;
                    }
                }


                valueE = arr[indexB];

                arr[indexB] = valueB;
                arr[indexE] = valueE;

                indexB++;
                
            }
        }

        public void SortDescending()
        {
            //Descending

            int valueB;
            int valueE;

            int indexB = 0;
            int indexE = 0;


            for (int i = 0; i < n; i++)
            {
                valueB = arr[i];

                for (int j = i; j < n; j++)
                {
                    if (valueB <= arr[j])
                    {
                        valueB = arr[j];
                        indexE = j;
                    }
                }


                valueE = arr[indexB];

                arr[indexB] = valueB;
                arr[indexE] = valueE;

                indexB++;

            }
        }

        public int AddBeginArray(int value)
        {
            // Add begin array

            arr[0] = value;

            return arr[0];

        }

        public int AddEndArray(int value)
        {
            //Add End array
            arr[n - 1] = value;
            return arr[n - 1];

        }

        public int AddPositionArray(int position, int value)
        {
            //Add position array
            arr[position] = value;

            return arr[position];
        }

    }
}
