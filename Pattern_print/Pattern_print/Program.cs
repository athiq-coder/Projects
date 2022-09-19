using System;

namespace Pattern_print
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //for (int i = 1; i <= 5; i++)
            //{
            //   for(int j=1; j<=5; j++)
            //    {
            //        Console.Write("# ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q2
            //for(int i=1;i<=7;i++)
            //{
            //    for(int j=1;j<=7;j++)
            //    {
            //        Console.Write(i%2==0 && j==1 ? " # " : "# ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q3- a
            //for(int i =1; i<=8; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //            Console.Write("# ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q3- b
            //for(int i=7;i>=1;i--)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("# ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q3 - c

            //for (int i = 1; i < 8; i++)
            //{
            //    for (int j = 1; j < 8; j++)
            //    {
            //        if (j - i < 0)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("#");
            //        }
            //    }

            //    Console.WriteLine("");
            //}

            #endregion
            #region Q3- d

            //for (int i = 7; i >= 1; i--)
            //{

            //    for (int k = 1; k <= i; k++)
            //        Console.Write(" ");

            //    for (int j = 7; j >= i; j--)
            //    {
            //        Console.Write("#");
            //    }

            //    Console.WriteLine();
            //}

            #endregion
            #region Q3 - e
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i == 1 || i == 7)
                        Console.Write("#");



                }
                Console.WriteLine();
            }



            #endregion


        }
    }
}
