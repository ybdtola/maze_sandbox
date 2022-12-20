using System;
using System.Collections.Generic;

class Program
{

    public enum Direction { Up, Down, Left, Right };


    public static void Main(string[] args)
    {
      List<Direction> directions = new List<Direction> 
      { 
        Direction.Up, 
        Direction.Down, 
        Direction.Left, 
        Direction.Right 
      };


      while (directions.Count > 0)
        {
          List <Direction> rndList = new List<Direction>();
          Random rnd = new Random();
          int rndInt = rnd.Next(0, directions.Count);
          rndList.Add(directions[rndInt]);
          directions.RemoveAt(rndInt);
          for(int i = 0; i < rndList.Count; i++)
          {
            Console.WriteLine(rndList[i]);
          }
        }
    }
      
}

       

