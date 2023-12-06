// Reviewing class methods 

//filename: proj.cs
using System;

namespace MyApplication
{
  class Proj
  {
    // Field
    public string material;

    // Create a class constructor with a parameter yarn
    public Proj()
    {
      material = "yarn";
    }

    static void Main(string[] args)
    {
      // create object with the type as yarn 
      Proj vest = new Proj();
      Console.WriteLine(Proj.material);
    }
  }
}