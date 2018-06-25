using System;

class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  private bool isEquilateral()
  {
    return (SideA == SideB && SideB == SideC);
  }
  private bool isScalene()
  {
    return (SideA != SideB  && SideA != SideC && SideB != SideC);
  }
  private bool isIsoceles()
  {
    return ((SideA == SideB && SideA != SideC) || (SideA == SideC && SideA != SideB) || (SideB == SideC && SideB != SideA));
  }

  public void WhatAmI()
  {
    if (isEquilateral())
    {
      Console.WriteLine("congrats this is an equilateral.");
    }
    else if (isScalene())
    {
      Console.WriteLine("this is a Scalene triangle");
    }
    else if (isIsoceles())
    {
      Console.WriteLine("this is an isosceles triangle");
    }
    else
    {
      Console.WriteLine("this isnt a triangle");
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
    myTriangle.WhatAmI();
  }
}
