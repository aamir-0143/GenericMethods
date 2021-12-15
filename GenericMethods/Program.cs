using System;
namespace GenericMethods
{ 
  class program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Find Maximum Number!");

        int[] intArray = { 1, 2, 9, 4 };
        MaximumNumber<int> generic = new MaximumNumber<int>();
        generic.PrintMaxValue(intArray);


    }
  }
}