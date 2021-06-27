using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Salesperson name");
    string name = Console.ReadLine();
    Console.WriteLine ("Enter sales amount");
    double salesamount = Convert.ToDouble(Console.ReadLine());
    double commission = 200 + (0.09 * salesamount);
    Console.WriteLine("Sales commission for " + name + " is $" + commission);
    if (salesamount < 3000)
    {
     Console.WriteLine("Performance is poor");
    }
    else if (salesamount < 5000)
    {
      Console.WriteLine("Performance is average");
    }
    else if (salesamount < 10000)
    {
      Console.WriteLine("Performance is good");
    }
    else if (salesamount < 15000)
    {
      Console.WriteLine("Performance is excellent");
    }
    else if (salesamount > 14999)
    {
      Console.WriteLine("Performance is outstanding");
    }
  }
}