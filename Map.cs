namespace TreehouseDefense
{
  class Map //template for creating objects
  {
    public readonly int Width; // instant variables = exist as long as object exist
    public readonly int Height; 
    
    public Map(int width, int height) // method level variables = only exist inside this method (inside scope of method)
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point) //method to determine if point is on the map
    {
      return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
      
    }
  }
}