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

            int num, reverse = 0;

            Console.WriteLine("Enter a Number : ");

            num = int.Parse(Console.ReadLine());

            while (num != 0)

            {
                //Enter a Number: 123
                //Reverse of Entered Number : 321
                // 채워 주세요, 10으로 나누어서 몫, 나머지 이용

                reverse = reverse * 10 + (num % 10);
                num = num / 10;
            }

            Console.WriteLine("Reverse of Entered Number is : " + reverse);

            Console.ReadLine();



        }

    }

}