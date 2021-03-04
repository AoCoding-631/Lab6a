using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {


    Console.WriteLine("Enter celsius temp: ");
    int num = Convert.ToInt32(Console.ReadLine());

      //array declaration
    double[] fahrenheit  = new double[num];
    double[] celsius = new double [num];
    double sum = 0.0;


    for(int i=0; i < celsius.Length; i++)
    {
      Console.WriteLine("Enter celsius temp: ");
      celsius[i] = Convert.ToDouble(Console.ReadLine());

      //convert temp to fahrenheit
      fahrenheit[i] = celsius[i] * 9/5 + 32;

      // sort int array
      Array.Sort(fahrenheit);
      Console.WriteLine("desending fahrenheit temp");
      foreach(double x in fahrenheit)
      {
      Console.WriteLine("fahrenheit = " + x);
    }
    }
    
  }
}