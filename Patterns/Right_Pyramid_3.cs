using System;
class Right_Pyramid_3
{
  static void Main() 
  {
     Console.Write("Enter total layer : ");
     int num_layer = Convert.ToInt32(Console.ReadLine());
     int i ,j;
     for(i=1;i<=num_layer;i++)
     {
         for(j=1;j<=num_layer;j++)
         {
             if(j<i)
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
