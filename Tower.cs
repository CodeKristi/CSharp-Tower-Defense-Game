using System;

namespace TreehouseDefense
{
  class Tower //template for creating objects
  {
    private const int _range = 1;
    private const int _power = 1;
    private const double _accuracy = .75;
    
    private static readonly Random _random = new Random();
    
    private readonly MapLocation _location;
    
    public Tower (MapLocation location)
    {
      _location = location;
    }
    
    public bool IsSuccessfulShot()
    {
      return _random.NextDouble() < _accuracy;
    }
    
    public void FireOnInvaders(Invader[] invaders)
    {
//      int index = 0;
//      while(index < invaders.Length)
//      {
//        Invader invader = invaders[index];
//        // do stuff with invader
//        
//        index++; // same as index += 1;
//      }
      
      
      
//      for(int i = 0; i < invaders.Length; i++)
//      {
//        Invader invader = invaders[i];
//        // do stuff with invader
//      }
      
      foreach(Invader invader in invaders)
      {
         if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
            {
              if(IsSuccessfulShot())
              {
                invader.DecreaseHealth(_power);
                Console.WriteLine("Shot at and hit an invader!");
                
                if(invader.IsNeutralized)
                {
                  Console.WriteLine("Neutralized an invader!");
                }
              }
              else
              {
                Console.WriteLine("Shot at and missed an invader.");
              }
              break;
            }
      }
      
    }
  }
}