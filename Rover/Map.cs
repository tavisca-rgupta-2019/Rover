using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Map
    {
        private static int maxXAxisCoordinates, maxYAxisCoordinates;

        public  void SetRangeOfMap(String statement)
        {
            maxXAxisCoordinates = int.Parse(statement[0].ToString());
            maxYAxisCoordinates = int.Parse(statement[2].ToString());
        }
        public string GetRangeOfMap()
        {
            return maxXAxisCoordinates.ToString() + " " + maxYAxisCoordinates.ToString();
        }
          
        public bool IsValidCoordinates(String Coordinates)
        {
            if (int.Parse(Coordinates[0].ToString()) > maxXAxisCoordinates || int.Parse(Coordinates[0].ToString()) < 0 ||
                int.Parse(Coordinates[2].ToString()) > maxYAxisCoordinates || int.Parse(Coordinates[2].ToString()) < 0 )
                return false;
            else
                return true;
        }
         
    }
}
