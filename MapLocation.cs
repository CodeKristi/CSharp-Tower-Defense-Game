namespace TreehouseDefense
{
  class MapLocation : Point // :Point specify that this is subclass of Point 
  {
      public MapLocation(int x, int y, Map map) : base (x, y)// takes same parameters as Point constructor (it's a more specialized point constructor) //base refers to parent class & its required parameters
      {
        if (!map.OnMap(this)) //determine if MapLocation is not on the map (equals to true)
        {
          throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map."); // throw an exception 
        }
      }
    
    public bool InRangeOf(MapLocation location, int range)
    {
      return DistanceTo(location) <= range;
    }
    
    
  }
}