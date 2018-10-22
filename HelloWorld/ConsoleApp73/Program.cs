using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace Program

{

    class Program

    {

        static void Main(string[] args)

        {

            int num,sum = 0;

            Console.WriteLine("Enter a Number : ");

            num = int.Parse(Console.ReadLine());

            bool flag = true;
            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    sum = sum + i;
                }
                flag = true;
            }
            Console.WriteLine("Reverse of Entered Number is : " +sum);

            Console.ReadLine();



        }

    }

}