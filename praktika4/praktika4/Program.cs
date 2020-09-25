using System;
using System.Collections;
class Program
{
  static void Main(string[] args)
  {
    ArrayList myList = new ArrayList
    {
      "First",
      "Second",
      "Third",
      "Fourth"
    }; foreach (string item in myList)
    {
      Console.WriteLine("Unsorted: {0}", item);
    }
    // Сортировка при помощи стандартного объекта сравнения 
    myList.Sort();
    foreach (string item in myList)
    {
      Console.WriteLine("   Sorted: {0}", item);
    }
  }
}


