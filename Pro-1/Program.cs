﻿
      // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

                                          //      2, 3, 7 -> 7
                                         //      44 5 78 -> 78
                                         //      22 3 9 -> 22


         int a = 2;
         int b = 3;

         int c = 7;
         int max = a;

           if (b > max)
        {
           max = b;
        }
          if (c > max)
       {
          max = c;
        }
     Console.WriteLine( max);


       // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

                                 //     a = 5; b = 7 -> max = 7
                                 //     a = 2 b = 10 -> max = 10
                                 //     a = -9 b = -3 -> max = -3

       int d =5;   
       int f =7;      
       int maxi = f;
       int min = d;

        if ( d > f )
    {    max = f ;

         min = d ;
     } 
      
      Console.WriteLine(maxi);
       Console.WriteLine(min);
     
     
    // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

                            //4 -> да
                            //-3 -> нет
                            //7 -> нет


            
       int number = 7;

        if (number % 2 == 0) {
            Console.WriteLine("yes");
        } else {
            Console.WriteLine("no");
        }
              
          