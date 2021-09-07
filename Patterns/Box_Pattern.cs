using System;

class box_pattern
{
    static void Main(string[] args)
    {
       
        bool check = false;
        while (check == false) 
        {
            Console.Write("Enter row or Columns {odd number}: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                check = true;
                Console.Write("\nEnter symbol for outer border: ");
                string symbol_1 = Console.ReadLine();
                Console.Write("\nEnter symbol for inner border: ");
                string symbol_2 = Console.ReadLine();
                Console.Write("\nEnter symbol for center: ");
                string symbol_3 = Console.ReadLine();
                Console.WriteLine();
                int y = (n / 2) + 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if ((i == y) && (j == y))
                        {
                            Console.Write(symbol_3 + " ");
                        }
                        else if (((i >= 2) && (i <= n - 1)) && ((j >= 2) && (j <= n - 1)))
                        {
                            Console.Write(symbol_2 + " ");
                        }
                        else
                        {
                            Console.Write(symbol_1 + " ");
                        }
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.Write("\n****Please Enter Proper Input****\n");
                Console.WriteLine();
            } 
        } 
    }
}

//Output
/*
Enter row or Columns {odd number}: 11

Enter symbol for outer border: *

Enter symbol for inner border: -

Enter symbol for center: $

* * * * * * * * * * * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* - - - - $ - - - - * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* - - - - - - - - - * 
* * * * * * * * * * * 

*/
