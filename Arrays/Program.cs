namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 50, -11, 23, 18 };

            int sum = 0, count = 0;

            int min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] <= min) //-11 0
                {
                    min = num[i];
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                count++;
            }

            int index = Array.IndexOf(num, min);

            Console.WriteLine("En kicik elementin indexi: {0} ", index);
            Console.WriteLine("En kicik elementin ozu: {0} ", min);
            Console.WriteLine("Arrayin elementlerinin ededi ortasi: {0}", sum / count);
        }

        public static void SimpleOrComplex()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int num = 0;

            int count = 0;

            int[] simple ;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        count++;
                    }
                    else
                    {
                        simple = numbers[i];
                    }
                }
            }
        }

            #region
            /*public static void Array1(string[] args)
            {

                int[] num = { 0, 50, -11, 23, 18 };
                int min = num[0];
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] <= min) //-11 0
                    {
                        min = num[i];
                    }
                }
                Console.WriteLine("En kicik elementin ozu: {0} ", min);
            }*/
            #endregion
            #region
            /*   public static void Array2(string[] args)
               {
                   int[] num = { 0, 50, -11, 23, 18 };
                   int min = num[0];
                   for (int i = 0; i < num.Length; i++)
                   {
                       if (num[i] <= min) //-11 0
                       {
                           min = num[i];
                       }
                   }
                   int index = Array.IndexOf(num, min);

                   Console.WriteLine("En kicik elementin indexi: {0} ", index);

               }*/
            #endregion

            #region
            /*   public static int Array3(string[] args)
               {
                   int[] num = { 0, 50, -11, 23, 18 };

                   int sum = 0, count = 0;
                   int min = num[0];

                   for (int i = 0; i < num.Length; i++)
                   {
                       if (num[i] <= min) //-11 0
                       {
                           min = num[i];
                       }
                   }

                   for (int i = 0; i < num.Length; i++)
                   {
                       sum += num[i];
                       count++;
                   }
                   Console.WriteLine("Arrayin elementlerinin ededi ortasi: {0}", sum / count);
               }*/
            #endregion
        }

    }


