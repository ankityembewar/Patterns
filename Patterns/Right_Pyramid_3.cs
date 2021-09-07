using System;
class Right_Pyramid_3
{
  static void Main() 
  {
     Console.Write("Enter total layer : ");
     int num_layer = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine();
     for(int row=1;row<=num_layer;row++)
     {
        for(int col=1;col<=num_layer;col++)
         {
           if (col <(num_layer-(row-1)))
           {
             Console.Write(" ");
           }
           else
           {
             Console.Write("*");
           }
         }
        Console.WriteLine();
     }
  }
}
           
/* Output :

Enter total layer : 5

    *
   **
  ***
 ****
*****

*/
