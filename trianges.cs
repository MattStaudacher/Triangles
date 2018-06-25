using System;

class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  public bool IsTriangle()
  {
    if (SideA == SideB && SideB == SideC)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter length of Side A: ");
    string stringSideA = Console.ReadLine();
    int mySideA = int.Parse(stringSideA);
    myTriangle.SideA = mySideA;

    Console.WriteLine("Enter length of Side B: ");
    string stringSideB = Console.ReadLine();
    int mySideB = int.Parse(stringSideB);
    myTriangle.SideB = mySideB;

    Console.WriteLine("Enter length of Side C: ");
    string stringSideC = Console.ReadLine();
    int mySideC = int.Parse(stringSideC);
    myTriangle.SideC = mySideC;

    if (myTriangle.IsTriangle())
    {
      Console.WriteLine("congrats this is an isocselseseseess.");
    }
    else
    {
      Console.WriteLine("sorry dude");
    }


  }
}
