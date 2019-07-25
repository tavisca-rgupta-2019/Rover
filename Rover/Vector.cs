using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Vector
    {
        public int currentXCoordinate { get; set; }
        public int currentYCoordinate{get; set;}
        public string currentFacingDirection { get; set; }

        public void SetCurrentPosition(String statement)
        {
            string[] position = statement.Split(' ');
            currentXCoordinate = int.Parse(position[0]);
            currentYCoordinate = int.Parse(position[1]);
            currentFacingDirection = position[2];
        }
        public string GetCurrentPosition()
        {
            return currentXCoordinate.ToString() + " " + currentYCoordinate.ToString()+" "+currentFacingDirection;
        }
       
    }
}
