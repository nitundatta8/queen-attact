using System;
using System.Collections.Generic;
class Queen
{
  public static List<int> opp = new List<int>();
  public static List<int> queen = new List<int>();
  static void Main()
  {

    Console.WriteLine("give x coordinates for opponent from [1-8]");

    string answerX = Console.ReadLine();
    int numX = int.Parse(answerX);

    if (numX > 0 && numX < 9)
    {
      opp.Add(numX);
    }
    else
    {
      Console.WriteLine("error");
    }
    Console.WriteLine("give y coordinates for opponent from [1-8]");

    string answerY = Console.ReadLine();
    int numY = int.Parse(answerY);

    if (numY > 0 && numY < 9)
    {
      opp.Add(numY);
    }
    else
    {
      Console.WriteLine("error");
    }
    Console.WriteLine(opp[0] + "," + opp[1]);

    Console.WriteLine("give x coordinates for queen from [1-8]");

    string qX = Console.ReadLine();
    int queenX = int.Parse(qX);

    if (queenX > 0 && queenX < 9)
    {
      queen.Add(queenX);
    }
    else
    {
      Console.WriteLine("error");
    }
    Console.WriteLine("give y coordinates for queen from [1-8]");

    string qY = Console.ReadLine();
    int queenY = int.Parse(qY);

    if (queenY > 0 && queenY < 9)
    {
      queen.Add(queenY);
    }
    else
    {
      Console.WriteLine("error");
    }
    Console.WriteLine(queen[0] + "," + queen[1]);


  

  if (queen[0] == opp[0] || queen[1] == opp[1]) {
      Console.WriteLine("the queen has attacked!");
    }else if(Math.Abs(queen[0] - queen[1]) == Math.Abs(opp[0] - opp[1])){
      Console.WriteLine("the queen has attacked!");
    }
    else{
      Console.WriteLine("the queen has not attacked!");
      Main();
    }

  }


// else if(Math.Abs(queen[0] - queen[1]) == Math.Abs(opp[0] - opp[1])){
//       Console.WriteLine("the queen has attacked!");
//     }

















































    // int queenX = Console.ReadLine();
}