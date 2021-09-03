using System;
class Right_Pyramid_2
{
  static void Main() 
  {
     Console.Write("Enter total layer : ");
     int num_layer = Convert.ToInt32(Console.ReadLine());
     for(int i=1;i<=num_layer;i++)
     {
         for(int j=1;j<=(num_layer-(i-1));j++)
         {
             Console.Write("*");
         }
         Console.WriteLine();
     }
  }
}
