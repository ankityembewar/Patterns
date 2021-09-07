using System;
class Right_Pyramid_1
{
  static void Main() 
  {
     Console.Write("Enter total layer : ");
     int num_layer = Convert.ToInt32(Console.ReadLine());
     for(int row=1;row<=num_layer;row++)
     {
         for(int col=1;col<=num_layer;col++)
         {
             if(row<col)
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

/* Output:
Enter total layer : 5

*    
**   
***  
**** 
*****

*/
